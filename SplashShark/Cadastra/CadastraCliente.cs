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
    public partial class CadastraCliente : UserControl
    {
        public CadastraCliente()
        {
            InitializeComponent();
            txtNome.KeyPress += Validacoes.TeclaLetra;
            txtBairro.KeyPress += Validacoes.TeclaLetra;
            txtCidade.KeyPress += Validacoes.TeclaLetra;
            txtRua.KeyPress += Validacoes.TeclaLetra;
            txtNum.KeyPress += Validacoes.TeclaNumero;
            txtRG.KeyPress += Validacoes.TeclaNumero;
            txtCPF.KeyPress += Validacoes.TeclaNumero;
            txtCNPJ.KeyPress += Validacoes.TeclaNumero;
            txtInscEstadual.KeyPress += Validacoes.TeclaNumero;
            txtTelefone.KeyPress += Validacoes.TeclaNumero;
            txtCep.KeyPress += Validacoes.TeclaNumero;
        }

        private void MudaComEnter(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
            try
            {
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

        public void btnEnviar_Click(object sender, EventArgs e)
        {
            PictureBox[] pbs = { erroEmail, erroCPF, erroRG, erroCNPJ, erroInscEstadual };
            Validacoes.ValidaErro(pbs);
            if (erroEmail.Visible == true)
                txtEmail.Focus();
            else if (erroCPF.Visible == true)
                txtCPF.Focus();
            else if (erroRG.Visible == true)
                txtRG.Focus();
            else if (erroCNPJ.Visible == true)
                txtCNPJ.Focus();
            else if (erroInscEstadual.Visible == true)
                txtInscEstadual.Focus();
            else if (btnPFisica.Checked && (txtRG.Text.Contains(' ') || txtCPF.Text.Contains(' ') || txtEmail.Text == "" || txtNome.Text == "" || txtTelefone.Text.Contains(' ') || txtRua.Text == "" || txtBairro.Text == "" || txtCep.Text.Contains(' ') || txtCidade.Text == "" || txtNum.Text == "" || txtEstado.SelectedItem.ToString() == ""))
                MessageBox.Show("Preencha todos os campos!");
            else if (btnPJuridica.Checked && (txtNome.Text == "" || txtCNPJ.Text.Contains(' ') || txtRazaoSocial.Text == "" || txtInscEstadual.Text.Contains(' ') || txtTelefone.Text.Contains(' ') || txtRua.Text == "" || txtBairro.Text == "" || txtCep.Text.Contains(' ') || txtCidade.Text == "" || txtNum.Text == "" || txtEstado.SelectedItem.ToString() == ""))
                MessageBox.Show("Preencha todos os campos!");
            else
            {
                Cliente cli = new Cliente();
                PessoaFisica pf = new PessoaFisica();
                PessoaJuridica pj = new PessoaJuridica();
                try
                {
                    cli.Nome = txtNome.Text;
                    cli.Email = txtEmail.Text;
                    cli.Telefone = txtTelefone.Text;
                    cli.Logradouro = txtRua.Text;
                    cli.Bairro = txtBairro.Text;
                    cli.Uf = txtEstado.SelectedItem.ToString();
                    cli.Cidade = txtCidade.Text;
                    cli.Cep = txtCep.Text;
                    cli.Numero = txtNum.Text;
                    cli.Complemento = txtComplemento.Text;
                    cli.Criar();
                    if (btnPFisica.Checked)
                    {
                        pf.Nome = txtNome.Text;
                        pf.Cpf = txtCPF.Text;
                        pf.CarteiraIdentidade = txtRG.Text;
                        pf.CriarPF();
                    }
                    else
                    {
                        pj.RazaoSocial = txtRazaoSocial.Text;
                        pj.Cnpj = txtCNPJ.Text;
                        pj.InscricaoEstadual = txtInscEstadual.Text;
                        pj.CriarPJ();
                    }

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
                    txtRazaoSocial.Text = "";
                    txtCNPJ.Text = "";
                    txtInscEstadual.Text = "";
                    txtComplemento.Text = "";


                }
                catch
                {
                    MessageBox.Show("Erro ao inserir.");
                }
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if(txtCep.Text.Contains(' ')){}
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
            if(!Validacoes.ValidaEmail(txtEmail.Text) && txtEmail.Text != "")
            {
                erroEmail.Visible = true;
            }
            else
            {
                erroEmail.Visible = false;
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

        private void btnPFisica_CheckedChanged(object sender, EventArgs e)
        {
            if(btnPFisica.Checked)
            {
                if(txtCPF.Text != "   .   .   -")
                    erroCPF.Visible = !Validacoes.ValidaCPF(txtCPF.Text, "pessoafisica");
                if(txtRG.Text != "  .   .   -")
                    erroRG.Visible = !Validacoes.ValidaRG(txtRG.Text, "pessoafisica");
                erroCNPJ.Visible = false;
                lbCNPJ.Visible = false;
                lbInscricaoEstadual.Visible = false;
                lbRazaoSocial.Visible = false;
                txtCNPJ.Visible = false;
                txtInscEstadual.Visible = false;
                txtRazaoSocial.Visible = false;
                txtRG.Visible = true;
                txtRazaoSocial.TabIndex = 100;
                txtCNPJ.TabIndex = 101;
                txtInscEstadual.TabIndex = 102;
                txtRG.TabIndex = 6;
                txtCPF.TabIndex = 5;
            }
            else
            {
                erroCPF.Visible = false;
                erroRG.Visible = false;
                if(txtCNPJ.Text != "  .   .   /    -")
                    erroCNPJ.Visible = !Validacoes.ValidaCNPJ(txtCNPJ.Text, "pessoajuridica");
                lbCNPJ.Visible = true;
                lbInscricaoEstadual.Visible = true;
                lbRazaoSocial.Visible = true;
                txtCNPJ.Visible = true;
                txtInscEstadual.Visible = true;
                txtRazaoSocial.Visible = true;
                txtRG.Visible = false;
                txtRazaoSocial.TabIndex = 5;
                txtCNPJ.TabIndex = 6;
                txtInscEstadual.TabIndex = 7;
                txtRG.TabIndex = 100;
                txtCPF.TabIndex = 101;
            }
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.ValidaCNPJ(txtCNPJ.Text, "pessoajuridica") && txtCNPJ.Text != "  .   .   /    -")
            {
                erroCNPJ.Visible = true;
            }
            else
            {
                erroCNPJ.Visible = false;
            }
        }

        private void EnviaComEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnEnviar.PerformClick();
                e.Handled = true;
            }
        }
    }
}
