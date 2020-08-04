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
    public partial class VisualizaFornecedor : UserControl
    {
        public VisualizaFornecedor()
        {
            InitializeComponent();
            selecCampo.SelectedItem = "Todos";
            btnRemover2.Click += BtnRemover_Click;
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
                Fornecedor fr = new Fornecedor();
                fr.MostraDesativados = mostraDesativados;
                fr.Mostrar(dataGridViewForn);
            }
            catch (Exception errosel)
            {
                MessageBox.Show("Erro ao Buscar: " + errosel);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string col = "";
            string valor = txtPesquisa.Text;
            bool like = false;

            switch (selecCampo.SelectedItem.ToString())
            {
                case "ID":
                    col = "id_fornecedor";
                    break;
                case "Nome":
                    col = "nome";
                    like = true;
                    break;
                case "Email":
                    col = "email";
                    like = true;
                    break;
                case "Pseudônimo":
                    col = "pseudonimo";
                    like = true;
                    break;
                case "CNPJ":
                    col = "cnpj";
                    valor = "'" + valor + "'";
                    break;
                case "Inscrição Estadual":
                    col = "inscricaoEstadual";
                    valor = "'" + valor + "'";
                    break;
                case "Todos":
                    recarrega();
                    break;
            }
            if (selecCampo.SelectedItem.ToString() != "Todos" && txtPesquisa.Text != "")
            {
                Fornecedor forn = new Fornecedor();
                forn.Buscar(dataGridViewForn, col, valor, like);
            }

        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(("Tem certeza que deseja desativar o fornecedor?"), "Fornecedores", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                    objcon.Open();
                    int id;
                    id = int.Parse(dataGridViewForn.CurrentRow.Cells[0].Value.ToString());
                    MySqlCommand objcmd = new MySqlCommand("UPDATE fornecedor SET flg_ativo=0 WHERE id_fornecedor = ?", objcon);

                    objcmd.Parameters.Add("@id_fornecedor", MySqlDbType.Int32).Value = id;
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

            if (MessageBox.Show(("Tem certeza que deseja ativar o fornecedor?"), "Fornecedores", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                    objcon.Open();
                    int id;
                    id = int.Parse(dataGridViewForn.CurrentRow.Cells[0].Value.ToString());
                    MySqlCommand objcmd = new MySqlCommand("UPDATE fornecedor SET flg_ativo=1 WHERE id_fornecedor = ?", objcon);

                    objcmd.Parameters.Add("@id_fornecedor", MySqlDbType.Int32).Value = id;
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

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objcon.Open();
            MySqlCommand objcmd = new MySqlCommand("select COUNT(*) from compra where id_fornecedor = " + dataGridViewForn.CurrentRow.Cells[0].Value.ToString(), objcon);
            if (objcmd.ExecuteScalar().ToString() != "0")
            {
                MessageBox.Show("Impossível remover este fornecedor, ele já possui um histórico nessa loja.");
            }
            else
            {
                if (MessageBox.Show(("Tem certeza que deseja remover o Fornecedor?"), "Fornecedores", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Fornecedor forn = new Fornecedor();
                    try
                    {
                        int id = int.Parse(dataGridViewForn.CurrentRow.Cells[0].Value.ToString());
                        forn.Excluir(id);
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
                    txtPesquisa.KeyPress += Validacoes.TeclaLetra;
                    txtPesquisa.Enabled = true;
                    break;
                case "Email":
                    txtPesquisa.Enabled = true;
                    break;
                case "Pseudônimo":
                    txtPesquisa.Enabled = true;
                    break;
                case "CNPJ":
                    txtPesquisa.Mask = "00,000,000/0000-00";
                    txtPesquisa.KeyPress += Validacoes.TeclaNumero;
                    txtPesquisa.Enabled = true;
                    break;
                case "Inscrição Estadual":
                    txtPesquisa.Mask = "000,000,000,000";
                    txtPesquisa.KeyPress += Validacoes.TeclaNumero;
                    txtPesquisa.Enabled = true;
                    break;
                case "Todos":
                    txtPesquisa.Clear();
                    txtPesquisa.Enabled = false;
                    break;
            }
        }

        private void EnviaComEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnBuscar.PerformClick();
                e.Handled = true;
            }
        }

        public event EventHandler EditaForn;

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                // abre o banco
                objcon.Open();
                string id = dataGridViewForn.CurrentRow.Cells[0].Value.ToString();
                MySqlCommand endereco = new MySqlCommand("select id_endereco from fornecedorendereco where id_fornecedor = " + id, objcon);
                int idEnd = Convert.ToInt32(endereco.ExecuteScalar());

                MySqlCommand objcmd1 = new MySqlCommand("select logradouro from endereco where id_endereco = " + idEnd, objcon);
                MySqlCommand objcmd2 = new MySqlCommand("select bairro from endereco where id_endereco = " + idEnd, objcon);
                MySqlCommand objcmd3 = new MySqlCommand("select cidade from endereco where id_endereco = " + idEnd, objcon);
                MySqlCommand objcmd4 = new MySqlCommand("select cep from endereco where id_endereco = " + idEnd, objcon);
                MySqlCommand objcmd5 = new MySqlCommand("select numero from endereco where id_endereco = " + idEnd, objcon);
                MySqlCommand objcmd6 = new MySqlCommand("select uf from endereco where id_endereco = " + idEnd, objcon);

                CadastraFornecedor frm = new CadastraFornecedor();

                frm.lbId.Text = id;
                frm.txtNome.Text = dataGridViewForn.CurrentRow.Cells[1].Value.ToString();
                frm.txtPseudonimo.Text = dataGridViewForn.CurrentRow.Cells[2].Value.ToString();
                frm.txtEmail.Text = dataGridViewForn.CurrentRow.Cells[3].Value.ToString();
                frm.txtCNPJ.Text = dataGridViewForn.CurrentRow.Cells[4].Value.ToString();
                frm.txtInscEstadual.Text = dataGridViewForn.CurrentRow.Cells[5].Value.ToString();
                frm.txtRua.Text = objcmd1.ExecuteScalar().ToString();
                frm.txtBairro.Text = objcmd2.ExecuteScalar().ToString();
                frm.txtCidade.Text = objcmd3.ExecuteScalar().ToString();
                frm.txtCep.Text = objcmd4.ExecuteScalar().ToString();
                frm.txtNum.Text = objcmd5.ExecuteScalar().ToString();
                frm.txtEstado.SelectedItem = objcmd6.ExecuteScalar().ToString();

                objcon.Close();

                frm.BackColor = Color.FromArgb(240, 240, 240);
                frm.AutoScroll = true;
                frm.Left = 256;
                frm.Height = 500;
                frm.lbTitulo.Text = "Edita Fornecedor";
                frm.btnCancelar.Visible = true;

                EventHandler handler = EditaForn;
                handler?.Invoke(frm, e);
            }
            catch { MessageBox.Show("Não há registros para editar!"); }
        }

        private void chkDesativados_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDesativados.Checked == true)
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
