using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashShark
{
    public partial class Carregando : Form
    { 

        public Action Worker { get; set; }

        public Carregando(Action worker)
        {
            InitializeComponent();
            Worker = worker ?? throw new ArgumentNullException();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
        
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    i++;
                    lbTitulo.Text = "Carregando";
                    break;
                case 1:
                    i++;
                    lbTitulo.Text = "Carregando.";
                    break;
                case 2:
                    i++;
                    lbTitulo.Text = "Carregando..";
                    break;
                case 3:
                    i=0;
                    lbTitulo.Text = "Carregando...";
                    break;
            }
        }

        int arrastaX, arrastaY;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = arrastaX + MousePosition.X;
            this.Top = arrastaY + MousePosition.Y;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            arrastaX = this.Left - MousePosition.X;
            arrastaY = this.Top - MousePosition.Y;
        }

        public static string versao;
        public static void Restaurar()
        {
            // Carrega arquivo de backup
            if (versao == "")
            {
                MessageBox.Show("Você precisa fazer um backup para restaura-lo.");
            }
            else
            {
                //try
                //{
                    MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                    string script = File.ReadAllText("backups/backup-" + versao + ".sql");
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = script;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                //}
                //catch { MessageBox.Show("Impossível restaurar o backup!"); }
            }
        }

    }
}
