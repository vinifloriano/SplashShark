namespace SplashShark
{
    partial class VisualizaFornecedor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dataGridViewForn = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEditar2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemover2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDesativar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAtivar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.selecCampo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkDesativados = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForn)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(461, 39);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(243, 60);
            this.btnRemover.TabIndex = 28;
            this.btnRemover.Text = "Remover Selecionado";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(50, 39);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(243, 60);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar Selecionado";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dataGridViewForn
            // 
            this.dataGridViewForn.AllowUserToAddRows = false;
            this.dataGridViewForn.AllowUserToResizeColumns = false;
            this.dataGridViewForn.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewForn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewForn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewForn.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewForn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewForn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForn.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewForn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewForn.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewForn.Location = new System.Drawing.Point(50, 10);
            this.dataGridViewForn.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewForn.MultiSelect = false;
            this.dataGridViewForn.Name = "dataGridViewForn";
            this.dataGridViewForn.ReadOnly = true;
            this.dataGridViewForn.RowHeadersWidth = 4;
            this.dataGridViewForn.RowTemplate.Height = 24;
            this.dataGridViewForn.Size = new System.Drawing.Size(654, 255);
            this.dataGridViewForn.TabIndex = 30;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditar2,
            this.btnRemover2,
            this.toolStripSeparator1,
            this.btnDesativar,
            this.btnAtivar});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 98);
            // 
            // btnEditar2
            // 
            this.btnEditar2.Name = "btnEditar2";
            this.btnEditar2.Size = new System.Drawing.Size(126, 22);
            this.btnEditar2.Text = "Editar";
            // 
            // btnRemover2
            // 
            this.btnRemover2.Name = "btnRemover2";
            this.btnRemover2.Size = new System.Drawing.Size(126, 22);
            this.btnRemover2.Text = "Remover";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(126, 22);
            this.btnDesativar.Text = "Desativar";
            // 
            // btnAtivar
            // 
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(126, 22);
            this.btnAtivar.Text = "Ativar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 60);
            this.panel2.TabIndex = 161;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 44);
            this.panel1.TabIndex = 15;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTitulo.Location = new System.Drawing.Point(82, 10);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(201, 23);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Pesquisa Fornecedor";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtPesquisa);
            this.panel3.Controls.Add(this.selecCampo);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panel3.Size = new System.Drawing.Size(754, 63);
            this.panel3.TabIndex = 162;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.Location = new System.Drawing.Point(294, 17);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(220, 31);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnviaComEnter);
            // 
            // selecCampo
            // 
            this.selecCampo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selecCampo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selecCampo.DropDownHeight = 90;
            this.selecCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selecCampo.DropDownWidth = 80;
            this.selecCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selecCampo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.selecCampo.IntegralHeight = false;
            this.selecCampo.ItemHeight = 22;
            this.selecCampo.Items.AddRange(new object[] {
            "ID",
            "Nome",
            "Email",
            "Telefone",
            "Todos"});
            this.selecCampo.Location = new System.Drawing.Point(50, 19);
            this.selecCampo.MaxDropDownItems = 5;
            this.selecCampo.Name = "selecCampo";
            this.selecCampo.Size = new System.Drawing.Size(187, 30);
            this.selecCampo.TabIndex = 1;
            this.selecCampo.SelectedValueChanged += new System.EventHandler(this.selecCampo_SelectedValueChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(570, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(134, 33);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewForn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 123);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.panel4.Size = new System.Drawing.Size(754, 275);
            this.panel4.TabIndex = 163;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chkDesativados);
            this.panel5.Controls.Add(this.btnEditar);
            this.panel5.Controls.Add(this.btnRemover);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 398);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(754, 102);
            this.panel5.TabIndex = 164;
            // 
            // chkDesativados
            // 
            this.chkDesativados.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkDesativados.AutoSize = true;
            this.chkDesativados.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.chkDesativados.Location = new System.Drawing.Point(500, 8);
            this.chkDesativados.Name = "chkDesativados";
            this.chkDesativados.Size = new System.Drawing.Size(204, 25);
            this.chkDesativados.TabIndex = 29;
            this.chkDesativados.Text = "Mostrar Desativados";
            this.chkDesativados.UseVisualStyleBackColor = true;
            this.chkDesativados.CheckedChanged += new System.EventHandler(this.chkDesativados_CheckedChanged);
            // 
            // VisualizaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "VisualizaFornecedor";
            this.Size = new System.Drawing.Size(754, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForn)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnRemover;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.DataGridView dataGridViewForn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox txtPesquisa;
        public System.Windows.Forms.ComboBox selecCampo;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chkDesativados;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnEditar2;
        private System.Windows.Forms.ToolStripMenuItem btnRemover2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnDesativar;
        private System.Windows.Forms.ToolStripMenuItem btnAtivar;
    }
}
