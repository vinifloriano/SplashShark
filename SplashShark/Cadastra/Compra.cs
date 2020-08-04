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

namespace SplashShark
{
    public partial class Compra : UserControl
    {
        public Compra()
        {
            InitializeComponent();
        }

        public void recarrega()
        {
            txtCNPJCod.Items.Clear();
            txtNomeForn.Items.Clear();
            txtCodProd.Items.Clear();
            txtNomeProd.Items.Clear();
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();


            MySqlCommand cmd = new MySqlCommand("select cnpj, nome from fornecedor", objcon);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dtMensagens = new DataTable();
            da.Fill(dtMensagens);
            foreach (DataRow data in dtMensagens.Rows)
            {
                txtCNPJCod.Items.Add(data[0].ToString());
                txtNomeForn.Items.Add(data[1].ToString());
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
        int num_compra=0, id_forn;
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNomeForn.Text == "" || txtCNPJCod.Text == "")
            {
                MessageBox.Show("Selecione o fornecedor.");
            }
            if (txtCodProd.Text == "" || txtNomeProd.Text == "")
            {
                MessageBox.Show("Selecione o produto.");
            }
            else
            {
                try
                {
                    if (num_compra == 0)
                    {
                        OrdemCompra ordcomp = new OrdemCompra();

                        ordcomp.Emissao = DateTime.Now.Date;
                        ordcomp.Atendida = false;
                        ordcomp.Previsao = DateTime.Now.Date;

                        MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                        objCon.Open();
                        MySqlCommand cmd2 = new MySqlCommand("SELECT id_fornecedor from fornecedor WHERE cnpj ='" + txtCNPJCod.Text + "'", objCon);
                        id_forn = Convert.ToInt32(cmd2.ExecuteScalar());
                        objCon.Close();

                        ordcomp.Emitir(id_forn);
                        num_compra = ordcomp.Numero;
                        txtCNPJCod.Enabled = false;
                        txtNomeForn.Enabled = false;
                    }

                    int cod_prod = int.Parse(txtCodProd.Text);
                    ItemCompra itemComp = new ItemCompra();

                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                    objcon.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * from itemcompra where numero_compra= " + num_compra + " and codigo_produto =" + cod_prod, objcon);

                    if (cmd.ExecuteScalar() != null)
                    {
                        itemComp.Excluir(num_compra, cod_prod);
                        for (int i = 0; i < dataGridViewCarrinho.Rows.Count - 1; i++)
                        {
                            if (dataGridViewCarrinho.Rows[i].Cells[0].Value.ToString() == cod_prod.ToString())
                            {
                                dataGridViewCarrinho.CurrentCell = dataGridViewCarrinho.Rows[i].Cells[0];
                            }
                        }
                        double oldPreco = Convert.ToDouble(dataGridViewCarrinho.CurrentRow.Cells[3].Value);
                        dataGridViewCarrinho.Rows.Remove(dataGridViewCarrinho.CurrentRow);
                        lbTotal.Text = (double.Parse(lbTotal.Text) - oldPreco).ToString("F");
                    }

                    dataGridViewCarrinho.Rows.Add();
                    dataGridViewCarrinho.CurrentCell = dataGridViewCarrinho.Rows[dataGridViewCarrinho.Rows.Count - 1].Cells[0];
                    dataGridViewCarrinho.CurrentRow.Cells[0].Value = txtCodProd.Text;
                    dataGridViewCarrinho.CurrentRow.Cells[1].Value = txtNomeProd.Text;
                    dataGridViewCarrinho.CurrentRow.Cells[2].Value = txtQuantidade.Text;

                    MySqlCommand objcmd = new MySqlCommand("SELECT preco from produto where codigo_produto =" + txtCodProd.Text, objcon);
                    double preco = double.Parse(objcmd.ExecuteScalar().ToString());
                    dataGridViewCarrinho.CurrentRow.Cells[3].Value = preco.ToString("F");
                    objcon.Close();
                    
                    itemComp.QtdComprada = int.Parse(txtQuantidade.Text);
                    itemComp.Criar(num_compra, int.Parse(txtCodProd.Text));

                    double subtotal = preco * double.Parse(txtQuantidade.Text);
                    dataGridViewCarrinho.CurrentRow.Cells[4].Value = subtotal.ToString("F");

                    lbTotal.Text = (double.Parse(lbTotal.Text) + subtotal).ToString("F");
                    txtQuantidade.Text = "1";
                }
                catch
                {

                }
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
            txtNomeForn.SelectedIndex = txtCNPJCod.SelectedIndex;
        }

        private void txtCodProd_SelectedValueChanged(object sender, EventArgs e)
        {
            txtNomeProd.SelectedIndex = txtCodProd.SelectedIndex;
        }

        private void txtNomeCli_SelectedValueChanged(object sender, EventArgs e)
        {
            txtCNPJCod.SelectedIndex = txtNomeForn.SelectedIndex;
        }

        private void txtNomeProd_SelectedValueChanged(object sender, EventArgs e)
        {
            txtCodProd.SelectedIndex = txtNomeProd.SelectedIndex;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            txtCNPJCod.Text = "";
            txtNomeForn.Text = "";
            txtCodProd.Text = "";
            txtNomeProd.Text = "";
            lbTotal.Text = "0,00";
            txtQuantidade.Text = "1";
            txtCNPJCod.Enabled = true;
            txtNomeForn.Enabled = true;
            dataGridViewCarrinho.Rows.Clear();
            MessageBox.Show("Compra realizada com sucesso!");
            num_compra = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark");
                // abre o banco
                objcon.Open();
                MySqlCommand cmd1 = new MySqlCommand("SELECT numero_compra from compra ORDER BY numero_compra DESC LIMIT 1", objcon);
                int id = Convert.ToInt32(cmd1.ExecuteScalar());
                MySqlCommand objcmd = new MySqlCommand("delete from compra where numero_compra = ?", objcon);
                objcmd.Parameters.Clear();
                objcmd.Parameters.Add("@numero_compra", MySqlDbType.Int32).Value = id;
                objcmd.CommandType = CommandType.Text;
                objcmd.ExecuteNonQuery();
                objcon.Close();
            }
            catch
            {

            }
            txtCNPJCod.Text = "";
            txtNomeForn.Text = "";
            txtCodProd.Text = "";
            txtNomeProd.Text = "";
            txtQuantidade.Text = "1";
            lbTotal.Text = "0,00";
            txtCNPJCod.Enabled = true;
            txtNomeForn.Enabled = true;
            dataGridViewCarrinho.Rows.Clear();
            num_compra = 0;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            ItemCompra comp = new ItemCompra();
            try
            {
                int cod_prod = int.Parse(dataGridViewCarrinho.CurrentRow.Cells[0].Value.ToString());
                comp.Excluir(num_compra, cod_prod);
                dataGridViewCarrinho.Rows.Remove(dataGridViewCarrinho.CurrentRow);
            }
            catch (Exception errodel)
            {
                MessageBox.Show("Erro ao deletar: " + errodel);
            }
        }
    }
}
