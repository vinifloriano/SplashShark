namespace SplashShark
{
    partial class HistoricoPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReembolso = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.selecCampo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridViewPed = new System.Windows.Forms.DataGridView();
            this.lbTotalGeral = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.dataGridViewItens = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 60);
            this.panel2.TabIndex = 166;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 40);
            this.panel1.TabIndex = 15;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTitulo.Location = new System.Drawing.Point(143, 8);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(198, 23);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Histórico de Pedidos";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReembolso);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 398);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(754, 96);
            this.panel3.TabIndex = 167;
            // 
            // btnReembolso
            // 
            this.btnReembolso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReembolso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnReembolso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReembolso.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnReembolso.ForeColor = System.Drawing.Color.White;
            this.btnReembolso.Location = new System.Drawing.Point(6, 19);
            this.btnReembolso.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnReembolso.Name = "btnReembolso";
            this.btnReembolso.Size = new System.Drawing.Size(741, 58);
            this.btnReembolso.TabIndex = 30;
            this.btnReembolso.Text = "Realizar Reembolso";
            this.btnReembolso.UseVisualStyleBackColor = false;
            this.btnReembolso.Click += new System.EventHandler(this.btnReembolso_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewPed);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbTotalGeral);
            this.splitContainer1.Panel2.Controls.Add(this.lbTotal);
            this.splitContainer1.Panel2.Controls.Add(this.lbNomeCliente);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewItens);
            this.splitContainer1.Size = new System.Drawing.Size(754, 338);
            this.splitContainer1.SplitterDistance = 372;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 168;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtPesquisa);
            this.panel4.Controls.Add(this.selecCampo);
            this.panel4.Controls.Add(this.btnBuscar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(92, 0, 92, 0);
            this.panel4.Size = new System.Drawing.Size(352, 54);
            this.panel4.TabIndex = 167;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPesquisa.Location = new System.Drawing.Point(140, 16);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(92, 5, 92, 5);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(88, 27);
            this.txtPesquisa.TabIndex = 2;
            // 
            // selecCampo
            // 
            this.selecCampo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selecCampo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selecCampo.DropDownHeight = 90;
            this.selecCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selecCampo.DropDownWidth = 80;
            this.selecCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selecCampo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.selecCampo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.selecCampo.IntegralHeight = false;
            this.selecCampo.ItemHeight = 21;
            this.selecCampo.Items.AddRange(new object[] {
            "Número",
            "Nome",
            "Todos"});
            this.selecCampo.Location = new System.Drawing.Point(6, 14);
            this.selecCampo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.selecCampo.MaxDropDownItems = 5;
            this.selecCampo.Name = "selecCampo";
            this.selecCampo.Size = new System.Drawing.Size(129, 29);
            this.selecCampo.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(233, 7);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 42);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // dataGridViewPed
            // 
            this.dataGridViewPed.AllowUserToAddRows = false;
            this.dataGridViewPed.AllowUserToResizeColumns = false;
            this.dataGridViewPed.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPed.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPed.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPed.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPed.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPed.Location = new System.Drawing.Point(10, 73);
            this.dataGridViewPed.Margin = new System.Windows.Forms.Padding(15);
            this.dataGridViewPed.MultiSelect = false;
            this.dataGridViewPed.Name = "dataGridViewPed";
            this.dataGridViewPed.ReadOnly = true;
            this.dataGridViewPed.RowHeadersWidth = 4;
            this.dataGridViewPed.RowTemplate.Height = 24;
            this.dataGridViewPed.Size = new System.Drawing.Size(352, 255);
            this.dataGridViewPed.TabIndex = 31;
            this.dataGridViewPed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProd_CellClick);
            // 
            // lbTotalGeral
            // 
            this.lbTotalGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotalGeral.AutoSize = true;
            this.lbTotalGeral.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lbTotalGeral.Location = new System.Drawing.Point(18, 295);
            this.lbTotalGeral.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTotalGeral.Name = "lbTotalGeral";
            this.lbTotalGeral.Size = new System.Drawing.Size(114, 22);
            this.lbTotalGeral.TabIndex = 33;
            this.lbTotalGeral.Text = "Total Geral:";
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(133, 287);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(88, 41);
            this.lbTotal.TabIndex = 34;
            this.lbTotal.Text = "0,00";
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCliente.Location = new System.Drawing.Point(28, 24);
            this.lbNomeCliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(175, 25);
            this.lbNomeCliente.TabIndex = 32;
            this.lbNomeCliente.Text = "Itens do Pedido:";
            // 
            // dataGridViewItens
            // 
            this.dataGridViewItens.AllowUserToAddRows = false;
            this.dataGridViewItens.AllowUserToResizeColumns = false;
            this.dataGridViewItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewItens.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewItens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItens.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewItens.Location = new System.Drawing.Point(14, 56);
            this.dataGridViewItens.Margin = new System.Windows.Forms.Padding(7);
            this.dataGridViewItens.MultiSelect = false;
            this.dataGridViewItens.Name = "dataGridViewItens";
            this.dataGridViewItens.ReadOnly = true;
            this.dataGridViewItens.RowHeadersWidth = 4;
            this.dataGridViewItens.RowTemplate.Height = 24;
            this.dataGridViewItens.Size = new System.Drawing.Size(355, 222);
            this.dataGridViewItens.TabIndex = 31;
            // 
            // HistoricoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "HistoricoPedido";
            this.Size = new System.Drawing.Size(754, 494);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.DataGridView dataGridViewPed;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox txtPesquisa;
        public System.Windows.Forms.ComboBox selecCampo;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.DataGridView dataGridViewItens;
        public System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.Label lbTotalGeral;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnReembolso;
    }
}
