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
    public partial class HistoricoPedido : UserControl
    {
        public HistoricoPedido()
        {
            InitializeComponent();
            selecCampo.SelectedItem = "Todos";
        }

        public void Recarrega()
        {
            try
            {
                ClientePedido prod = new ClientePedido();
                prod.Listar(dataGridViewPed);
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
                ClientePedido ped = new ClientePedido();
                ped.Buscar(dataGridViewPed, col, valor, like);
            }
        }

        private void dataGridViewProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridViewPed.CurrentRow.Cells[0].Value.ToString());

            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("SELECT produto, quantidade, preco FROM ItensPedido WHERE numero = " + id, objCon);
            conexaoAdapter.Fill(conexaoDataset, "ItensPedido");
            dataGridViewItens.DataSource = conexaoDataset;
            dataGridViewItens.DataMember = "ItensPedido";
            objCon.Close();

            float preco = 0;
            for (int i = 0; i < dataGridViewItens.Rows.Count; i++)
            {
                string valor = dataGridViewItens.Rows[i].Cells[2].Value.ToString().Replace('.', ',');
                preco += float.Parse(valor);
            }
            lbTotal.Text = "R$ " + preco.ToString("F");
        }

        private void btnReembolso_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark");
                objCon.Open();
                int id = int.Parse(dataGridViewPed.CurrentRow.Cells[0].Value.ToString());

            //    for (int i = 0; i < dataGridViewItens.Rows.Count; i++)
             //   {
             //       MySqlCommand objcmd2 = new MySqlCommand("select codigo_produto from produto where nome ='" + dataGridViewItens.Rows[i].Cells[0].Value.ToString()+"'", objCon);
             //       string id_prod = objcmd2.ExecuteScalar().ToString();
             //       MySqlCommand objcmd3 = new MySqlCommand("select quantidade from estoque where codigo_produto =" + id_prod, objCon);
             //       int quantidade = int.Parse(dataGridViewItens.Rows[i].Cells[1].Value.ToString());
             //       int total = quantidade + int.Parse(objcmd3.ExecuteScalar().ToString());
             //       MySqlCommand cmd2 = new MySqlCommand("update estoque set quantidade = "+total+" where codigo_produto =" + id_prod, objCon);
             //       cmd2.ExecuteNonQuery();
             //   }

                MySqlCommand objcmd = new MySqlCommand("delete from itemPedido where numero_pedido = " + id, objCon);
                MySqlCommand cmd = new MySqlCommand("delete from pedido where numero_pedido =" + id, objCon);
                objcmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                objCon.Close();
                MessageBox.Show("Reembolso concluido com sucesso!");
                Recarrega();
            }
            catch
            {

            }
        }
    }
}
