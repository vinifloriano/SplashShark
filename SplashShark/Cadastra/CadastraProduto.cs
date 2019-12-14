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
    public partial class CadastraProduto : UserControl
    {
        public CadastraProduto()
        {
            InitializeComponent();
            txtNome.KeyPress += Validacoes.TeclaLetra;
            txtCor.KeyPress += Validacoes.TeclaLetra;
            txtDescricao.KeyPress += Validacoes.TeclaLetra;
            txtQuantidade.KeyPress += Validacoes.TeclaNumero;
            txtPreco.KeyPress += Validacoes.TeclaDinheiro;
            txtModelo.KeyPress += Validacoes.TeclaModelo;
            txtMarca.KeyPress += Validacoes.TeclaModelo;
        }

        private void MudaComEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        public void btnEnviar_Click(object sender, EventArgs e)
        {
            Produto prod = new Produto();
            try
            {
                if (txtNome.Text == "" || txtDescricao.Text == "" || txtModelo.Text == "" || txtMarca.Text == "" || txtQuantidade.Text == "" || txtPreco.Text == "" || txtCor.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    string data = DateTime.Now.ToShortDateString();
                    string[] hojeAntes = data.Split('/');
                    string hoje = hojeAntes[2] + '-' + hojeAntes[1] + '-' + hojeAntes[0];
                    prod.Nome = txtNome.Text;
                    prod.Descricao = txtDescricao.Text;
                    prod.Modelo = txtModelo.Text;
                    prod.MarcaImpressora = txtMarca.Text;
                    prod.UltimaAtualizacao = hoje;
                    prod.Cor = txtCor.Text;
                    prod.Saldo = txtQuantidade.Text;
                    prod.Preco = txtPreco.Text;
                    prod.Criar();
                }
                txtNome.Text = "";
                txtDescricao.Text = "";
                txtModelo.Text = "";
                txtMarca.Text = "";
                txtCor.Text = "";
                txtQuantidade.Text = "";
                txtPreco.Text = "";
            }
            catch
            {
                MessageBox.Show("Erro ao inserir.");
            }
        }
    }
}
