namespace SplashShark
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitPrincipal = new System.Windows.Forms.SplitContainer();
            this.btnMaximiza = new System.Windows.Forms.Button();
            this.lbSS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnMinimiza = new System.Windows.Forms.Button();
            this.btnDesliga = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.splitContainerContent = new System.Windows.Forms.SplitContainer();
            this.menu1 = new SplashShark.Menu();
            this.historicoCompra1 = new SplashShark.Historico.HistoricoCompra();
            this.home1 = new SplashShark.Home();
            this.sobre1 = new SplashShark.Sobre();
            this.atualizaSalario1 = new SplashShark.AtualizaSalario();
            this.atualizaCargo1 = new SplashShark.AtualizaCargo();
            this.cadastraProduto1 = new SplashShark.CadastraProduto();
            this.cadastraFuncionario1 = new SplashShark.CadastraFuncionario();
            this.cadastraFornecedor1 = new SplashShark.CadastraFornecedor();
            this.cadastraCliente1 = new SplashShark.CadastraCliente();
            this.compra1 = new SplashShark.Compra();
            this.pedido1 = new SplashShark.Pedido();
            this.visualizaProduto1 = new SplashShark.VisualizaProduto();
            this.visualizaFuncionario1 = new SplashShark.VisualizaFuncionario();
            this.visualizaFornecedor1 = new SplashShark.VisualizaFornecedor();
            this.visualizaCliente1 = new SplashShark.VisualizaCliente();
            this.historicoPedido1 = new SplashShark.HistoricoPedido();
            ((System.ComponentModel.ISupportInitialize)(this.splitPrincipal)).BeginInit();
            this.splitPrincipal.Panel1.SuspendLayout();
            this.splitPrincipal.Panel2.SuspendLayout();
            this.splitPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).BeginInit();
            this.splitContainerContent.Panel1.SuspendLayout();
            this.splitContainerContent.Panel2.SuspendLayout();
            this.splitContainerContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitPrincipal
            // 
            this.splitPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.splitPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPrincipal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.splitPrincipal.IsSplitterFixed = true;
            this.splitPrincipal.Location = new System.Drawing.Point(1, 0);
            this.splitPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.splitPrincipal.Name = "splitPrincipal";
            this.splitPrincipal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPrincipal.Panel1
            // 
            this.splitPrincipal.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.splitPrincipal.Panel1.Controls.Add(this.btnMaximiza);
            this.splitPrincipal.Panel1.Controls.Add(this.lbSS);
            this.splitPrincipal.Panel1.Controls.Add(this.pictureBox1);
            this.splitPrincipal.Panel1.Controls.Add(this.btnBackup);
            this.splitPrincipal.Panel1.Controls.Add(this.btnMinimiza);
            this.splitPrincipal.Panel1.Controls.Add(this.btnDesliga);
            this.splitPrincipal.Panel1.Controls.Add(this.btnAjuda);
            this.splitPrincipal.Panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.splitPrincipal_Panel1_MouseDoubleClick);
            this.splitPrincipal.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseDown);
            this.splitPrincipal.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseMove);
            // 
            // splitPrincipal.Panel2
            // 
            this.splitPrincipal.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitPrincipal.Panel2.Controls.Add(this.splitContainerContent);
            this.splitPrincipal.Size = new System.Drawing.Size(1008, 543);
            this.splitPrincipal.SplitterDistance = 35;
            this.splitPrincipal.SplitterWidth = 1;
            this.splitPrincipal.TabIndex = 0;
            // 
            // btnMaximiza
            // 
            this.btnMaximiza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximiza.FlatAppearance.BorderSize = 0;
            this.btnMaximiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximiza.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximiza.ForeColor = System.Drawing.Color.DimGray;
            this.btnMaximiza.Location = new System.Drawing.Point(928, -9);
            this.btnMaximiza.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximiza.Name = "btnMaximiza";
            this.btnMaximiza.Size = new System.Drawing.Size(40, 44);
            this.btnMaximiza.TabIndex = 13;
            this.btnMaximiza.Text = "□";
            this.btnMaximiza.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnMaximiza.UseVisualStyleBackColor = true;
            this.btnMaximiza.Click += new System.EventHandler(this.btnMaximiza_Click);
            // 
            // lbSS
            // 
            this.lbSS.AutoSize = true;
            this.lbSS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSS.ForeColor = System.Drawing.Color.White;
            this.lbSS.Location = new System.Drawing.Point(40, 6);
            this.lbSS.Name = "lbSS";
            this.lbSS.Size = new System.Drawing.Size(106, 19);
            this.lbSS.TabIndex = 12;
            this.lbSS.Text = "Splash Shark";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnBackup.ForeColor = System.Drawing.Color.DimGray;
            this.btnBackup.Location = new System.Drawing.Point(731, 0);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(115, 35);
            this.btnBackup.TabIndex = 11;
            this.btnBackup.Text = "Backup";
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnMinimiza
            // 
            this.btnMinimiza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimiza.FlatAppearance.BorderSize = 0;
            this.btnMinimiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimiza.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimiza.ForeColor = System.Drawing.Color.DimGray;
            this.btnMinimiza.Location = new System.Drawing.Point(886, 0);
            this.btnMinimiza.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimiza.Name = "btnMinimiza";
            this.btnMinimiza.Size = new System.Drawing.Size(40, 35);
            this.btnMinimiza.TabIndex = 10;
            this.btnMinimiza.Text = "_";
            this.btnMinimiza.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnMinimiza.UseVisualStyleBackColor = true;
            this.btnMinimiza.Click += new System.EventHandler(this.btnMinimiza_Click);
            // 
            // btnDesliga
            // 
            this.btnDesliga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesliga.FlatAppearance.BorderSize = 0;
            this.btnDesliga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesliga.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesliga.ForeColor = System.Drawing.Color.White;
            this.btnDesliga.Image = ((System.Drawing.Image)(resources.GetObject("btnDesliga.Image")));
            this.btnDesliga.Location = new System.Drawing.Point(968, 0);
            this.btnDesliga.Margin = new System.Windows.Forms.Padding(0);
            this.btnDesliga.Name = "btnDesliga";
            this.btnDesliga.Size = new System.Drawing.Size(40, 35);
            this.btnDesliga.TabIndex = 9;
            this.btnDesliga.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDesliga.UseVisualStyleBackColor = true;
            this.btnDesliga.Click += new System.EventHandler(this.btnDesliga_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.ForeColor = System.Drawing.Color.DimGray;
            this.btnAjuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAjuda.Image")));
            this.btnAjuda.Location = new System.Drawing.Point(847, 0);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(0);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(40, 35);
            this.btnAjuda.TabIndex = 8;
            this.btnAjuda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // splitContainerContent
            // 
            this.splitContainerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerContent.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerContent.IsSplitterFixed = true;
            this.splitContainerContent.Location = new System.Drawing.Point(0, 0);
            this.splitContainerContent.Name = "splitContainerContent";
            // 
            // splitContainerContent.Panel1
            // 
            this.splitContainerContent.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.splitContainerContent.Panel1.Controls.Add(this.menu1);
            // 
            // splitContainerContent.Panel2
            // 
            this.splitContainerContent.Panel2.Controls.Add(this.home1);
            this.splitContainerContent.Panel2.Controls.Add(this.sobre1);
            this.splitContainerContent.Panel2.Controls.Add(this.atualizaSalario1);
            this.splitContainerContent.Panel2.Controls.Add(this.atualizaCargo1);
            this.splitContainerContent.Panel2.Controls.Add(this.cadastraProduto1);
            this.splitContainerContent.Panel2.Controls.Add(this.cadastraFuncionario1);
            this.splitContainerContent.Panel2.Controls.Add(this.cadastraFornecedor1);
            this.splitContainerContent.Panel2.Controls.Add(this.cadastraCliente1);
            this.splitContainerContent.Panel2.Controls.Add(this.compra1);
            this.splitContainerContent.Panel2.Controls.Add(this.pedido1);
            this.splitContainerContent.Panel2.Controls.Add(this.visualizaProduto1);
            this.splitContainerContent.Panel2.Controls.Add(this.visualizaFuncionario1);
            this.splitContainerContent.Panel2.Controls.Add(this.visualizaFornecedor1);
            this.splitContainerContent.Panel2.Controls.Add(this.visualizaCliente1);
            this.splitContainerContent.Panel2.Controls.Add(this.historicoPedido1);
            this.splitContainerContent.Panel2.Controls.Add(this.historicoCompra1);
            this.splitContainerContent.Size = new System.Drawing.Size(1008, 507);
            this.splitContainerContent.SplitterDistance = 259;
            this.splitContainerContent.SplitterWidth = 1;
            this.splitContainerContent.TabIndex = 15;
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.menu1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(257, 1150);
            this.menu1.TabIndex = 0;
            // 
            // historicoCompra1
            // 
            this.historicoCompra1.BackColor = System.Drawing.SystemColors.Control;
            this.historicoCompra1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historicoCompra1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historicoCompra1.Location = new System.Drawing.Point(0, 0);
            this.historicoCompra1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.historicoCompra1.Name = "historicoCompra1";
            this.historicoCompra1.Size = new System.Drawing.Size(748, 507);
            this.historicoCompra1.TabIndex = 15;
            // 
            // home1
            // 
            this.home1.AutoSize = true;
            this.home1.BackColor = System.Drawing.SystemColors.Control;
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(748, 507);
            this.home1.TabIndex = 13;
            // 
            // sobre1
            // 
            this.sobre1.AutoScroll = true;
            this.sobre1.BackColor = System.Drawing.SystemColors.Control;
            this.sobre1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sobre1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.sobre1.Location = new System.Drawing.Point(0, 0);
            this.sobre1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.sobre1.Name = "sobre1";
            this.sobre1.Size = new System.Drawing.Size(748, 507);
            this.sobre1.TabIndex = 12;
            // 
            // atualizaSalario1
            // 
            this.atualizaSalario1.AutoScroll = true;
            this.atualizaSalario1.BackColor = System.Drawing.SystemColors.Control;
            this.atualizaSalario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atualizaSalario1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.atualizaSalario1.Location = new System.Drawing.Point(0, 0);
            this.atualizaSalario1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.atualizaSalario1.Name = "atualizaSalario1";
            this.atualizaSalario1.Size = new System.Drawing.Size(748, 507);
            this.atualizaSalario1.TabIndex = 11;
            // 
            // atualizaCargo1
            // 
            this.atualizaCargo1.AutoScroll = true;
            this.atualizaCargo1.BackColor = System.Drawing.SystemColors.Control;
            this.atualizaCargo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atualizaCargo1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.atualizaCargo1.Location = new System.Drawing.Point(0, 0);
            this.atualizaCargo1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.atualizaCargo1.Name = "atualizaCargo1";
            this.atualizaCargo1.Size = new System.Drawing.Size(748, 507);
            this.atualizaCargo1.TabIndex = 10;
            // 
            // cadastraProduto1
            // 
            this.cadastraProduto1.AutoScroll = true;
            this.cadastraProduto1.BackColor = System.Drawing.SystemColors.Control;
            this.cadastraProduto1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastraProduto1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cadastraProduto1.Location = new System.Drawing.Point(0, 0);
            this.cadastraProduto1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cadastraProduto1.Name = "cadastraProduto1";
            this.cadastraProduto1.Size = new System.Drawing.Size(748, 507);
            this.cadastraProduto1.TabIndex = 9;
            // 
            // cadastraFuncionario1
            // 
            this.cadastraFuncionario1.AutoScroll = true;
            this.cadastraFuncionario1.BackColor = System.Drawing.SystemColors.Control;
            this.cadastraFuncionario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastraFuncionario1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cadastraFuncionario1.Location = new System.Drawing.Point(0, 0);
            this.cadastraFuncionario1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cadastraFuncionario1.Name = "cadastraFuncionario1";
            this.cadastraFuncionario1.Size = new System.Drawing.Size(748, 507);
            this.cadastraFuncionario1.TabIndex = 8;
            // 
            // cadastraFornecedor1
            // 
            this.cadastraFornecedor1.AutoScroll = true;
            this.cadastraFornecedor1.BackColor = System.Drawing.SystemColors.Control;
            this.cadastraFornecedor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastraFornecedor1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cadastraFornecedor1.Location = new System.Drawing.Point(0, 0);
            this.cadastraFornecedor1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cadastraFornecedor1.Name = "cadastraFornecedor1";
            this.cadastraFornecedor1.Size = new System.Drawing.Size(748, 507);
            this.cadastraFornecedor1.TabIndex = 7;
            // 
            // cadastraCliente1
            // 
            this.cadastraCliente1.AutoScroll = true;
            this.cadastraCliente1.BackColor = System.Drawing.SystemColors.Control;
            this.cadastraCliente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastraCliente1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cadastraCliente1.Location = new System.Drawing.Point(0, 0);
            this.cadastraCliente1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cadastraCliente1.Name = "cadastraCliente1";
            this.cadastraCliente1.Size = new System.Drawing.Size(748, 507);
            this.cadastraCliente1.TabIndex = 6;
            // 
            // compra1
            // 
            this.compra1.AutoScroll = true;
            this.compra1.BackColor = System.Drawing.SystemColors.Control;
            this.compra1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compra1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.compra1.Location = new System.Drawing.Point(0, 0);
            this.compra1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.compra1.Name = "compra1";
            this.compra1.Size = new System.Drawing.Size(748, 507);
            this.compra1.TabIndex = 5;
            // 
            // pedido1
            // 
            this.pedido1.AutoScroll = true;
            this.pedido1.BackColor = System.Drawing.SystemColors.Control;
            this.pedido1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pedido1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.pedido1.Location = new System.Drawing.Point(0, 0);
            this.pedido1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pedido1.Name = "pedido1";
            this.pedido1.Size = new System.Drawing.Size(748, 507);
            this.pedido1.TabIndex = 4;
            // 
            // visualizaProduto1
            // 
            this.visualizaProduto1.AutoScroll = true;
            this.visualizaProduto1.BackColor = System.Drawing.SystemColors.Control;
            this.visualizaProduto1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizaProduto1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.visualizaProduto1.Location = new System.Drawing.Point(0, 0);
            this.visualizaProduto1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.visualizaProduto1.Name = "visualizaProduto1";
            this.visualizaProduto1.Size = new System.Drawing.Size(748, 507);
            this.visualizaProduto1.TabIndex = 3;
            // 
            // visualizaFuncionario1
            // 
            this.visualizaFuncionario1.AutoScroll = true;
            this.visualizaFuncionario1.BackColor = System.Drawing.SystemColors.Control;
            this.visualizaFuncionario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizaFuncionario1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.visualizaFuncionario1.Location = new System.Drawing.Point(0, 0);
            this.visualizaFuncionario1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.visualizaFuncionario1.Name = "visualizaFuncionario1";
            this.visualizaFuncionario1.Size = new System.Drawing.Size(748, 507);
            this.visualizaFuncionario1.TabIndex = 2;
            // 
            // visualizaFornecedor1
            // 
            this.visualizaFornecedor1.AutoScroll = true;
            this.visualizaFornecedor1.BackColor = System.Drawing.SystemColors.Control;
            this.visualizaFornecedor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizaFornecedor1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.visualizaFornecedor1.Location = new System.Drawing.Point(0, 0);
            this.visualizaFornecedor1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.visualizaFornecedor1.Name = "visualizaFornecedor1";
            this.visualizaFornecedor1.Size = new System.Drawing.Size(748, 507);
            this.visualizaFornecedor1.TabIndex = 1;
            // 
            // visualizaCliente1
            // 
            this.visualizaCliente1.AutoScroll = true;
            this.visualizaCliente1.BackColor = System.Drawing.SystemColors.Control;
            this.visualizaCliente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizaCliente1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.visualizaCliente1.Location = new System.Drawing.Point(0, 0);
            this.visualizaCliente1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.visualizaCliente1.Name = "visualizaCliente1";
            this.visualizaCliente1.Size = new System.Drawing.Size(748, 507);
            this.visualizaCliente1.TabIndex = 0;
            // 
            // historicoPedido1
            // 
            this.historicoPedido1.BackColor = System.Drawing.SystemColors.Control;
            this.historicoPedido1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historicoPedido1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historicoPedido1.Location = new System.Drawing.Point(0, 0);
            this.historicoPedido1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.historicoPedido1.Name = "historicoPedido1";
            this.historicoPedido1.Size = new System.Drawing.Size(748, 507);
            this.historicoPedido1.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1010, 544);
            this.Controls.Add(this.splitPrincipal);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Shark";
            this.splitPrincipal.Panel1.ResumeLayout(false);
            this.splitPrincipal.Panel1.PerformLayout();
            this.splitPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPrincipal)).EndInit();
            this.splitPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainerContent.Panel1.ResumeLayout(false);
            this.splitContainerContent.Panel2.ResumeLayout(false);
            this.splitContainerContent.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).EndInit();
            this.splitContainerContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitPrincipal;
        private System.Windows.Forms.Button btnMinimiza;
        private System.Windows.Forms.Button btnDesliga;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbSS;
        private System.Windows.Forms.SplitContainer splitContainerContent;
        private CadastraProduto cadastraProduto1;
        private CadastraFuncionario cadastraFuncionario1;
        private CadastraFornecedor cadastraFornecedor1;
        private CadastraCliente cadastraCliente1;
        private Compra compra1;
        private Pedido pedido1;
        private VisualizaProduto visualizaProduto1;
        private VisualizaFuncionario visualizaFuncionario1;
        private VisualizaFornecedor visualizaFornecedor1;
        private VisualizaCliente visualizaCliente1;
        private Home home1;
        private Sobre sobre1;
        private AtualizaSalario atualizaSalario1;
        private AtualizaCargo atualizaCargo1;
        private System.Windows.Forms.Button btnMaximiza;
        public Menu menu1;
        private HistoricoPedido historicoPedido1;
        public System.Windows.Forms.Button btnBackup;
        private Historico.HistoricoCompra historicoCompra1;
    }
}

