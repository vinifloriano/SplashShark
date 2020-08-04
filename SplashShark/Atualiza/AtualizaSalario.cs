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
    public partial class AtualizaSalario : UserControl
    {
        public AtualizaSalario()
        {
            InitializeComponent();
            txtSalario.KeyPress += Validacoes.TeclaDinheiro;
        }

        public void recarrega()
        {
            txtNome.Items.Clear();
            txtID.Items.Clear();

            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();


            string mSQL = "select nome, id_funcionario from funcionario";
            MySqlCommand cmd = new MySqlCommand(mSQL, objcon);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dtMensagens = new DataTable();
            da.Fill(dtMensagens);
            foreach (DataRow data in dtMensagens.Rows)
            {
                txtNome.Items.Add(data[0].ToString());
                txtID.Items.Add(data[1].ToString());
            }

            objcon.Close();


        }

        private void EnviaComEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnEnviar.PerformClick();
                e.Handled = true;
            }
        }
        string salario, ultima_atualizacao;
        private void recarregaUltimaAtualizacao()
        {
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");

            objcon.Open();

            MySqlCommand cmd_cargo = new MySqlCommand("select valor_salario from salarios where id_funcionario =" + txtID.Text + " and fim_data = '9999-01-01' LIMIT 1", objcon);
            salario = cmd_cargo.ExecuteScalar().ToString();

            MySqlCommand cmd_ultima_atualizacao = new MySqlCommand("select inicio_data from salarios where id_funcionario =" + txtID.Text + " and fim_data = '9999-01-01' LIMIT 1", objcon);
            ultima_atualizacao = cmd_ultima_atualizacao.ExecuteScalar().ToString();

            txtUltimoSalario.Text = salario;
            txtUltimaAtualizacao.Text = ultima_atualizacao;
            objcon.Close();
        }

        private void txtNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.SelectedIndex = txtNome.SelectedIndex;
            recarregaUltimaAtualizacao();
        }

        private void txtID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNome.SelectedIndex = txtID.SelectedIndex;
            recarregaUltimaAtualizacao();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtUltimoSalario.Text) < int.Parse(txtSalario.Text))
            {
                MessageBox.Show("O salário não pode ser menor que o anterior.");
            }
            else
            {
                try
                {
                    if (txtNome.Text == "" || txtID.Text == "" || txtSalario.Text == "")
                    {
                        MessageBox.Show("Preencha todos os campos!");
                    }
                    else
                    {
                        SalarioFuncionario salfun = new SalarioFuncionario();
                        salfun.Salario = double.Parse(txtSalario.Text);
                        salfun.Criar(int.Parse(txtID.Text));
                        txtID.Text = "";
                        txtNome.Text = "";
                        txtSalario.Text = "";
                        txtUltimaAtualizacao.Text = "";
                        txtUltimoSalario.Text = "";
                        MessageBox.Show("Dados Inseridos com sucesso");
                        recarregaUltimaAtualizacao();
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao inserir.");
                }
            }
        }

    }
}
