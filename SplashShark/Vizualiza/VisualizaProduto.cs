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
    public partial class VisualizaProduto : UserControl
    {
        public VisualizaProduto()
        {
            InitializeComponent();
            selecCampo.SelectedItem = "Todos";
            btnRemover2.Click += btnRemover_Click;
            btnEditar2.Click += btnEditar_Click;
        }

        public void recarrega()
        {
            try
            {
                Produto prod = new Produto();
                prod.Mostrar(dataGridViewProd);
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
                    col = "codigo_produto";
                    break;
                case "Nome":
                    col = "nome";
                    like = true;
                    break;
                case "Descrição":
                    col = "descricao";
                    like = true;
                    break;
                case "Modelo":
                    col = "modelo";
                    like = true;
                    break;
                case "Cor":
                    col = "cor";
                    like = true;
                    break;
                case "Marca":
                    col = "marcaImpressora";
                    like = true;
                    break;
                case "Preço":
                    col = "preco";
                    break;
                case "Todos":
                    recarrega();
                    break;
            }
            if (selecCampo.SelectedItem.ToString() != "Todos" && txtPesquisa.Text != "")
            {
                Produto prod = new Produto();

                prod.Buscar(dataGridViewProd, col, valor, like);
                //else
                //pj.BuscarPJ(dataGridViewPJ, col, valor, like);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objcon.Open();
            MySqlCommand objcmd = new MySqlCommand("select COUNT(*) from itemcompra where codigo_produto = " + dataGridViewProd.CurrentRow.Cells[0].Value.ToString(), objcon);
            MySqlCommand objcmd1 = new MySqlCommand("select COUNT(*) from itempedido where codigo_produto = " + dataGridViewProd.CurrentRow.Cells[0].Value.ToString(), objcon);
            if (objcmd.ExecuteScalar().ToString() != "0" || objcmd1.ExecuteScalar().ToString() != "0")
            {
                MessageBox.Show("Impossível remover este produto, ele já possui um histórico nessa loja.");
            }
            else
            {
                if (MessageBox.Show(("Tem certeza que deseja remover o Produto?"), "Produtos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Produto prod = new Produto();
                    try
                    {
                        string id = dataGridViewProd.CurrentRow.Cells[0].Value.ToString();
                        prod.Excluir(id);
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
                case "Marca":
                case "Descrição":
                case "Cor":
                    txtPesquisa.KeyPress += Validacoes.TeclaLetra;
                    txtPesquisa.Enabled = true;
                    break;
                case "Modelo":
                    txtPesquisa.Enabled = true;
                    break;
                case "Preço":
                    txtPesquisa.Enabled = true;
                    break;
                case "Todos":
                    txtPesquisa.Clear();
                    txtPesquisa.Enabled = false;
                    break;
            }
        }

        public event EventHandler EditaProd;

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                // abre o banco
                objcon.Open();
                string id = dataGridViewProd.CurrentRow.Cells[0].Value.ToString();

                CadastraProduto frm = new CadastraProduto();

                frm.lbId.Text = id;
                frm.txtNome.Text = dataGridViewProd.CurrentRow.Cells[1].Value.ToString();
                frm.txtModelo.Text = dataGridViewProd.CurrentRow.Cells[3].Value.ToString();
                frm.txtMarca.Text = dataGridViewProd.CurrentRow.Cells[4].Value.ToString();
                frm.txtCor.Text = dataGridViewProd.CurrentRow.Cells[5].Value.ToString();
                frm.txtQuantidade.Text = dataGridViewProd.CurrentRow.Cells[8].Value.ToString();
                frm.txtPreco.Text = dataGridViewProd.CurrentRow.Cells[7].Value.ToString();
                frm.txtDescricao.Text = dataGridViewProd.CurrentRow.Cells[2].Value.ToString();

            objcon.Close();
                
                frm.BackColor = Color.FromArgb(240, 240, 240);
                frm.AutoScroll = true;
                frm.Left = 256;
                frm.Height = 500;
                frm.lbTitulo.Text = "Edita Produto";
                frm.btnCancelar.Visible = true;
                frm.txtQuantidade.Enabled = false;
                
                EventHandler handler = EditaProd;
                handler?.Invoke(frm, e);


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
    }
}
