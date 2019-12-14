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
    public partial class CadastraFornecedor : UserControl
    {
        public CadastraFornecedor()
        {
            InitializeComponent();
            txtNome.KeyPress += Validacoes.TeclaLetra;
            txtNum.KeyPress += Validacoes.TeclaNumero;
            txtCNPJ.KeyPress += Validacoes.TeclaNumero;
            txtInscEstadual.KeyPress += Validacoes.TeclaNumero;
            txtCep.KeyPress += Validacoes.TeclaNumero;
        }

        private void MudaComEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
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

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.ValidaCNPJ(txtCNPJ.Text, "fornecedor") && txtCNPJ.Text != "  .   .   /    -")
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

        public void btnEnviar_Click(object sender, EventArgs e)
        {
            PictureBox[] pbs = { erroEmail, erroCNPJ, erroInscEstadual };
            Validacoes.ValidaErro(pbs);
            if (erroEmail.Visible == true)
                txtEmail.Focus();
            else if (erroCNPJ.Visible == true)
                txtCNPJ.Focus();
            else if (erroInscEstadual.Visible == true)
                txtInscEstadual.Focus();
            else if (txtNome.Text == "" || txtCNPJ.Text.Contains(' ') || txtPseudonimo.Text == "" || txtInscEstadual.Text.Contains(' ') || txtRua.Text == "" || txtBairro.Text == "" || txtCep.Text.Contains(' ') || txtCidade.Text == "" || txtNum.Text == "" || txtEstado.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                Fornecedor forn = new Fornecedor();
                EspecificacaoFornecedor espForn = new EspecificacaoFornecedor();
                try
                {
                    forn.Nome = txtNome.Text;
                    forn.Email = txtEmail.Text;
                    forn.Logradouro = txtRua.Text;
                    forn.Bairro = txtBairro.Text;
                    forn.Uf = txtEstado.SelectedItem.ToString();
                    forn.Cidade = txtCidade.Text;
                    forn.Cep = txtCep.Text;
                    forn.Numero = txtNum.Text;
                    forn.Cnpj = txtCNPJ.Text;
                    forn.InscricaoEstadual = txtInscEstadual.Text;
                    forn.Complemento = txtComplemento.Text;
                    forn.Criar(txtPseudonimo.Text);

                    txtNome.Text = "";
                    txtEmail.Text = "";
                    txtCep.Text = "";
                    txtRua.Text = "";
                    txtCidade.Text = "";
                    txtNum.Text = "";
                    txtBairro.Text = "";
                    txtPseudonimo.Text = "";
                    txtCNPJ.Text = "";
                    txtInscEstadual.Text = "";
                    txtComplemento.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir." + ex);
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
    }
}
