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
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
            try
            {
                string[] linhas = System.IO.File.ReadAllLines("backups/conf.bkp");
                for (int i = 0; i < linhas.Length; i++)
                {
                    txtBackups.Items.Add(linhas[i]);
                }
                txtBackups.SelectedIndex = linhas.Length - 1;
            }
            catch
            {
                System.IO.Directory.CreateDirectory(Directory.GetCurrentDirectory()+"backups");
                System.IO.File.Create("backups/conf.bkp");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FazerBackup()
        {
            string data = DateTime.Now.ToString("dd_MM_yyy-HH_mm_ss");
            string lines = System.IO.File.ReadAllText("backups/conf.bkp") + "\n" + data;
            
            string arquivo = "backups/backup-" + data + ".sql";
            // Faz o backup
            //try
            //{
                System.IO.File.WriteAllText("backups/conf.bkp", lines);
                MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(arquivo);
                        conn.Close();
                    }
                }
                conn.Close();
            //}
            //catch{ MessageBox.Show("Impossível Fazer Backup");}
        }

        Carregando frm;
        private void btnBackup_Click(object sender, EventArgs e)
        {
            using (frm = new Carregando(this.FazerBackup))
            {
                frm.ShowDialog(this);
            }
            txtBackups.Items.Clear();
            string[] linhas = System.IO.File.ReadAllLines("backups/conf.bkp");
            for (int i = 0; i < linhas.Length; i++)
            {
                txtBackups.Items.Add(linhas[i]);
            }
            txtBackups.SelectedIndex = linhas.Length - 1;
        }


        private void btnRestaurar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(("Tem certeza que deseja restaurar backup? Se os dados atuais não foram salvos você irá perde-los."), "Restaurar para último backup", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (frm = new Carregando(Carregando.Restaurar))
                {
                    Carregando.versao = txtBackups.Text;
                    frm.ShowDialog(this);
                }
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
    }
}
