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
    public partial class VisualizaCliente : UserControl
    {
        public VisualizaCliente()
        {
            InitializeComponent();
            selecCampo.SelectedItem = "Todos";
            btnRemover2.Click += btnRemover_Click;
            btnEditar2.Click += btnEditar_Click;
            btnDesativar.Click += btnDesativar_Click;
            btnAtivar.Click += btnAtivar_Click;
            btnAtivar.Visible = false;
        }
        int mostraDesativados = 1;
        public void recarrega()
        {
            try
            {
                Cliente cl = new Cliente();
                cl.MostraDesativados = mostraDesativados;
                if(radioFisica.Checked)
                    cl.MostrarPF(dataGridViewPF);
                else
                    cl.MostrarPJ(dataGridViewPJ);
            }
            catch (Exception errosel)
            {
                MessageBox.Show("Erro ao Buscar: " + errosel);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string col = "";
            string valor = txtPesquisa.Text;
            bool like = false;

            switch (selecCampo.SelectedItem.ToString())
            {
                case "ID":
                    col = "ID";
                    break;
                case "Nome":
                    col = "Nome";
                    like = true;
                    break;
                case "Email":
                    col = "Email";
                    like = true;
                    break;
                case "Telefone":
                    col = "Telefone";
                    like = true;
                    break;
                case "Todos":
                    recarrega();
                    break;
            }
            if (selecCampo.SelectedItem.ToString() != "Todos" && txtPesquisa.Text != "")
            {
                PessoaJuridica pj = new PessoaJuridica();
                PessoaFisica pf = new PessoaFisica();

                if (radioFisica.Checked)
                    pf.BuscarPF(dataGridViewPF, col, valor, like);
                else
                pj.BuscarPJ(dataGridViewPJ, col, valor, like);
            }

        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(("Tem certeza que deseja desativar o cliente?"), "Clientes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                    objcon.Open();
                    int id;
                    if (radioFisica.Checked)
                    {
                        id = int.Parse(dataGridViewPF.CurrentRow.Cells[0].Value.ToString());
                    }
                    else
                    {
                        id = int.Parse(dataGridViewPJ.CurrentRow.Cells[0].Value.ToString());
                    }
                    MySqlCommand objcmd = new MySqlCommand("UPDATE cliente SET flg_ativo=0 WHERE id_cliente = ?", objcon);
                    
                    objcmd.Parameters.Add("@id_cliente", MySqlDbType.Int32).Value = id;
                    objcmd.ExecuteNonQuery();
                    // fecha a conexao
                    objcon.Close();
                    recarrega();
                }
                catch
                {
                    MessageBox.Show("Impossível desativar");
                }
            }
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(("Tem certeza que deseja ativar o cliente?"), "Clientes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                    objcon.Open();
                    int id;
                    if (radioFisica.Checked)
                    {
                        id = int.Parse(dataGridViewPF.CurrentRow.Cells[0].Value.ToString());
                    }
                    else
                    {
                        id = int.Parse(dataGridViewPJ.CurrentRow.Cells[0].Value.ToString());
                    }
                    MySqlCommand objcmd = new MySqlCommand("UPDATE cliente SET flg_ativo=1 WHERE id_cliente = ?", objcon);

                    objcmd.Parameters.Add("@id_cliente", MySqlDbType.Int32).Value = id;
                    objcmd.ExecuteNonQuery();
                    // fecha a conexao
                    objcon.Close();
                    recarrega();
                }
                catch
                {
                    MessageBox.Show("Impossível desativar");
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                objcon.Open();
                MySqlCommand objcmd = new MySqlCommand("select COUNT(*) from pedido where id_cliente = " + (radioFisica.Checked ? dataGridViewPF.CurrentRow.Cells[0].Value.ToString() : dataGridViewPJ.CurrentRow.Cells[0].Value.ToString()), objcon);
                if (objcmd.ExecuteScalar().ToString() != "0")
                {
                    MessageBox.Show("Impossível remover este cliente, ele já possui um histórico nessa loja.");
                }
                else
                {
                    if (MessageBox.Show(("Tem certeza que deseja remover o Cliente?"), "Clientes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        PessoaJuridica pj = new PessoaJuridica();
                        PessoaFisica pf = new PessoaFisica();
                        try
                        {
                            int id;
                            if (radioFisica.Checked)
                            {
                                id = int.Parse(dataGridViewPF.CurrentRow.Cells[0].Value.ToString());
                                pf.ExcluiPF(id);
                            }
                            else
                            {
                                id = int.Parse(dataGridViewPJ.CurrentRow.Cells[0].Value.ToString());
                                pj.ExcluirPJ(id);
                            }
                        }
                        catch (Exception errodel)
                        {
                            MessageBox.Show("Erro ao deletar: " + errodel);
                        }
                        recarrega();
                    }
                }
                objcon.Close();
            }
            catch
            {

            }
        }

        public event EventHandler EditaCli;

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                // abre o banco
                objcon.Open();
                string id = dataGridViewPF.CurrentRow.Cells[0].Value.ToString();
                MySqlCommand endereco = new MySqlCommand("select id_endereco from clienteendereco where id_cliente = " + id, objcon);
                int idEnd = Convert.ToInt32(endereco.ExecuteScalar());

                MySqlCommand objcmd1 = new MySqlCommand("select logradouro from endereco where id_endereco = " + idEnd, objcon);
                MySqlCommand objcmd2 = new MySqlCommand("select bairro from endereco where id_endereco = " + idEnd, objcon);
                MySqlCommand objcmd3 = new MySqlCommand("select cidade from endereco where id_endereco = " + idEnd, objcon);
                MySqlCommand objcmd4 = new MySqlCommand("select cep from endereco where id_endereco = " + idEnd, objcon);
                MySqlCommand objcmd5 = new MySqlCommand("select numero from endereco where id_endereco = " + idEnd, objcon);
                MySqlCommand objcmd6 = new MySqlCommand("select uf from endereco where id_endereco = " + idEnd, objcon);
                MySqlCommand objcmdPF1 = new MySqlCommand("select CPF from ClientePF where ID = " + id, objcon);
                MySqlCommand objcmdPF2 = new MySqlCommand("select RG from ClientePF where ID = " + id, objcon);
                CadastraCliente cli = new CadastraCliente();
                cli.lbId.Text = id;
                if (radioFisica.Checked)
                {
                    cli.txtNome.Text = dataGridViewPF.CurrentRow.Cells[1].Value.ToString();
                    cli.txtTelefone.Text = dataGridViewPF.CurrentRow.Cells[5].Value.ToString();
                    cli.txtEmail.Text = dataGridViewPF.CurrentRow.Cells[2].Value.ToString();
                    cli.txtCPF.Text = objcmdPF1.ExecuteScalar().ToString();
                    cli.txtRG.Text = objcmdPF2.ExecuteScalar().ToString();
                    cli.btnPFisica.Checked = true;
                }
                else
                {
                    cli.txtNome.Text = dataGridViewPJ.CurrentRow.Cells[1].Value.ToString();
                    cli.txtTelefone.Text = dataGridViewPJ.CurrentRow.Cells[3].Value.ToString();
                    cli.txtEmail.Text = dataGridViewPJ.CurrentRow.Cells[2].Value.ToString();
                    cli.txtCNPJ.Text = dataGridViewPJ.CurrentRow.Cells[4].Value.ToString();
                    cli.txtInscEstadual.Text = dataGridViewPJ.CurrentRow.Cells[5].Value.ToString();
                    cli.txtRazaoSocial.Text = dataGridViewPJ.CurrentRow.Cells[6].Value.ToString();
                    cli.btnPJuridica.Checked = true;

                    cli.lbCNPJ.Visible = true;
                    cli.lbInscricaoEstadual.Visible = true;
                    cli.lbRazaoSocial.Visible = true;
                    cli.txtCNPJ.Visible = true;
                    cli.txtInscEstadual.Visible = true;
                    cli.txtRazaoSocial.Visible = true;
                    cli.txtRG.Visible = false;
                    cli.txtRazaoSocial.TabIndex = 5;
                    cli.txtCNPJ.TabIndex = 6;
                    cli.txtInscEstadual.TabIndex = 7;
                    cli.txtRG.TabIndex = 100;
                    cli.txtCPF.TabIndex = 101;
                }
                cli.txtRua.Text = objcmd1.ExecuteScalar().ToString();
                cli.txtBairro.Text = objcmd2.ExecuteScalar().ToString();
                cli.txtCidade.Text = objcmd3.ExecuteScalar().ToString();
                cli.txtCep.Text = objcmd4.ExecuteScalar().ToString();
                cli.txtNum.Text = objcmd5.ExecuteScalar().ToString();
                cli.txtEstado.SelectedItem = objcmd6.ExecuteScalar().ToString();
                cli.BackColor = Color.FromArgb(240,240,240);
                cli.AutoScroll = true;
                objcon.Close();
                cli.lbTitulo.Text = "Edita Cliente";
                cli.btnCancelar.Visible = true;
                EventHandler handler = EditaCli;
                handler?.Invoke(cli, e);
            }
            catch { MessageBox.Show("Não há registros para editar!"); }
            
        }

        private void EnviaComEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnBuscar.PerformClick();
                e.Handled = true;
            }
        }

        private void selecCampo_SelectedValueChanged(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
            txtPesquisa.Mask = "";
            txtPesquisa.KeyPress -= Validacoes.TeclaLetra;
            txtPesquisa.KeyPress -= Validacoes.TeclaNumero;
            switch (selecCampo.SelectedItem.ToString())
            {
                case "ID":
                    txtPesquisa.KeyPress += Validacoes.TeclaNumero;
                    txtPesquisa.Enabled = true;
                    break;
                case "Nome":
                case "Email":
                    txtPesquisa.KeyPress += Validacoes.TeclaLetra;
                    txtPesquisa.Enabled = true;
                    break;
                case "Telefone":
                    txtPesquisa.Mask = "(00)00000-0000";
                    txtPesquisa.KeyPress += Validacoes.TeclaNumero;
                    txtPesquisa.Enabled = true;
                    break;
                case "Todos":
                    txtPesquisa.Clear();
                    txtPesquisa.Enabled = false;
                    break;
            }
        }

        private void radioFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFisica.Checked)
            {
                dataGridViewPF.BringToFront();
                recarrega();
            }
            else
            {
                dataGridViewPJ.BringToFront();
                recarrega();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void chkDesativados_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDesativados.Checked == true)
            {
                mostraDesativados = 0;
                btnAtivar.Visible = true;
                btnDesativar.Visible = false;
            }
            else
            {
                mostraDesativados = 1;
                btnAtivar.Visible = false;
                btnDesativar.Visible = true;
            }
            recarrega();
        }
    }
}
