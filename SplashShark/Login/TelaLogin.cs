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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }
        int arrastaX, arrastaY;
        private void splitContainer1_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            arrastaX = this.Left - MousePosition.X;
            arrastaY = this.Top - MousePosition.Y;
        }

        private void splitContainer1_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = arrastaX + MousePosition.X;
            this.Top = arrastaY + MousePosition.Y;
        }

        private void btnDesliga_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(("Tem certeza que deseja sair?"), "Sair do Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT is_dono from login where usuario ='"+txtUsuario.Text+"' AND senha='"+Validacoes.HashValue(txtSenha.Text)+"'", objcon);
            MySqlCommand cmd1 = new MySqlCommand("SELECT is_gerente from login where usuario ='" + txtUsuario.Text + "' AND senha='" + Validacoes.HashValue(txtSenha.Text) + "'", objcon);
            MySqlCommand cmd2 = new MySqlCommand("SELECT is_funcionario from login where usuario ='" + txtUsuario.Text + "' AND senha='" + Validacoes.HashValue(txtSenha.Text) + "'", objcon);

            if (cmd.ExecuteScalar() != null)
            {
                if (int.Parse(cmd.ExecuteScalar().ToString()) == 1)
                {
                    MainForm frm = new MainForm();
                    frm.Show();
                    this.Close();
                }
                else if(int.Parse(cmd1.ExecuteScalar().ToString()) == 1) {
                    MainForm frm = new MainForm();
                    frm.menu1.btnFunCad.Enabled = false;
                    frm.menu1.btnFunEdi.Enabled = false;
                    frm.menu1.btnFunCar.Enabled = false;
                    frm.menu1.btnFunSal.Enabled = false;
                    frm.menu1.btnHistComp.Enabled = false;
                    frm.menu1.btnHistPed.Enabled = false;
                    frm.Show();
                    this.Close();
                }
                else if (int.Parse(cmd2.ExecuteScalar().ToString()) == 1) {
                    MainForm frm = new MainForm();
                    frm.menu1.btnForCad.Enabled = false;
                    frm.menu1.btnForEdi.Enabled = false;
                    frm.menu1.btnFunCad.Enabled = false;
                    frm.menu1.btnFunEdi.Enabled = false;
                    frm.menu1.btnFunCar.Enabled = false;
                    frm.menu1.btnFunSal.Enabled = false;
                    frm.menu1.btnProEdi.Enabled = false;
                    frm.menu1.btnProCad.Enabled = false;
                    frm.menu1.btnHistComp.Enabled = false;
                    frm.menu1.btnHistPed.Enabled = false;
                    frm.btnBackup.Visible = false;
                    frm.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Usuário ou senha invalida!");
                txtSenha.Clear();
            }
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://splashshark.epizy.com");
        }
        string senha = "";
        private void txtUsuario_Leave(object sender, EventArgs e)
        {

            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT senha from login where usuario ='" + txtUsuario.Text + "'", objcon);
            try
            {
                senha = cmd.ExecuteScalar().ToString();
                erroUsu.Visible = false;
            }
            catch
            {
                erroUsu.Visible = true;
            }
            objcon.Close();
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (Validacoes.HashValue(txtSenha.Text) != senha && txtSenha.Text != "")
            {
                erroSenha.Visible = true;
            }
            else
            {
                erroSenha.Visible = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueceuSenha esqSenha = new EsqueceuSenha();
            esqSenha.ShowDialog();
        }

        private void EnviaComEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnEnviar.PerformClick();
                e.Handled = true;
            }
        }

        private void MudaComEnter(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                txtSenha.Focus();
                e.Handled = true;
            }
            try
            {
                TextBox txt = sender as TextBox;
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
    }
}
