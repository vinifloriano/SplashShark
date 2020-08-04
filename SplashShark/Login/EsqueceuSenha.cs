using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashShark
{
    public partial class EsqueceuSenha : Form
    {
        public EsqueceuSenha()
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
        int etapa = 0, cod;

        private void btnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://splashshark.epizy.com");
        }

        private void txtConfSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void MudaComEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtConfSenha.Focus();
                e.Handled = true;
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

        private void btnDesliga_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.ValidaEmail(txtEmail.Text) && txtEmail.Text != "")
            {
                MessageBox.Show("Email inválido.");
                txtEmail.Clear();
                txtEmail.Focus();
            }
        }

        private void txtConfSenha_Leave(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text != txtConfSenha.Text && txtConfSenha.Text != "")
            {
                erroConfSenha.Visible = true;
            }
            else
            {
                erroConfSenha.Visible = false;
            }
        }

        private void MandaEmail()
        {
            Random rnd = new Random();
            cod = rnd.Next(0, 999999);
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("splashshark.drive@gmail.com", "splashshark123");
            MailMessage mail = new MailMessage();
            mail.Sender = new System.Net.Mail.MailAddress("splashshark.drive@gmail.com", "Splash Shark");
            mail.From = new MailAddress("splashshark.drive@gmail.com", "SplashShark");
            mail.To.Add(new MailAddress(txtEmail.Text, "Usuário"));
            mail.Subject = "Código de verificação";
            mail.Body = "Email de reformulação de senha. Seu código é:<br><h1>" + cod.ToString() + "</h1>";
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            try
            {
                client.Send(mail);
                etapa++;
            }
            catch (Exception ex)
            {
                //trata erro
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                mail = null;

            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(etapa == 0)
            {
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Insira seu email.");
                }
                else
                {

                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark");
                    // abre o banco
                    objcon.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) from login where email_recuperacao ='" + txtEmail.Text+ "'", objcon);
                    int cod = int.Parse(cmd.ExecuteScalar().ToString());

                    objcon.Close();
                    if (cod != 1)
                    {
                        MessageBox.Show("Esse email não está cadastrado.");
                    }
                    else {
                        using (Carregando frm = new Carregando(MandaEmail))
                        {
                            frm.ShowDialog(this);
                        }
                        panel1.Visible = true;
                    }
                }
            }
            else if(etapa == 1)
            {
                if(txtCodVer.Text == cod.ToString())
                {
                    etapa++;
                    panel1.Visible = false;
                    panel2.Visible = true;
                    panel2.BringToFront();
                } 
                else
                {
                    MessageBox.Show("Código errado. Tente novamente.");
                    txtCodVer.Text = "";
                }
            }
            else if(etapa == 2)
            {
                if (lbForcaSenha.Text != "Segura" && lbForcaSenha.Text != "Forte")
                {
                    MessageBox.Show("A senha precisa ser Forte ou Segura para se o cadastro.");
                }
                else if (txtNovaSenha.Text == "")
                {
                    MessageBox.Show("Preencha com sua nova senha");
                }
                else
                {
                    try
                    {
                        // passa a string de conexao
                        MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;");
                        // abre o banco
                        objcon.Open();
                        // comando para inserir na tabela
                        MySqlCommand objcmd = new MySqlCommand("UPDATE login SET senha = ? WHERE email_recuperacao = ?", objcon);
                        //parametros
                        objcmd.Parameters.Add("@senha", MySqlDbType.VarChar, 70).Value = Validacoes.HashValue(txtNovaSenha.Text);
                        objcmd.Parameters.Add("@email_recuperacao", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
                        //comando para executar a query
                        objcmd.ExecuteNonQuery();
                        // fecha a conexao
                        objcon.Close();
                        MessageBox.Show("Senha alterada com sucesso!");
                        this.Close();
                    }
                    catch
                    {

                    }
                }

            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (lbForcaSenha.Text != "Segura" && lbForcaSenha.Text != "Forte" && txtNovaSenha.Text != "")
            {
                erroSenha.Visible = true;
            }
            else
            {
                erroSenha.Visible = false;
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            string a = Validacoes.ValidaSenha(txtNovaSenha.Text);
            lbForcaSenha.Text = a;
        }
    }
}
