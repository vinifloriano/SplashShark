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
    public partial class VisualizaFuncionario : UserControl
    {
        public VisualizaFuncionario()
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
                Funcionario func = new Funcionario();
                func.MostraDesativados = mostraDesativados;
                func.Mostrar(dataGridViewFunc);
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
                    col = "id_funcionario";
                    break;
                case "Nome":
                    col = "nome";
                    like = true;
                    break;
                case "Email":
                    col = "email";
                    like = true;
                    break;
                case "Telefone":
                    col = "telefone";
                    like = true;
                    break;
                case "Sexo":
                    col = "sexo";
                    valor = "'" + valor + "'";
                    break;
                case "RG":
                    col = "rg";
                    valor = "'" + valor + "'";
                    break;
                case "CPF":
                    col = "cpf";
                    valor = "'" + valor + "'";
                    break;
                case "Data de Contratação":
                    string[] contraAntes = txtPesquisa.Text.Split('/');
                    string contra = "'" + contraAntes[2] + '-' + contraAntes[1] + '-' + contraAntes[0] + "'";
                    valor = "'" + contra + "'";
                    col = "data_contratacao";
                    break;
                case "Data de Nascimento":
                    string[] nascAntes = txtPesquisa.Text.Split('/');
                    string nasc = "'" + nascAntes[2] + '-' + nascAntes[1] + '-' + nascAntes[0] + "'";
                    valor = "'" + nasc + "'";
                    col = "data_nascimento";
                    break;
                case "Todos":
                    recarrega();
                    break;
            }
            if(selecCampo.SelectedItem.ToString() != "Todos" && txtPesquisa.Text != "")
            {
                Funcionario func = new Funcionario();
                func.Buscar(dataGridViewFunc, col, valor, like);
            }

        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(("Tem certeza que deseja desativar o funcionário?"), "Funcionários", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                    objcon.Open();
                    int id;
                    id = int.Parse(dataGridViewFunc.CurrentRow.Cells[0].Value.ToString());
                    MySqlCommand objcmd = new MySqlCommand("UPDATE funcionario SET flg_ativo=0 WHERE id_funcionario = ?", objcon);

                    objcmd.Parameters.Add("@id_funcionario", MySqlDbType.Int32).Value = id;
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

            if (MessageBox.Show(("Tem certeza que deseja ativar o funcionário?"), "Funcionários", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                    objcon.Open();
                    int id;
                    id = int.Parse(dataGridViewFunc.CurrentRow.Cells[0].Value.ToString());
                    MySqlCommand objcmd = new MySqlCommand("UPDATE funcionario SET flg_ativo=1 WHERE id_funcionario = ?", objcon);

                    objcmd.Parameters.Add("@id_funcionario", MySqlDbType.Int32).Value = id;
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
            if (MessageBox.Show(("Tem certeza que deseja remover o Funcionário?"), "Funcionários", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Funcionario func = new Funcionario();
                try
                {
                    func.Id_func = int.Parse(dataGridViewFunc.CurrentRow.Cells[0].Value.ToString());
                    func.Excluir();
                }
                catch (Exception errodel)
                {
                    MessageBox.Show("Erro ao deletar: " + errodel);
                }
                recarrega();
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
                    txtPesquisa.KeyPress += Validacoes.TeclaLetra;
                    txtPesquisa.Enabled = true;
                    break;
                case "Email":
                    txtPesquisa.KeyPress += Validacoes.TeclaLetra;
                    txtPesquisa.Enabled = true;
                    break;
                case "Telefone":
                    txtPesquisa.Mask = "(00)00000-0000";
                    txtPesquisa.KeyPress += Validacoes.TeclaNumero;
                    txtPesquisa.Enabled = true;
                    break;
                case "CPF":
                    txtPesquisa.Mask = "000,000,000-00";
                    txtPesquisa.KeyPress += Validacoes.TeclaNumero;
                    txtPesquisa.Enabled = true;
                    break;
                case "RG":
                    txtPesquisa.Mask = "00,000,000-A";
                    txtPesquisa.Enabled = true;
                    break;
                case "Sexo":
                    txtPesquisa.Mask = "A";
                    txtPesquisa.KeyPress += Validacoes.TeclaLetra;
                    txtPesquisa.Enabled = true;
                    break;
                case "Data de Nascimento":
                    txtPesquisa.Mask = "00/00/0000";
                    txtPesquisa.KeyPress += Validacoes.TeclaNumero;
                    txtPesquisa.Enabled = true;
                    break;
                case "Data de Contratação":
                    txtPesquisa.Mask = "00/00/0000";
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

        public event EventHandler EditaFunc;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                // abre o banco
                objcon.Open();

                string id = dataGridViewFunc.CurrentRow.Cells[0].Value.ToString();
                MySqlCommand endereco = new MySqlCommand("select id_endereco from funcionario where id_funcionario = " + id, objcon);
                int idEnd = Convert.ToInt32(endereco.ExecuteScalar());

                MySqlCommand objcmd1 = new MySqlCommand("select logradouro from endereco where id_endereco = " + idEnd, objcon);
                MySqlCommand objcmd2 = new MySqlCommand("select bairro from endereco where id_endereco = " + idEnd, objcon);
                MySqlCommand objcmd3 = new MySqlCommand("select cidade from endereco where id_endereco = " + idEnd, objcon);
                MySqlCommand objcmd4 = new MySqlCommand("select cep from endereco where id_endereco = " + idEnd, objcon);
                MySqlCommand objcmd5 = new MySqlCommand("select numero from endereco where id_endereco = " + idEnd, objcon);
                MySqlCommand objcmd6 = new MySqlCommand("select uf from endereco where id_endereco = " + idEnd, objcon);
                MySqlCommand objcmd7 = new MySqlCommand("select nome from cargos where id_funcionario = " + id + " ORDER BY inicio_data DESC LIMIT 1", objcon);
                MySqlCommand objcmd8 = new MySqlCommand("select valor_salario from salarios where id_funcionario = " + id + " ORDER BY inicio_data DESC LIMIT 1", objcon);
                MySqlCommand objcmd9 = new MySqlCommand("select senha from funcionario where id_funcionario = " + id, objcon);

                CadastraFuncionario frm = new CadastraFuncionario();

                frm.lbId.Text = id;
                frm.txtNome.Text = dataGridViewFunc.CurrentRow.Cells[1].Value.ToString();
                frm.txtTelefone.Text = dataGridViewFunc.CurrentRow.Cells[2].Value.ToString();
                frm.txtEmail.Text = dataGridViewFunc.CurrentRow.Cells[3].Value.ToString();
                frm.txtRG.Text = dataGridViewFunc.CurrentRow.Cells[4].Value.ToString();
                frm.txtCPF.Text = dataGridViewFunc.CurrentRow.Cells[5].Value.ToString();
                frm.txtDataCont.Text = dataGridViewFunc.CurrentRow.Cells[6].Value.ToString();
                frm.txtDataNasc.Text = dataGridViewFunc.CurrentRow.Cells[7].Value.ToString();
                frm.txtRua.Text = objcmd1.ExecuteScalar().ToString();
                frm.txtBairro.Text = objcmd2.ExecuteScalar().ToString();
                frm.txtCidade.Text = objcmd3.ExecuteScalar().ToString();
                frm.txtCep.Text = objcmd4.ExecuteScalar().ToString();
                frm.txtNum.Text = objcmd5.ExecuteScalar().ToString();
                frm.txtEstado.SelectedItem = objcmd6.ExecuteScalar().ToString();
                frm.txtCargo.Text = objcmd7.ExecuteScalar().ToString();
                frm.txtSalario.Text = objcmd8.ExecuteScalar().ToString();

                if (dataGridViewFunc.CurrentRow.Cells[8].Value.ToString() == "M")
                {
                    frm.btnMasc.Checked = true;
                }
                else
                {
                    frm.btnFem.Checked = true;
                }

                objcon.Close();

                frm.txtCargo.Enabled = false;
                frm.txtSalario.Enabled = false;
                frm.BackColor = Color.FromArgb(240, 240, 240);
                frm.AutoScroll = true;
                frm.Left = 256;
                frm.Height = 500;
                frm.lbTitulo.Text = "Edita Funcionário";
                frm.btnCancelar.Visible = true;

                EventHandler handler = EditaFunc;
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
