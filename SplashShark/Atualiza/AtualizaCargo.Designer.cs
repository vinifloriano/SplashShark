namespace SplashShark
{
    partial class AtualizaCargo
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
            this.lbDireitos = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.ComboBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.ComboBox();
            this.lbID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUltimoCargo = new System.Windows.Forms.TextBox();
            this.txtUltimaAtualizacao = new System.Windows.Forms.TextBox();
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
            // lbDireitos
            // 
            this.lbDireitos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbDireitos.AutoSize = true;
            this.lbDireitos.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lbDireitos.Location = new System.Drawing.Point(174, 479);
            this.lbDireitos.Name = "lbDireitos";
            this.lbDireitos.Size = new System.Drawing.Size(376, 19);
            this.lbDireitos.TabIndex = 114;
            this.lbDireitos.Text = "© 2019. Todos os direitos reservados a SplashShark Inc.";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(44, 218);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(283, 55);
            this.btnEnviar.TabIndex = 115;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtNome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtNome.FormattingEnabled = true;
            this.txtNome.Location = new System.Drawing.Point(50, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(283, 30);
            this.txtNome.TabIndex = 166;
            this.txtNome.SelectedIndexChanged += new System.EventHandler(this.txtNome_SelectedIndexChanged);
            // 
            // txtCargo
            // 
            this.txtCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCargo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCargo.Location = new System.Drawing.Point(50, 242);
            this.txtCargo.MaxLength = 60;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(283, 31);
            this.txtCargo.TabIndex = 162;
            this.txtCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnviaComEnter);
            // 
            // lbCargo
            // 
            this.lbCargo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCargo.AutoSize = true;
            this.lbCargo.Location = new System.Drawing.Point(46, 217);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(125, 22);
            this.lbCargo.TabIndex = 173;
            this.lbCargo.Text = "Novo Cargo";
            // 
            // lbNome
            // 
            this.lbNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(47, 47);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(206, 22);
            this.lbNome.TabIndex = 167;
            this.lbNome.Text = "Nome do Funcionário";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtID.FormattingEnabled = true;
            this.txtID.Location = new System.Drawing.Point(45, 71);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(283, 30);
            this.txtID.TabIndex = 177;
            this.txtID.SelectedIndexChanged += new System.EventHandler(this.txtID_SelectedIndexChanged);
            // 
            // lbID
            // 
            this.lbID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(40, 47);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(170, 22);
            this.lbID.TabIndex = 178;
            this.lbID.Text = "ID do Funcionário";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 22);
            this.label1.TabIndex = 182;
            this.label1.Text = "Data da Última Atualização";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 180;
            this.label2.Text = "Último Cargo";
            // 
            // txtUltimoCargo
            // 
            this.txtUltimoCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUltimoCargo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUltimoCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUltimoCargo.Enabled = false;
            this.txtUltimoCargo.Location = new System.Drawing.Point(50, 156);
            this.txtUltimoCargo.MaxLength = 60;
            this.txtUltimoCargo.Name = "txtUltimoCargo";
            this.txtUltimoCargo.Size = new System.Drawing.Size(283, 31);
            this.txtUltimoCargo.TabIndex = 183;
            // 
            // txtUltimaAtualizacao
            // 
            this.txtUltimaAtualizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUltimaAtualizacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUltimaAtualizacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUltimaAtualizacao.Enabled = false;
            this.txtUltimaAtualizacao.Location = new System.Drawing.Point(45, 156);
            this.txtUltimaAtualizacao.MaxLength = 60;
            this.txtUltimaAtualizacao.Name = "txtUltimaAtualizacao";
            this.txtUltimaAtualizacao.Size = new System.Drawing.Size(283, 31);
            this.txtUltimaAtualizacao.TabIndex = 184;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 66);
            this.panel2.TabIndex = 185;
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
            this.label3.Location = new System.Drawing.Point(99, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Atualizar Cargo";
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
            this.splitContainer1.Panel1.Controls.Add(this.txtNome);
            this.splitContainer1.Panel1.Controls.Add(this.txtUltimoCargo);
            this.splitContainer1.Panel1.Controls.Add(this.lbNome);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtCargo);
            this.splitContainer1.Panel1.Controls.Add(this.lbCargo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnEnviar);
            this.splitContainer1.Panel2.Controls.Add(this.txtUltimaAtualizacao);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtID);
            this.splitContainer1.Panel2.Controls.Add(this.lbID);
            this.splitContainer1.Size = new System.Drawing.Size(754, 340);
            this.splitContainer1.SplitterDistance = 373;
            this.splitContainer1.TabIndex = 186;
            // 
            // AtualizaCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbDireitos);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AtualizaCargo";
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

        private System.Windows.Forms.Label lbDireitos;
        public System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox txtNome;
        public System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.ComboBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtUltimoCargo;
        public System.Windows.Forms.TextBox txtUltimaAtualizacao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.SplitContainer splitContainer1;
    }
}
