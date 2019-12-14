namespace SplashShark
{
    partial class CadastraProduto
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDireitos = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lbCor = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lbModelo = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lbMarca = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
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
            this.lbDireitos.Location = new System.Drawing.Point(196, 597);
            this.lbDireitos.Name = "lbDireitos";
            this.lbDireitos.Size = new System.Drawing.Size(376, 19);
            this.lbDireitos.TabIndex = 141;
            this.lbDireitos.Text = "© 2019. Todos os direitos reservados a SplashShark Inc.";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(34, 347);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(283, 55);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtCor
            // 
            this.txtCor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCor.Location = new System.Drawing.Point(32, 45);
            this.txtCor.MaxLength = 60;
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(283, 31);
            this.txtCor.TabIndex = 5;
            this.txtCor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbCor
            // 
            this.lbCor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCor.AutoSize = true;
            this.lbCor.Location = new System.Drawing.Point(28, 20);
            this.lbCor.Name = "lbCor";
            this.lbCor.Size = new System.Drawing.Size(43, 22);
            this.lbCor.TabIndex = 138;
            this.lbCor.Text = "Cor";
            // 
            // lbPreco
            // 
            this.lbPreco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(28, 99);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(63, 22);
            this.lbPreco.TabIndex = 135;
            this.lbPreco.Text = "Preço";
            // 
            // txtDescricao
            // 
            this.txtDescricao.AcceptsReturn = true;
            this.txtDescricao.AcceptsTab = true;
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Location = new System.Drawing.Point(46, 124);
            this.txtDescricao.MaxLength = 60;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(283, 31);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbDescricao
            // 
            this.lbDescricao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(42, 99);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(101, 22);
            this.lbDescricao.TabIndex = 121;
            this.lbDescricao.Text = "Descrição";
            // 
            // txtNome
            // 
            this.txtNome.AcceptsReturn = true;
            this.txtNome.AcceptsTab = true;
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(46, 45);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(283, 31);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbNome
            // 
            this.lbNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(42, 20);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(65, 22);
            this.lbNome.TabIndex = 116;
            this.lbNome.Text = "Nome";
            // 
            // txtModelo
            // 
            this.txtModelo.AcceptsReturn = true;
            this.txtModelo.AcceptsTab = true;
            this.txtModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModelo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelo.Location = new System.Drawing.Point(46, 202);
            this.txtModelo.MaxLength = 60;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(283, 31);
            this.txtModelo.TabIndex = 3;
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbModelo
            // 
            this.lbModelo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(42, 177);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(79, 22);
            this.lbModelo.TabIndex = 145;
            this.lbModelo.Text = "Modelo";
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.Location = new System.Drawing.Point(46, 279);
            this.txtMarca.MaxLength = 60;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(283, 31);
            this.txtMarca.TabIndex = 4;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbMarca
            // 
            this.lbMarca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(42, 254);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(71, 22);
            this.lbMarca.TabIndex = 147;
            this.lbMarca.Text = "Marca";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AcceptsReturn = true;
            this.txtQuantidade.AcceptsTab = true;
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Location = new System.Drawing.Point(32, 202);
            this.txtQuantidade.MaxLength = 10;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(283, 31);
            this.txtQuantidade.TabIndex = 7;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(28, 177);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(178, 22);
            this.lbQuantidade.TabIndex = 149;
            this.lbQuantidade.Text = "Quantidade atual";
            // 
            // txtPreco
            // 
            this.txtPreco.AcceptsReturn = true;
            this.txtPreco.AcceptsTab = true;
            this.txtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreco.Location = new System.Drawing.Point(32, 124);
            this.txtPreco.MaxLength = 10;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(283, 31);
            this.txtPreco.TabIndex = 6;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(46, 347);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(283, 55);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(672, 23);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(26, 22);
            this.lbId.TabIndex = 158;
            this.lbId.Text = "id";
            this.lbId.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbId);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 60);
            this.panel2.TabIndex = 160;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 44);
            this.panel1.TabIndex = 15;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTitulo.Location = new System.Drawing.Point(99, 11);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(173, 23);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Cadastra Produto";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel1.Controls.Add(this.lbNome);
            this.splitContainer1.Panel1.Controls.Add(this.txtNome);
            this.splitContainer1.Panel1.Controls.Add(this.lbDescricao);
            this.splitContainer1.Panel1.Controls.Add(this.txtDescricao);
            this.splitContainer1.Panel1.Controls.Add(this.lbModelo);
            this.splitContainer1.Panel1.Controls.Add(this.txtModelo);
            this.splitContainer1.Panel1.Controls.Add(this.txtMarca);
            this.splitContainer1.Panel1.Controls.Add(this.lbMarca);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtPreco);
            this.splitContainer1.Panel2.Controls.Add(this.btnEnviar);
            this.splitContainer1.Panel2.Controls.Add(this.lbPreco);
            this.splitContainer1.Panel2.Controls.Add(this.lbCor);
            this.splitContainer1.Panel2.Controls.Add(this.txtQuantidade);
            this.splitContainer1.Panel2.Controls.Add(this.txtCor);
            this.splitContainer1.Panel2.Controls.Add(this.lbQuantidade);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 40, 0);
            this.splitContainer1.Size = new System.Drawing.Size(754, 439);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.TabIndex = 161;
            // 
            // CadastraProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbDireitos);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CadastraProduto";
            this.Size = new System.Drawing.Size(754, 616);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        public System.Windows.Forms.Button btnEnviar;
        public System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lbCor;
        private System.Windows.Forms.Label lbPreco;
        public System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lbDescricao;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        public System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lbModelo;
        public System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lbMarca;
        public System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lbQuantidade;
        public System.Windows.Forms.TextBox txtPreco;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbTitulo;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Label lbDireitos;
    }
}
