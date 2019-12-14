namespace SplashShark
{
    partial class AtualizaSalario
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.ComboBox();
            this.lbID = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.ComboBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lbSalario = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lbDireitos = new System.Windows.Forms.Label();
            this.txtUltimaAtualizacao = new System.Windows.Forms.TextBox();
            this.txtUltimoSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtID.FormattingEnabled = true;
            this.txtID.Location = new System.Drawing.Point(50, 81);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(283, 30);
            this.txtID.TabIndex = 186;
            this.txtID.SelectedIndexChanged += new System.EventHandler(this.txtID_SelectedIndexChanged);
            // 
            // lbID
            // 
            this.lbID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(46, 56);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(170, 22);
            this.lbID.TabIndex = 187;
            this.lbID.Text = "ID do Funcionário";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtNome.FormattingEnabled = true;
            this.txtNome.Location = new System.Drawing.Point(47, 81);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(283, 30);
            this.txtNome.TabIndex = 182;
            this.txtNome.SelectedIndexChanged += new System.EventHandler(this.txtNome_SelectedIndexChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalario.Location = new System.Drawing.Point(47, 244);
            this.txtSalario.MaxLength = 60;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(283, 31);
            this.txtSalario.TabIndex = 181;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnviaComEnter);
            // 
            // lbSalario
            // 
            this.lbSalario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSalario.AutoSize = true;
            this.lbSalario.Location = new System.Drawing.Point(43, 215);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(125, 22);
            this.lbSalario.TabIndex = 185;
            this.lbSalario.Text = "Novo Salário";
            // 
            // lbNome
            // 
            this.lbNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(43, 56);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(206, 22);
            this.lbNome.TabIndex = 183;
            this.lbNome.Text = "Nome do Funcionário";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(50, 220);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(283, 55);
            this.btnEnviar.TabIndex = 180;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lbDireitos
            // 
            this.lbDireitos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbDireitos.AutoSize = true;
            this.lbDireitos.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lbDireitos.Location = new System.Drawing.Point(195, 472);
            this.lbDireitos.Name = "lbDireitos";
            this.lbDireitos.Size = new System.Drawing.Size(376, 19);
            this.lbDireitos.TabIndex = 179;
            this.lbDireitos.Text = "© 2019. Todos os direitos reservados a SplashShark Inc.";
            // 
            // txtUltimaAtualizacao
            // 
            this.txtUltimaAtualizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUltimaAtualizacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUltimaAtualizacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUltimaAtualizacao.Enabled = false;
            this.txtUltimaAtualizacao.Location = new System.Drawing.Point(50, 161);
            this.txtUltimaAtualizacao.MaxLength = 60;
            this.txtUltimaAtualizacao.Name = "txtUltimaAtualizacao";
            this.txtUltimaAtualizacao.Size = new System.Drawing.Size(283, 31);
            this.txtUltimaAtualizacao.TabIndex = 191;
            // 
            // txtUltimoSalario
            // 
            this.txtUltimoSalario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUltimoSalario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUltimoSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUltimoSalario.Enabled = false;
            this.txtUltimoSalario.Location = new System.Drawing.Point(47, 161);
            this.txtUltimoSalario.MaxLength = 60;
            this.txtUltimoSalario.Name = "txtUltimoSalario";
            this.txtUltimoSalario.Size = new System.Drawing.Size(283, 31);
            this.txtUltimoSalario.TabIndex = 190;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 22);
            this.label1.TabIndex = 189;
            this.label1.Text = "Data da Última Atualização";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 188;
            this.label2.Text = "Último Salário";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 66);
            this.panel2.TabIndex = 192;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 44);
            this.panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(96, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Atualizar Salário";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 66);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbNome);
            this.splitContainer1.Panel1.Controls.Add(this.txtUltimoSalario);
            this.splitContainer1.Panel1.Controls.Add(this.txtNome);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtSalario);
            this.splitContainer1.Panel1.Controls.Add(this.lbSalario);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnEnviar);
            this.splitContainer1.Panel2.Controls.Add(this.txtUltimaAtualizacao);
            this.splitContainer1.Panel2.Controls.Add(this.lbID);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtID);
            this.splitContainer1.Size = new System.Drawing.Size(754, 340);
            this.splitContainer1.SplitterDistance = 373;
            this.splitContainer1.TabIndex = 193;
            // 
            // AtualizaSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbDireitos);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AtualizaSalario";
            this.Size = new System.Drawing.Size(754, 500);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ComboBox txtNome;
        public System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.Label lbNome;
        public System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lbDireitos;
        public System.Windows.Forms.TextBox txtUltimaAtualizacao;
        public System.Windows.Forms.TextBox txtUltimoSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.SplitContainer splitContainer1;
    }
}
