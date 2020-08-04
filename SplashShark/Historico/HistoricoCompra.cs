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

namespace SplashShark.Historico
{
    public partial class HistoricoCompra : UserControl
    {
        public HistoricoCompra()
        {
            InitializeComponent();
        }

        public void Recarrega()
        {
            try
            {
                OrdemCompra comp = new OrdemCompra();
                comp.Listar(dataGridViewComp);
            }
            catch (Exception errosel)
            {
                MessageBox.Show("Erro ao Buscar: " + errosel);
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string col = "";
            string valor = txtPesquisa.Text;
            bool like = false;

            switch (selecCampo.SelectedItem.ToString())
            {
                case "Número":
                    col = "Numero";
                    break;
                case "Nome":
                    col = "nome";
                    like = true;
                    break;
                case "Todos":
                    Recarrega();
                    break;
            }
            if (selecCampo.SelectedItem.ToString() != "Todos" && txtPesquisa.Text != "")
            {
                OrdemCompra comp = new OrdemCompra();
                comp.Buscar(dataGridViewComp, col, valor, like);
            }
        }

        int id = 0;

        private void dataGridViewItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridViewComp.CurrentRow.Cells[0].Value.ToString());

            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("SELECT produto, quantidade, `preco un.` FROM ItensCompra WHERE numero = " + id, objCon);
            MySqlCommand cmd1 = new MySqlCommand("select DATE_FORMAT(previsao,'%d/%m/%Y') from compra where numero_compra = " + id, objCon);
            MySqlCommand cmd2 = new MySqlCommand("select atendida from compra where numero_compra = " + id, objCon);
            string data = cmd1.ExecuteScalar().ToString();
            bool entregue = Convert.ToBoolean(cmd2.ExecuteScalar());
            conexaoAdapter.Fill(conexaoDataset, "ItensCompra");
            dataGridViewItens.DataSource = conexaoDataset;
            dataGridViewItens.DataMember = "ItensCompra";
            objCon.Close();

            float preco = 0;
            for (int i = 0; i < dataGridViewItens.Rows.Count; i++)
            {
                string valor = dataGridViewItens.Rows[i].Cells[2].Value.ToString();
                valor = valor.Replace('.', ',');
                int quantidade = int.Parse(dataGridViewItens.Rows[i].Cells[1].Value.ToString());
                preco += float.Parse(valor) * quantidade;
            }
            lbTotal.Text = "R$ " + preco.ToString("F");
            lbData.Text = data;
            if (entregue)
            {
                lbEntregue.Text = "Entregue";
                btnAtualizar.Enabled = false;
            }
            else
            {
                lbEntregue.Text = "À Caminho";
                btnAtualizar.Enabled = true;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            btnAtualizar.Visible = false;
            lbPrev.Text = lbData.Text;
            lbSts.Text = lbEntregue.Text;
            id = int.Parse(dataGridViewComp.CurrentRow.Cells[0].Value.ToString());
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("SELECT produto, quantidade, `preco un.` FROM ItensCompra WHERE numero = " + id, objCon);
            conexaoAdapter.Fill(conexaoDataset, "ItensCompra");
            dataGridViewItens2.DataSource = conexaoDataset;
            dataGridViewItens2.DataMember = "ItensCompra";
            objCon.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            btnAtualizar.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(("Tem certeza que deseja realizar as alterações?"), "Atualizar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                OrdemCompra compra = new OrdemCompra();
                compra.Atendida = radioButton1.Checked;
                compra.Atualizar(id);
            }
            panel4.Visible = true;
            btnAtualizar.Visible = true;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
