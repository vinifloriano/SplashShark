using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace SplashShark
{
    public partial class Pedido : UserControl
    {
        public Pedido()
        {
            InitializeComponent();
            txtQuantidade.KeyPress += Validacoes.TeclaNumero;
        }

        public void recarrega()
        {
            txtCPFCli.Items.Clear();
            txtNomeCli.Items.Clear();
            txtCodProd.Items.Clear();
            txtNomeProd.Items.Clear();
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();


            MySqlCommand cmd = new MySqlCommand("select cpf, nome from pessoafisica", objcon);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dtMensagens = new DataTable();
            da.Fill(dtMensagens);
            foreach (DataRow data in dtMensagens.Rows)
            {
                txtCPFCli.Items.Add(data[0].ToString());
                txtNomeCli.Items.Add(data[1].ToString());
            }

            MySqlCommand cmd1 = new MySqlCommand("select pessoajuridica.cnpj, cliente.nome from cliente inner join pessoajuridica on cliente.id_cliente = pessoajuridica.id_cliente", objcon);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            DataTable dtMensagens1 = new DataTable();
            da1.Fill(dtMensagens1);
            foreach (DataRow data1 in dtMensagens1.Rows)
            {
                txtCPFCli.Items.Add(data1[0].ToString());
                txtNomeCli.Items.Add(data1[1].ToString());
            }

            MySqlCommand cmd2 = new MySqlCommand("select codigo_produto, nome from produto", objcon);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataTable dtMensagens2 = new DataTable();
            da2.Fill(dtMensagens2);
            foreach (DataRow data in dtMensagens2.Rows)
            {
                txtCodProd.Items.Add(data[0].ToString());
                txtNomeProd.Items.Add(data[1].ToString());
            }
            objcon.Close();
        }

        int id_pedido = 0, id_cli;
        double oldPreco;

        private void MandaEmail(string produto)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objCon.Open();
            MySqlCommand cmd2 = new MySqlCommand("SELECT email_recuperacao from login WHERE is_dono = 1", objCon);
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("splashshark.drive@gmail.com", "splashshark123");
            MailMessage mail = new MailMessage();
            mail.Sender = new System.Net.Mail.MailAddress("splashshark.drive@gmail.com", "Splash Shark");
            mail.From = new MailAddress("splashshark.drive@gmail.com", "SplashShark");

            mail.To.Add(new MailAddress(cmd2.ExecuteScalar().ToString(), "Usuário"));
            mail.Subject = "Produto está acabando";
            mail.Body = "Caro administrador, solicito a compra do produto: <b>" + produto + "</b>, pois sua quantidade no estoque é inferior a 10, caso não queira que acabe, solicite para o fornecedor o mais rápido possível.";
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                //trata erro
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                mail = null;

            }
            objCon.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNomeCli.Text == "" || txtCPFCli.Text == "")
            {
                MessageBox.Show("Selecione o cliente.");
            }
            else if (txtCodProd.Text == "" || txtNomeProd.Text == "")
            {
                MessageBox.Show("Selecione o produto.");
            }
            else if (int.Parse(lbQuantProd.Text) < int.Parse(txtQuantidade.Text))
            {
                MessageBox.Show("Não há essa quantidade no estoque, certifique-se de que o produto é esse mesmo.");
            }
            else
            {
                try
                {
                    if(int.Parse(lbQuantProd.Text) - int.Parse(txtQuantidade.Text) < 10)
                    {
                        MandaEmail(txtNomeProd.Text);
                    } 
                    if (id_pedido == 0)
                    {
                        ClientePedido pdcli = new ClientePedido();

                        pdcli.Emissao = DateTime.Now.Date;

                        MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                        // abre o banco
                        objCon.Open();
                        MySqlCommand cmd2;
                        if (txtCPFCli.Text.Length > 14)
                            cmd2 = new MySqlCommand("SELECT id_cliente from pessoajuridica WHERE cnpj ='" + txtCPFCli.Text + "'", objCon);
                        else
                            cmd2 = new MySqlCommand("SELECT id_cliente from pessoafisica WHERE cpf ='" + txtCPFCli.Text + "'", objCon);
                        id_cli = Convert.ToInt32(cmd2.ExecuteScalar());
                        objCon.Close();

                        pdcli.Criar(id_cli);
                        id_pedido = pdcli.Numero;
                    }

                    int cod_prod = int.Parse(txtCodProd.Text);
                    Item_Pedido itemPed = new Item_Pedido();

                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                    objcon.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * from itempedido where numero_pedido = " + id_pedido + " and codigo_produto =" + cod_prod, objcon);

                    if (cmd.ExecuteScalar() != null)
                    {
                        itemPed.Excluir(id_pedido, cod_prod);
                        for (int i = 0; i < dataGridViewPedido.Rows.Count - 1; i++)
                        {
                            if (dataGridViewPedido.Rows[i].Cells[0].Value.ToString() == cod_prod.ToString())
                            {
                                dataGridViewPedido.CurrentCell = dataGridViewPedido.Rows[i].Cells[0];
                            }
                        }
                        oldPreco = Convert.ToDouble(dataGridViewPedido.CurrentRow.Cells[3].Value);
                        dataGridViewPedido.Rows.Remove(dataGridViewPedido.CurrentRow);
                        lbTotal.Text = (double.Parse(lbTotal.Text) - oldPreco).ToString("F");
                    }

                    dataGridViewPedido.Rows.Add();
                    dataGridViewPedido.CurrentCell = dataGridViewPedido.Rows[dataGridViewPedido.Rows.Count - 1].Cells[0];
                    dataGridViewPedido.CurrentRow.Cells[0].Value = txtCodProd.Text;
                    dataGridViewPedido.CurrentRow.Cells[1].Value = txtNomeProd.Text;
                    dataGridViewPedido.CurrentRow.Cells[2].Value = txtQuantidade.Text;

                    MySqlCommand objcmd2 = new MySqlCommand("SELECT preco from produto where codigo_produto =" + cod_prod, objcon);
                    double preco = double.Parse(objcmd2.ExecuteScalar().ToString());
                    dataGridViewPedido.CurrentRow.Cells[3].Value = preco.ToString("F");
                    objcon.Close();

                    itemPed.Preco = preco;
                    itemPed.Quantidade = int.Parse(txtQuantidade.Text);
                    itemPed.Criar(id_pedido, cod_prod);

                    double subtotal = preco * int.Parse(txtQuantidade.Text);
                    dataGridViewPedido.CurrentRow.Cells[4].Value = subtotal.ToString("F");

                    lbTotal.Text = (double.Parse(lbTotal.Text) + subtotal).ToString("F");
                    txtQuantidade.Text = "1";

                    txtCPFCli.Enabled = false;
                    txtNomeCli.Enabled = false;
                }
                catch
                {

                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            ClassRelatorio.geraNotaFiscal(id_pedido, double.Parse(lbTotal.Text).ToString("F"), id_cli);
            txtNomeCli.Text = "";
            txtCPFCli.Text = "";
            txtCodProd.Text = "";
            txtNomeProd.Text = "";
            txtQuantidade.Text = "1";
            lbQuantProd.Text = "";
            lbTotal.Text = "0,00";
            txtCPFCli.Enabled = true;
            txtNomeCli.Enabled = true;
            dataGridViewPedido.Rows.Clear();
            MessageBox.Show("Pedido realizado com sucesso!");
            id_pedido = 0;
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            if (txtQuantidade.Text == "")
            {
                txtQuantidade.Text = "1";
            }
        }

        private void txtCPFCli_Leave(object sender, EventArgs e)
        {
            if (txtCPFCli.SelectedIndex == -1)
            {
                txtCPFCli.Text = "";
            }
        }

        private void Valida_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox txt = sender as ComboBox;
            if (txt.SelectedIndex == -1)
            {
                txt.Text = "";
            }
        }

        private void txtCPFCli_SelectedValueChanged(object sender, EventArgs e)
        {
            txtNomeCli.SelectedIndex = txtCPFCli.SelectedIndex;
        }

        private void txtCodProd_SelectedValueChanged(object sender, EventArgs e)
        {
            txtNomeProd.SelectedIndex = txtCodProd.SelectedIndex;
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT quantidade from estoque where codigo_produto = " + txtCodProd.Text, objCon);
            lbQuantProd.Text = cmd.ExecuteScalar().ToString();
            objCon.Close();

        }

        private void txtNomeCli_SelectedValueChanged(object sender, EventArgs e)
        {
            txtCPFCli.SelectedIndex = txtNomeCli.SelectedIndex;
        }

        private void txtNomeProd_SelectedValueChanged(object sender, EventArgs e)
        {
            txtCodProd.SelectedIndex = txtNomeProd.SelectedIndex;
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT quantidade from estoque where codigo_produto = " + txtCodProd.Text, objCon);
            lbQuantProd.Text = cmd.ExecuteScalar().ToString();
            objCon.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark");
                // abre o banco
                objcon.Open();
                MySqlCommand cmd1 = new MySqlCommand("SELECT numero_pedido from pedido ORDER BY numero_pedido DESC LIMIT 1", objcon);
                int id = Convert.ToInt32(cmd1.ExecuteScalar());
                MySqlCommand objcmd1 = new MySqlCommand("delete from pedido where numero_pedido = ?", objcon);
                MySqlCommand objcmd2 = new MySqlCommand("delete from itempedido where numero_pedido = " + id, objcon);
                objcmd1.Parameters.Clear();
                objcmd1.Parameters.Add("@numero_pedido", MySqlDbType.Int32).Value = id;
                objcmd1.CommandType = CommandType.Text;
                objcmd2.ExecuteNonQuery();
                objcmd1.ExecuteNonQuery();
                objcon.Close();
            }
            catch
            {

            }
            txtNomeCli.Text = "";
            txtCPFCli.Text = "";
            txtCodProd.Text = "";
            txtNomeProd.Text = "";
            txtQuantidade.Text = "1";
            lbQuantProd.Text = "";
            lbTotal.Text = "0,00";
            txtCPFCli.Enabled = true;
            txtNomeCli.Enabled = true;
            dataGridViewPedido.Rows.Clear();
            id_pedido = 0;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Item_Pedido ped = new Item_Pedido();
            try
            {
                int cod_prod = int.Parse(dataGridViewPedido.CurrentRow.Cells[0].Value.ToString());
                ped.Excluir(id_pedido, cod_prod);
                dataGridViewPedido.Rows.Remove(dataGridViewPedido.CurrentRow);
            }
            catch (Exception errodel)
            {
                MessageBox.Show("Erro ao deletar: " + errodel);
            }
        }
    }
}
