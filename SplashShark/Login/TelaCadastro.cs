using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashShark
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
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

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://splashshark.epizy.com");
        }

        private void txtConfSenha_Leave(object sender, EventArgs e)
        {
            if(txtSenha.Text != txtConfSenha.Text && txtConfSenha.Text != "")
            {
                erroConfSenha.Visible = true;
            }
            else
            {
                erroConfSenha.Visible = false;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length < 5 && txtUsuario.Text != "")
            {
                erroUsu.Visible = true;
            }
            else
            {
                erroUsu.Visible = false;
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

        private void txtSenha_Leave(object sender, EventArgs e)
        {
           if (lbForcaSenha.Text != "Segura" && lbForcaSenha.Text != "Forte" && txtSenha.Text != "")
           {
               erroSenha.Visible = true;
           }
           else {
                erroSenha.Visible = false;
           }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            string a = Validacoes.ValidaSenha(txtSenha.Text);
            lbForcaSenha.Text = a;
        }

        private void MudaComEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
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

        private void EnviaComEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnEnviar.PerformClick();
                e.Handled = true;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            PictureBox[] pbs = { erroUsu, erroEmail , erroSenha, erroConfSenha };
            Validacoes.ValidaErro(pbs);
            if(erroUsu.Visible == true)
                txtUsuario.Focus();
            else if (erroEmail.Visible == true)
                txtEmail.Focus();
            else if (erroSenha.Visible == true)
                txtSenha.Focus();
            else if (erroConfSenha.Visible == true)
                txtConfSenha.Focus();
            else if (txtEmail.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            else
            {
                try
                {

                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
                    // abre o banco
                    objcon.Open();
                    MySqlCommand objcmd = new MySqlCommand("insert into login (email_recuperacao, is_dono, is_gerente, is_funcionario, usuario, senha) values (?,?,?,?,?,?)", objcon);

                    //parametros
                    objcmd.Parameters.Add("@email_recuperacao", MySqlDbType.VarChar, 50).Value = txtEmail.Text;
                    objcmd.Parameters.Add("@is_dono", MySqlDbType.Bit, 1).Value = 1;
                    objcmd.Parameters.Add("@is_gerente", MySqlDbType.Bit, 1).Value = 0;
                    objcmd.Parameters.Add("@is_funcionario", MySqlDbType.Bit, 1).Value = 0;
                    objcmd.Parameters.Add("@usuario", MySqlDbType.VarChar, 50).Value = txtUsuario.Text;
                    objcmd.Parameters.Add("@senha", MySqlDbType.VarChar, 50).Value = Validacoes.HashValue(txtSenha.Text);


                    //comando para executar a query
                    objcmd.ExecuteNonQuery();
                    MessageBox.Show("Administrador cadastrado com sucesso!");
                    objcon.Close();
                    TelaLogin tlogin = new TelaLogin();
                    tlogin.Show();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Erro ao cadastrar, para saber mais acesse nosso site de ajuda!");
                }
            }
        }
    }
}
