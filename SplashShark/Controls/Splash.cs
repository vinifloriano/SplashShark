using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashShark
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 2;
            if (progressBar1.Value == 20)
            {
                label1.Text = "Conectando com o banco...";
                try
                {
                    // Conecta com o banco
                    MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                }
                catch
                {
                    MessageBox.Show("Impossível Conectar com o Banco");
                    Application.Exit();
                }
                progressBar1.Value += 15;
            }
            else if (progressBar1.Value == 50)
            {
                label1.Text = "Enchendo linguiça...";
                progressBar1.Value += 20;
            }
            else if (progressBar1.Value == 85)
            {
                label1.Text = "Finalizando...";
                progressBar1.Value += 5;
            }
            else if (progressBar1.Value >= 96)
            {
                timer1.Enabled = false;

                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                // abre o banco
                objcon.Open();
                MySqlCommand Query2 = new MySqlCommand();
                Query2.Connection = objcon;
                Query2.CommandText = @"SELECT id_login FROM login where is_dono = 1";
                MySqlDataReader dtreader2 = Query2.ExecuteReader();
                if (dtreader2.Read())
                {
                    TelaLogin frm = new TelaLogin();
                    frm.Show();
                }
                else
                {
                    TelaCadastro frm = new TelaCadastro();
                    frm.Show();
                }
                dtreader2.Close();

                this.Hide();
            }
        }
    }
}
