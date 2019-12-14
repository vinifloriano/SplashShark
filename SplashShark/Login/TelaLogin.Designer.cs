namespace SplashShark
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.splitPrincipal = new System.Windows.Forms.SplitContainer();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnMinimiza = new System.Windows.Forms.Button();
            this.lbSS = new System.Windows.Forms.Label();
            this.btnDesliga = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.erroSenha = new System.Windows.Forms.PictureBox();
            this.erroUsu = new System.Windows.Forms.PictureBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitPrincipal)).BeginInit();
            this.splitPrincipal.Panel1.SuspendLayout();
            this.splitPrincipal.Panel2.SuspendLayout();
            this.splitPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // splitPrincipal
            // 
            this.splitPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.splitPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
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
            this.splitPrincipal.Panel2.Controls.Add(this.erroSenha);
            this.splitPrincipal.Panel2.Controls.Add(this.erroUsu);
            this.splitPrincipal.Panel2.Controls.Add(this.btnEnviar);
            this.splitPrincipal.Panel2.Controls.Add(this.lbSenha);
            this.splitPrincipal.Panel2.Controls.Add(this.lbUsuario);
            this.splitPrincipal.Panel2.Controls.Add(this.linkLabel1);
            this.splitPrincipal.Panel2.Controls.Add(this.txtSenha);
            this.splitPrincipal.Panel2.Controls.Add(this.txtUsuario);
            this.splitPrincipal.Panel2.Controls.Add(this.lbDescricao);
            this.splitPrincipal.Panel2.Controls.Add(this.lbTitulo);
            this.splitPrincipal.Size = new System.Drawing.Size(610, 496);
            this.splitPrincipal.SplitterDistance = 40;
            this.splitPrincipal.SplitterWidth = 1;
            this.splitPrincipal.TabIndex = 2;
            // 
            // btnAjuda
            // 
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.ForeColor = System.Drawing.Color.DimGray;
            this.btnAjuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAjuda.Image")));
            this.btnAjuda.Location = new System.Drawing.Point(483, 1);
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
            this.btnMinimiza.Location = new System.Drawing.Point(524, 1);
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
            this.btnDesliga.Location = new System.Drawing.Point(567, 1);
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
            // erroSenha
            // 
            this.erroSenha.Image = ((System.Drawing.Image)(resources.GetObject("erroSenha.Image")));
            this.erroSenha.Location = new System.Drawing.Point(469, 273);
            this.erroSenha.Name = "erroSenha";
            this.erroSenha.Size = new System.Drawing.Size(31, 31);
            this.erroSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erroSenha.TabIndex = 25;
            this.erroSenha.TabStop = false;
            this.toolTip1.SetToolTip(this.erroSenha, "Senha inválida.");
            this.erroSenha.Visible = false;
            // 
            // erroUsu
            // 
            this.erroUsu.Image = ((System.Drawing.Image)(resources.GetObject("erroUsu.Image")));
            this.erroUsu.Location = new System.Drawing.Point(469, 190);
            this.erroUsu.Name = "erroUsu";
            this.erroUsu.Size = new System.Drawing.Size(31, 31);
            this.erroUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erroUsu.TabIndex = 23;
            this.erroUsu.TabStop = false;
            this.toolTip1.SetToolTip(this.erroUsu, "Usuário não encontrado.");
            this.erroUsu.Visible = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(148, 379);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(315, 55);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Entrar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(148, 240);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(73, 22);
            this.lbSenha.TabIndex = 6;
            this.lbSenha.Text = "Senha:";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(143, 157);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(80, 22);
            this.lbUsuario.TabIndex = 5;
            this.lbUsuario.Text = "Usuário:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabel1.Location = new System.Drawing.Point(304, 307);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(159, 19);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueceu sua senha?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Location = new System.Drawing.Point(148, 273);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(315, 31);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnviaComEnter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Location = new System.Drawing.Point(148, 190);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(315, 31);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(62, 65);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(506, 42);
            this.lbDescricao.TabIndex = 1;
            this.lbDescricao.Text = "Para a segurança do sistema, é necessário efetuar o login, para \r\nsaber quais per" +
    "missões o usuário desfruta.\r\n";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(12, 21);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(248, 23);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Logue-se no Splash Shark.";
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 496);
            this.Controls.Add(this.splitPrincipal);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaLogin";
            this.splitPrincipal.Panel1.ResumeLayout(false);
            this.splitPrincipal.Panel1.PerformLayout();
            this.splitPrincipal.Panel2.ResumeLayout(false);
            this.splitPrincipal.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPrincipal)).EndInit();
            this.splitPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroUsu)).EndInit();
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
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox erroUsu;
        private System.Windows.Forms.PictureBox erroSenha;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}