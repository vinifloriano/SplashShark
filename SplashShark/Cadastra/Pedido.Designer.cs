namespace SplashShark
{
    partial class Pedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCPFCli = new System.Windows.Forms.ComboBox();
            this.txtNomeCli = new System.Windows.Forms.ComboBox();
            this.txtCodProd = new System.Windows.Forms.ComboBox();
            this.txtNomeProd = new System.Windows.Forms.ComboBox();
            this.lbCPFCli = new System.Windows.Forms.Label();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.lbCodProd = new System.Windows.Forms.Label();
            this.lbNomeProd = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbTotalGeral = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbQuantProd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPedido
            // 
            this.dataGridViewPedido.AllowUserToAddRows = false;
            this.dataGridViewPedido.AllowUserToDeleteRows = false;
            this.dataGridViewPedido.AllowUserToResizeColumns = false;
            this.dataGridViewPedido.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPedido.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.quantidade,
            this.preco,
            this.subtotal});
            this.dataGridViewPedido.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPedido.Location = new System.Drawing.Point(17, 64);
            this.dataGridViewPedido.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPedido.MultiSelect = false;
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.ReadOnly = true;
            this.dataGridViewPedido.RowHeadersWidth = 4;
            this.dataGridViewPedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPedido.RowTemplate.Height = 24;
            this.dataGridViewPedido.Size = new System.Drawing.Size(473, 255);
            this.dataGridViewPedido.TabIndex = 15;
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigo.HeaderText = "COD.";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "NOME";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantidade.HeaderText = "QTD";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.preco.HeaderText = "PREÇO";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subtotal.HeaderText = "SUBTOT.";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // txtCPFCli
            // 
            this.txtCPFCli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPFCli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtCPFCli.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCPFCli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCPFCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCPFCli.Location = new System.Drawing.Point(23, 56);
            this.txtCPFCli.Name = "txtCPFCli";
            this.txtCPFCli.Size = new System.Drawing.Size(190, 30);
            this.txtCPFCli.TabIndex = 17;
            this.txtCPFCli.SelectedIndexChanged += new System.EventHandler(this.txtCPFCli_SelectedValueChanged);
            this.txtCPFCli.SelectedValueChanged += new System.EventHandler(this.Valida_SelectedIndexChanged);
            this.txtCPFCli.Leave += new System.EventHandler(this.txtCPFCli_Leave);
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNomeCli.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtNomeCli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNomeCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtNomeCli.FormattingEnabled = true;
            this.txtNomeCli.Location = new System.Drawing.Point(22, 114);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(190, 30);
            this.txtNomeCli.TabIndex = 18;
            this.txtNomeCli.SelectedIndexChanged += new System.EventHandler(this.txtNomeCli_SelectedValueChanged);
            this.txtNomeCli.SelectedValueChanged += new System.EventHandler(this.Valida_SelectedIndexChanged);
            // 
            // txtCodProd
            // 
            this.txtCodProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtCodProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCodProd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCodProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCodProd.FormattingEnabled = true;
            this.txtCodProd.Location = new System.Drawing.Point(24, 172);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(190, 30);
            this.txtCodProd.TabIndex = 19;
            this.txtCodProd.SelectedIndexChanged += new System.EventHandler(this.txtCodProd_SelectedValueChanged);
            this.txtCodProd.SelectedValueChanged += new System.EventHandler(this.Valida_SelectedIndexChanged);
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNomeProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtNomeProd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNomeProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtNomeProd.FormattingEnabled = true;
            this.txtNomeProd.Location = new System.Drawing.Point(24, 230);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(190, 30);
            this.txtNomeProd.TabIndex = 20;
            this.txtNomeProd.SelectedIndexChanged += new System.EventHandler(this.txtNomeProd_SelectedValueChanged);
            this.txtNomeProd.SelectedValueChanged += new System.EventHandler(this.Valida_SelectedIndexChanged);
            // 
            // lbCPFCli
            // 
            this.lbCPFCli.AutoSize = true;
            this.lbCPFCli.Location = new System.Drawing.Point(17, 32);
            this.lbCPFCli.Name = "lbCPFCli";
            this.lbCPFCli.Size = new System.Drawing.Size(181, 22);
            this.lbCPFCli.TabIndex = 21;
            this.lbCPFCli.Text = "CPF / CNPJ Cliente";
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Location = new System.Drawing.Point(18, 89);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(134, 22);
            this.lbNomeCliente.TabIndex = 22;
            this.lbNomeCliente.Text = "Nome Cliente";
            // 
            // lbCodProd
            // 
            this.lbCodProd.AutoSize = true;
            this.lbCodProd.Location = new System.Drawing.Point(20, 147);
            this.lbCodProd.Name = "lbCodProd";
            this.lbCodProd.Size = new System.Drawing.Size(156, 22);
            this.lbCodProd.TabIndex = 23;
            this.lbCodProd.Text = "Código Produto";
            // 
            // lbNomeProd
            // 
            this.lbNomeProd.AutoSize = true;
            this.lbNomeProd.Location = new System.Drawing.Point(20, 205);
            this.lbNomeProd.Name = "lbNomeProd";
            this.lbNomeProd.Size = new System.Drawing.Size(143, 22);
            this.lbNomeProd.TabIndex = 24;
            this.lbNomeProd.Text = "Nome Produto";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Location = new System.Drawing.Point(25, 288);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(189, 31);
            this.txtQuantidade.TabIndex = 25;
            this.txtQuantidade.Text = "1";
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(20, 263);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(125, 22);
            this.lbQuantidade.TabIndex = 26;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // lbTotalGeral
            // 
            this.lbTotalGeral.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTotalGeral.AutoSize = true;
            this.lbTotalGeral.Location = new System.Drawing.Point(21, 20);
            this.lbTotalGeral.Name = "lbTotalGeral";
            this.lbTotalGeral.Size = new System.Drawing.Size(114, 22);
            this.lbTotalGeral.TabIndex = 27;
            this.lbTotalGeral.Text = "Total Geral:";
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(64, 37);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(88, 41);
            this.lbTotal.TabIndex = 28;
            this.lbTotal.Text = "0,00";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(513, 20);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(216, 58);
            this.btnFinalizar.TabIndex = 29;
            this.btnFinalizar.Text = "Finalizar Compra";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(17, 20);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(190, 37);
            this.btnAdicionar.TabIndex = 30;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(301, 20);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(189, 37);
            this.btnRemover.TabIndex = 31;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(256, 20);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(205, 58);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar Compra";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel2
            // 
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 44);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(139, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbQuantProd);
            this.splitContainer1.Panel1.Controls.Add(this.txtQuantidade);
            this.splitContainer1.Panel1.Controls.Add(this.txtCPFCli);
            this.splitContainer1.Panel1.Controls.Add(this.txtNomeCli);
            this.splitContainer1.Panel1.Controls.Add(this.txtCodProd);
            this.splitContainer1.Panel1.Controls.Add(this.txtNomeProd);
            this.splitContainer1.Panel1.Controls.Add(this.lbCPFCli);
            this.splitContainer1.Panel1.Controls.Add(this.lbQuantidade);
            this.splitContainer1.Panel1.Controls.Add(this.lbNomeCliente);
            this.splitContainer1.Panel1.Controls.Add(this.lbCodProd);
            this.splitContainer1.Panel1.Controls.Add(this.lbNomeProd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewPedido);
            this.splitContainer1.Panel2.Controls.Add(this.btnRemover);
            this.splitContainer1.Panel2.Controls.Add(this.btnAdicionar);
            this.splitContainer1.Size = new System.Drawing.Size(754, 333);
            this.splitContainer1.SplitterDistance = 235;
            this.splitContainer1.TabIndex = 161;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbTotalGeral);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.lbTotal);
            this.panel3.Controls.Add(this.btnFinalizar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 393);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(754, 98);
            this.panel3.TabIndex = 162;
            // 
            // lbQuantProd
            // 
            this.lbQuantProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbQuantProd.AutoSize = true;
            this.lbQuantProd.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lbQuantProd.Location = new System.Drawing.Point(176, 206);
            this.lbQuantProd.Name = "lbQuantProd";
            this.lbQuantProd.Size = new System.Drawing.Size(0, 19);
            this.lbQuantProd.TabIndex = 27;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Pedido";
            this.Size = new System.Drawing.Size(754, 494);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewPedido;
        private System.Windows.Forms.Label lbTotalGeral;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        public System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lbNomeCliente;
        public System.Windows.Forms.Label lbCodProd;
        public System.Windows.Forms.Label lbNomeProd;
        public System.Windows.Forms.Label lbQuantidade;
        public System.Windows.Forms.ComboBox txtNomeCli;
        public System.Windows.Forms.ComboBox txtCodProd;
        public System.Windows.Forms.ComboBox txtNomeProd;
        public System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.ComboBox txtCPFCli;
        public System.Windows.Forms.Label lbCPFCli;
        private System.Windows.Forms.Label lbQuantProd;
    }
}
