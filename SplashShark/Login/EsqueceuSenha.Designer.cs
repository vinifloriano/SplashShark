namespace SplashShark
{
    partial class EsqueceuSenha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsqueceuSenha));
            this.splitPrincipal = new System.Windows.Forms.SplitContainer();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnMinimiza = new System.Windows.Forms.Button();
            this.lbSS = new System.Windows.Forms.Label();
            this.btnDesliga = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.erroConfSenha = new System.Windows.Forms.PictureBox();
            this.erroSenha = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbForcaSenha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodVer = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitPrincipal)).BeginInit();
            this.splitPrincipal.Panel1.SuspendLayout();
            this.splitPrincipal.Panel2.SuspendLayout();
            this.splitPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroConfSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroSenha)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitPrincipal
            // 
            this.splitPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.splitPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPrincipal.IsSplitterFixed = true;
            this.splitPrincipal.Location = new System.Drawing.Point(0, 0);
            this.splitPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.splitPrincipal.Name = "splitPrincipal";
            this.splitPrincipal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPrincipal.Panel1
            // 
            this.splitPrincipal.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.splitPrincipal.Panel1.Controls.Add(this.btnAjuda);
            this.splitPrincipal.Panel1.Controls.Add(this.btnMinimiza);
            this.splitPrincipal.Panel1.Controls.Add(this.lbSS);
            this.splitPrincipal.Panel1.Controls.Add(this.btnDesliga);
            this.splitPrincipal.Panel1.Controls.Add(this.pictureBox1);
            this.splitPrincipal.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseDown);
            this.splitPrincipal.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseMove);
            // 
            // splitPrincipal.Panel2
            // 
            this.splitPrincipal.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitPrincipal.Panel2.Controls.Add(this.panel2);
            this.splitPrincipal.Panel2.Controls.Add(this.panel1);
            this.splitPrincipal.Panel2.Controls.Add(this.btnEnviar);
            this.splitPrincipal.Panel2.Controls.Add(this.lbUsuario);
            this.splitPrincipal.Panel2.Controls.Add(this.txtEmail);
            this.splitPrincipal.Panel2.Controls.Add(this.label6);
            this.splitPrincipal.Size = new System.Drawing.Size(485, 349);
            this.splitPrincipal.SplitterDistance = 49;
            this.splitPrincipal.SplitterWidth = 1;
            this.splitPrincipal.TabIndex = 3;
            // 
            // btnAjuda
            // 
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.ForeColor = System.Drawing.Color.DimGray;
            this.btnAjuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAjuda.Image")));
            this.btnAjuda.Location = new System.Drawing.Point(356, 2);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(0);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(39, 36);
            this.btnAjuda.TabIndex = 8;
            this.btnAjuda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // btnMinimiza
            // 
            this.btnMinimiza.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMinimiza.FlatAppearance.BorderSize = 0;
            this.btnMinimiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimiza.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimiza.ForeColor = System.Drawing.Color.DimGray;
            this.btnMinimiza.Location = new System.Drawing.Point(397, 3);
            this.btnMinimiza.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimiza.Name = "btnMinimiza";
            this.btnMinimiza.Size = new System.Drawing.Size(40, 35);
            this.btnMinimiza.TabIndex = 9;
            this.btnMinimiza.Text = "_";
            this.btnMinimiza.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnMinimiza.UseVisualStyleBackColor = true;
            this.btnMinimiza.Click += new System.EventHandler(this.btnMinimiza_Click);
            // 
            // lbSS
            // 
            this.lbSS.AutoSize = true;
            this.lbSS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSS.ForeColor = System.Drawing.Color.White;
            this.lbSS.Location = new System.Drawing.Point(57, 9);
            this.lbSS.Name = "lbSS";
            this.lbSS.Size = new System.Drawing.Size(106, 19);
            this.lbSS.TabIndex = 12;
            this.lbSS.Text = "Splash Shark";
            // 
            // btnDesliga
            // 
            this.btnDesliga.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDesliga.FlatAppearance.BorderSize = 0;
            this.btnDesliga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesliga.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesliga.ForeColor = System.Drawing.Color.White;
            this.btnDesliga.Image = ((System.Drawing.Image)(resources.GetObject("btnDesliga.Image")));
            this.btnDesliga.Location = new System.Drawing.Point(442, 3);
            this.btnDesliga.Margin = new System.Windows.Forms.Padding(0);
            this.btnDesliga.Name = "btnDesliga";
            this.btnDesliga.Size = new System.Drawing.Size(40, 35);
            this.btnDesliga.TabIndex = 10;
            this.btnDesliga.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDesliga.UseVisualStyleBackColor = true;
            this.btnDesliga.Click += new System.EventHandler(this.btnDesliga_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.erroConfSenha);
            this.panel2.Controls.Add(this.erroSenha);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtConfSenha);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbForcaSenha);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNovaSenha);
            this.panel2.Location = new System.Drawing.Point(48, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 186);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // erroConfSenha
            // 
            this.erroConfSenha.Image = ((System.Drawing.Image)(resources.GetObject("erroConfSenha.Image")));
            this.erroConfSenha.Location = new System.Drawing.Point(351, 136);
            this.erroConfSenha.Name = "erroConfSenha";
            this.erroConfSenha.Size = new System.Drawing.Size(31, 31);
            this.erroConfSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erroConfSenha.TabIndex = 27;
            this.erroConfSenha.TabStop = false;
            this.toolTip1.SetToolTip(this.erroConfSenha, "As senhas não conferem.");
            this.erroConfSenha.Visible = false;
            // 
            // erroSenha
            // 
            this.erroSenha.Image = ((System.Drawing.Image)(resources.GetObject("erroSenha.Image")));
            this.erroSenha.Location = new System.Drawing.Point(351, 69);
            this.erroSenha.Name = "erroSenha";
            this.erroSenha.Size = new System.Drawing.Size(31, 31);
            this.erroSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erroSenha.TabIndex = 26;
            this.erroSenha.TabStop = false;
            this.toolTip1.SetToolTip(this.erroSenha, "Sua senha precisa ter ao menos 6 caracteres.");
            this.erroSenha.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Insira uma nova senha para este usuário.";
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtConfSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfSenha.Location = new System.Drawing.Point(30, 136);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '*';
            this.txtConfSenha.Size = new System.Drawing.Size(315, 31);
            this.txtConfSenha.TabIndex = 8;
            this.txtConfSenha.TextChanged += new System.EventHandler(this.txtConfSenha_TextChanged);
            this.txtConfSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnviaComEnter);
            this.txtConfSenha.Leave += new System.EventHandler(this.txtConfSenha_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Confirmar Senha";
            // 
            // lbForcaSenha
            // 
            this.lbForcaSenha.AutoSize = true;
            this.lbForcaSenha.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForcaSenha.Location = new System.Drawing.Point(284, 103);
            this.lbForcaSenha.Name = "lbForcaSenha";
            this.lbForcaSenha.Size = new System.Drawing.Size(0, 19);
            this.lbForcaSenha.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nova Senha";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNovaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNovaSenha.Location = new System.Drawing.Point(30, 69);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(315, 31);
            this.txtNovaSenha.TabIndex = 7;
            this.txtNovaSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            this.txtNovaSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtNovaSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCodVer);
            this.panel1.Location = new System.Drawing.Point(48, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 186);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label5.Location = new System.Drawing.Point(7, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(379, 42);
            this.label5.TabIndex = 25;
            this.label5.Text = "Enviamos um código de verificação em seu \r\nemail.\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Código de Verificação";
            // 
            // txtCodVer
            // 
            this.txtCodVer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCodVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodVer.Location = new System.Drawing.Point(25, 115);
            this.txtCodVer.MaxLength = 7;
            this.txtCodVer.Name = "txtCodVer";
            this.txtCodVer.Size = new System.Drawing.Size(315, 31);
            this.txtCodVer.TabIndex = 7;
            this.txtCodVer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnviaComEnter);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(142, 228);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(201, 55);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Próximo";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(57, 97);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(56, 22);
            this.lbUsuario.TabIndex = 5;
            this.lbUsuario.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(61, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 31);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnviaComEnter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label6.Location = new System.Drawing.Point(57, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(378, 42);
            this.label6.TabIndex = 26;
            this.label6.Text = "Digite o email de recuperação cadastrado.\r\n\r\n";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 300;
            this.toolTip1.ReshowDelay = 100;
            // 
            // EsqueceuSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 349);
            this.Controls.Add(this.splitPrincipal);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "EsqueceuSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esqueceu a Senha";
            this.splitPrincipal.Panel1.ResumeLayout(false);
            this.splitPrincipal.Panel1.PerformLayout();
            this.splitPrincipal.Panel2.ResumeLayout(false);
            this.splitPrincipal.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPrincipal)).EndInit();
            this.splitPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroConfSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroSenha)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitPrincipal;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnMinimiza;
        private System.Windows.Forms.Label lbSS;
        private System.Windows.Forms.Button btnDesliga;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodVer;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbForcaSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox erroConfSenha;
        private System.Windows.Forms.PictureBox erroSenha;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}