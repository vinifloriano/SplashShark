using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashShark
{
    public partial class CadastraFuncionario : UserControl
    {
        public CadastraFuncionario()
        {
            InitializeComponent();
            txtNome.KeyPress += Validacoes.TeclaLetra;
            txtBairro.KeyPress += Validacoes.TeclaLetra;
            txtCidade.KeyPress += Validacoes.TeclaLetra;
            txtRua.KeyPress += Validacoes.TeclaLetra;
            txtCargo.KeyPress += Validacoes.TeclaLetra;
            txtNum.KeyPress += Validacoes.TeclaNumero;
            txtSalario.KeyPress += Validacoes.TeclaDinheiro;
            txtRG.KeyPress += Validacoes.TeclaNumero;
            txtCPF.KeyPress += Validacoes.TeclaNumero;
            txtDataCont.KeyPress += Validacoes.TeclaNumero;
            txtDataNasc.KeyPress += Validacoes.TeclaNumero;
            txtCep.KeyPress += Validacoes.TeclaNumero;
            txtDataCont.Text = DateTime.Now.ToShortDateString();
        }

        private void MudaComEnter(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
            try
            {
                TextBox txt = sender as TextBox;
                if (e.KeyChar == (char)Keys.Space && txt.Text.EndsWith(" "))
                {
                    txt.Text = txt.Text.Trim();
                    txt.SelectionStart = txt.Text.Length;
                }
            }
            catch
            {

            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.ValidaCPF(txtCPF.Text, "pessoafisica") && txtCPF.Text != "   .   .   -")
            {
                erroCPF.Visible = true;
            }
            else
            {
                erroCPF.Visible = false;
            }
        }

        private void txtRG_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.ValidaRG(txtRG.Text, "pessoafisica") && txtRG.Text != "  .   .   -")
            {
                erroRG.Visible = true;
            }
            else
            {
                erroRG.Visible = false;
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (txtCep.Text == "     -") { }
            else if (txtCep.Text.Contains(' '))
                MessageBox.Show("Insira um CEP válido.");
            else
            {
                try
                {
                    string teste = txtCep.Text;
                    teste = teste.Trim();
                    teste.Replace("-", "");
                    DataSet ds = new DataSet();
                    string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", teste);
                    ds.ReadXml(xml);
                    txtRua.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                    txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                    txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                    txtEstado.Text = ds.Tables[0].Rows[0]["UF"].ToString();
                }
                catch
                {
                    MessageBox.Show("Não foi possível identificar seu CEP. Insira as informações manualmente.");
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.ValidaEmail(txtEmail.Text) && txtEmail.Text != "")
            {
                erroEmail.Visible = true;
            }
            else
            {
                erroEmail.Visible = false;
            }
        }

        public void btnEnviar_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();
            try
            {
                if(lbForcaSenha.Text != "Segura" && lbForcaSenha.Text != "Forte")
                {
                    MessageBox.Show("A senha precisa ser Forte ou Segura para se o cadastro.");
                }
                else if (txtDataCont.Text.Contains(' ') || txtDataNasc.Text.Contains(' ') || txtNome.Text == "" || txtTelefone.Text.Contains(' ') || txtCPF.Text.Contains(' ') || txtRG.Text.Contains(' ') || txtRua.Text == "" || txtBairro.Text == "" || txtCep.Text.Contains(' ') || txtCidade.Text == "" || txtNum.Text == "" || txtEstado.SelectedItem.ToString() == "" || txtCargo.Text == "" || txtSalario.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    bool v2 = Validacoes.ValidaData(txtDataNasc.Text);
                    bool v1 = Validacoes.ValidaData(txtDataCont.Text);
                    bool vEmail = Validacoes.ValidaEmail(txtEmail.Text);
                    if (v1 && v2 && vEmail)
                    {
                        string[] contraAntes = txtDataCont.Text.Split('/');
                        string[] nascAntes = txtDataNasc.Text.Split('/');

                        string contra = contraAntes[2] + '-' + contraAntes[1] + '-' + contraAntes[0];
                        string nasc = nascAntes[2] + '-' + nascAntes[1] + '-' + nascAntes[0];

                        func.Nome = txtNome.Text;
                        func.Email = txtEmail.Text;
                        func.Telefone = txtTelefone.Text;
                        func.Data_cont = contra;
                        func.Data_nasc = nasc;
                        func.Sexo = btnFem.Checked ? 'F' : 'M';
                        func.Cpf = txtCPF.Text;
                        func.Rg = txtRG.Text;
                        func.Logradouro = txtRua.Text;
                        func.Bairro = txtBairro.Text;
                        func.Uf = txtEstado.SelectedItem.ToString();
                        func.Cidade = txtCidade.Text;
                        func.Cep = txtCep.Text;
                        func.Numero = txtNum.Text;
                        func.Salario = double.Parse(txtSalario.Text);
                        func.Nome_cargo = txtCargo.Text;
                        func.Senha = txtSenha.Text;
                        func.Complemento = txtComplemento.Text;
                        func.Criar();

                        txtDataCont.Text = "";
                        txtDataNasc.Text = "";
                        txtNome.Text = "";
                        txtTelefone.Text = "";
                        txtEmail.Text = "";
                        txtCPF.Text = "";
                        txtCep.Text = "";
                        txtRG.Text = "";
                        txtRua.Text = "";
                        txtCidade.Text = "";
                        txtNum.Text = "";
                        txtBairro.Text = "";
                        txtCargo.Text = "";
                        txtSalario.Text = "";
                        txtComplemento.Text = "";
                        txtSenha.Text = "";
                        txtConfSenha.Text = "";
                    }
                }
            }
            catch{MessageBox.Show("Erro ao inserir.");}
        }

        private void txtConfSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtConfSenha.Text && txtConfSenha.Text != "")
            {
                erroConfSenha.Visible = true;
            }
            else
            {
                erroConfSenha.Visible = false;
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            string a = Validacoes.ValidaSenha(txtSenha.Text);
            lbForcaSenha.Text = a;
        }

        private void EnviaComEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnEnviar.PerformClick();
                e.Handled = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (lbForcaSenha.Text != "Segura" && lbForcaSenha.Text != "Forte" && txtSenha.Text != "")
            {
                erroSenha.Visible = true;
            }
            else
            {
                erroSenha.Visible = false;
            }
        }

        private void txtDataNasc_Leave(object sender, EventArgs e)
        {
            if (Validacoes.ValidaData(txtDataNasc.Text) && txtDataNasc.Text != "")
            {
                try
                {
                    DateTime dtnasc = DateTime.Parse(txtDataNasc.Text);
                    erroDataNasc.Visible = dtnasc < DateTime.Now.AddYears(-14) ? false : true;
                }
                catch
                {
                    erroDataNasc.Visible = true;
                }
            }
            else if (!Validacoes.ValidaData(txtDataNasc.Text))
            {
                erroDataNasc.Visible = true;
            }
            else
            {
                erroDataNasc.Visible = false;
            }
        }

        private void txtDataCont_Leave(object sender, EventArgs e)
        {
            if (Validacoes.ValidaData(txtDataCont.Text) && txtDataCont.Text != "")
            {
                try
                {
                    DateTime dtcont = DateTime.Parse(txtDataCont.Text);
                    erroDataCont.Visible = dtcont > DateTime.Now?true:false;
                }
                catch
                {
                    erroDataCont.Visible = true;
                }
            }
            else if (!Validacoes.ValidaData(erroDataCont.Text))
            {
                erroDataCont.Visible = true;
            }
            else
            {
                erroDataCont.Visible = false;
            }
        }
    }
}
