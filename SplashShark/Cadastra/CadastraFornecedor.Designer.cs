namespace SplashShark
{
    partial class CadastraFornecedor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastraFornecedor));
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.txtPseudonimo = new System.Windows.Forms.TextBox();
            this.lbPseudonimo = new System.Windows.Forms.Label();
            this.txtInscEstadual = new System.Windows.Forms.MaskedTextBox();
            this.lbInscricaoEstadual = new System.Windows.Forms.Label();
            this.lbDireitos = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.erroInscEstadual = new System.Windows.Forms.PictureBox();
            this.erroCNPJ = new System.Windows.Forms.PictureBox();
            this.erroEmail = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.lbCEP = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.lbNum = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroInscEstadual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroCNPJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCNPJ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCNPJ.Location = new System.Drawing.Point(43, 279);
            this.txtCNPJ.Mask = "00,000,000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(283, 31);
            this.txtCNPJ.TabIndex = 4;
            this.txtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtCNPJ.Leave += new System.EventHandler(this.txtCNPJ_Leave);
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Location = new System.Drawing.Point(43, 254);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(59, 22);
            this.lbCNPJ.TabIndex = 138;
            this.lbCNPJ.Text = "CNPJ";
            // 
            // txtPseudonimo
            // 
            this.txtPseudonimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPseudonimo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPseudonimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPseudonimo.Location = new System.Drawing.Point(43, 125);
            this.txtPseudonimo.MaxLength = 60;
            this.txtPseudonimo.Name = "txtPseudonimo";
            this.txtPseudonimo.Size = new System.Drawing.Size(283, 31);
            this.txtPseudonimo.TabIndex = 2;
            this.txtPseudonimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbPseudonimo
            // 
            this.lbPseudonimo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbPseudonimo.AutoSize = true;
            this.lbPseudonimo.Location = new System.Drawing.Point(43, 100);
            this.lbPseudonimo.Name = "lbPseudonimo";
            this.lbPseudonimo.Size = new System.Drawing.Size(121, 22);
            this.lbPseudonimo.TabIndex = 142;
            this.lbPseudonimo.Text = "Pseudônimo";
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInscEstadual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtInscEstadual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInscEstadual.Location = new System.Drawing.Point(43, 358);
            this.txtInscEstadual.Mask = "000,000,000,000";
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.Size = new System.Drawing.Size(283, 31);
            this.txtInscEstadual.TabIndex = 5;
            this.txtInscEstadual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbInscricaoEstadual
            // 
            this.lbInscricaoEstadual.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbInscricaoEstadual.AutoSize = true;
            this.lbInscricaoEstadual.Location = new System.Drawing.Point(43, 333);
            this.lbInscricaoEstadual.Name = "lbInscricaoEstadual";
            this.lbInscricaoEstadual.Size = new System.Drawing.Size(168, 22);
            this.lbInscricaoEstadual.TabIndex = 144;
            this.lbInscricaoEstadual.Text = "Incrição Estadual";
            // 
            // lbDireitos
            // 
            this.lbDireitos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbDireitos.AutoSize = true;
            this.lbDireitos.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lbDireitos.Location = new System.Drawing.Point(197, 675);
            this.lbDireitos.Name = "lbDireitos";
            this.lbDireitos.Size = new System.Drawing.Size(376, 19);
            this.lbDireitos.TabIndex = 149;
            this.lbDireitos.Text = "© 2019. Todos os direitos reservados a SplashShark Inc.";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(671, 22);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(26, 22);
            this.lbId.TabIndex = 155;
            this.lbId.Text = "id";
            this.lbId.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lbId);
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
            this.lbTitulo.Location = new System.Drawing.Point(77, 10);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(207, 23);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Cadastra Fornecedor";
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
            this.splitContainer1.Panel1.Controls.Add(this.lbCNPJ);
            this.splitContainer1.Panel1.Controls.Add(this.lbInscricaoEstadual);
            this.splitContainer1.Panel1.Controls.Add(this.txtInscEstadual);
            this.splitContainer1.Panel1.Controls.Add(this.erroInscEstadual);
            this.splitContainer1.Panel1.Controls.Add(this.txtCNPJ);
            this.splitContainer1.Panel1.Controls.Add(this.erroCNPJ);
            this.splitContainer1.Panel1.Controls.Add(this.erroEmail);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel1.Controls.Add(this.txtPseudonimo);
            this.splitContainer1.Panel1.Controls.Add(this.lbPseudonimo);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtEmail);
            this.splitContainer1.Panel1.Controls.Add(this.txtNome);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtComplemento);
            this.splitContainer1.Panel2.Controls.Add(this.lbComplemento);
            this.splitContainer1.Panel2.Controls.Add(this.lbCEP);
            this.splitContainer1.Panel2.Controls.Add(this.txtCep);
            this.splitContainer1.Panel2.Controls.Add(this.lbNum);
            this.splitContainer1.Panel2.Controls.Add(this.lbRua);
            this.splitContainer1.Panel2.Controls.Add(this.txtEstado);
            this.splitContainer1.Panel2.Controls.Add(this.lbBairro);
            this.splitContainer1.Panel2.Controls.Add(this.txtRua);
            this.splitContainer1.Panel2.Controls.Add(this.txtBairro);
            this.splitContainer1.Panel2.Controls.Add(this.txtNum);
            this.splitContainer1.Panel2.Controls.Add(this.lbEstado);
            this.splitContainer1.Panel2.Controls.Add(this.lbCidade);
            this.splitContainer1.Panel2.Controls.Add(this.txtCidade);
            this.splitContainer1.Panel2.Controls.Add(this.btnEnviar);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 40, 0);
            this.splitContainer1.Size = new System.Drawing.Size(754, 542);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.TabIndex = 161;
            // 
            // erroInscEstadual
            // 
            this.erroInscEstadual.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.erroInscEstadual.Image = ((System.Drawing.Image)(resources.GetObject("erroInscEstadual.Image")));
            this.erroInscEstadual.Location = new System.Drawing.Point(333, 358);
            this.erroInscEstadual.Name = "erroInscEstadual";
            this.erroInscEstadual.Size = new System.Drawing.Size(31, 31);
            this.erroInscEstadual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erroInscEstadual.TabIndex = 155;
            this.erroInscEstadual.TabStop = false;
            this.toolTip1.SetToolTip(this.erroInscEstadual, "Insira uma Inscrição Estadual válida.");
            this.erroInscEstadual.Visible = false;
            // 
            // erroCNPJ
            // 
            this.erroCNPJ.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.erroCNPJ.Image = ((System.Drawing.Image)(resources.GetObject("erroCNPJ.Image")));
            this.erroCNPJ.Location = new System.Drawing.Point(333, 279);
            this.erroCNPJ.Name = "erroCNPJ";
            this.erroCNPJ.Size = new System.Drawing.Size(31, 31);
            this.erroCNPJ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erroCNPJ.TabIndex = 154;
            this.erroCNPJ.TabStop = false;
            this.toolTip1.SetToolTip(this.erroCNPJ, "Insira um CNPJ válido.");
            this.erroCNPJ.Visible = false;
            // 
            // erroEmail
            // 
            this.erroEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.erroEmail.Image = ((System.Drawing.Image)(resources.GetObject("erroEmail.Image")));
            this.erroEmail.Location = new System.Drawing.Point(333, 201);
            this.erroEmail.Name = "erroEmail";
            this.erroEmail.Size = new System.Drawing.Size(31, 31);
            this.erroEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erroEmail.TabIndex = 152;
            this.erroEmail.TabStop = false;
            this.toolTip1.SetToolTip(this.erroEmail, "Insira um email válido.");
            this.erroEmail.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(43, 438);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(283, 55);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsReturn = true;
            this.txtEmail.AcceptsTab = true;
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(43, 201);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(283, 31);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtNome
            // 
            this.txtNome.AcceptsReturn = true;
            this.txtNome.AcceptsTab = true;
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(43, 46);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(283, 31);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComplemento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.Location = new System.Drawing.Point(43, 358);
            this.txtComplemento.MaxLength = 60;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(283, 31);
            this.txtComplemento.TabIndex = 12;
            this.txtComplemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnviaComEnter);
            // 
            // lbComplemento
            // 
            this.lbComplemento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(44, 333);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(142, 22);
            this.lbComplemento.TabIndex = 172;
            this.lbComplemento.Text = "Complemento";
            // 
            // lbCEP
            // 
            this.lbCEP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCEP.AutoSize = true;
            this.lbCEP.Location = new System.Drawing.Point(39, 19);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(46, 22);
            this.lbCEP.TabIndex = 160;
            this.lbCEP.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCep.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtCep.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCep.Location = new System.Drawing.Point(43, 44);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(116, 31);
            this.txtCep.TabIndex = 6;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // lbNum
            // 
            this.lbNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(176, 21);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(83, 22);
            this.lbNum.TabIndex = 164;
            this.lbNum.Text = "Número";
            // 
            // lbRua
            // 
            this.lbRua.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(43, 254);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(47, 22);
            this.lbRua.TabIndex = 168;
            this.lbRua.Text = "Rua";
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEstado.DropDownHeight = 90;
            this.txtEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEstado.DropDownWidth = 80;
            this.txtEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtEstado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEstado.IntegralHeight = false;
            this.txtEstado.ItemHeight = 22;
            this.txtEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.txtEstado.Location = new System.Drawing.Point(43, 126);
            this.txtEstado.MaxDropDownItems = 5;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(72, 30);
            this.txtEstado.TabIndex = 8;
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbBairro
            // 
            this.lbBairro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(43, 176);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(61, 22);
            this.lbBairro.TabIndex = 169;
            this.lbBairro.Text = "Bairro";
            // 
            // txtRua
            // 
            this.txtRua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRua.Location = new System.Drawing.Point(43, 279);
            this.txtRua.MaxLength = 60;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(283, 31);
            this.txtRua.TabIndex = 11;
            this.txtRua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBairro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Location = new System.Drawing.Point(43, 201);
            this.txtBairro.MaxLength = 60;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(283, 31);
            this.txtBairro.TabIndex = 10;
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // txtNum
            // 
            this.txtNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum.Location = new System.Drawing.Point(180, 44);
            this.txtNum.MaxLength = 6;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(146, 31);
            this.txtNum.TabIndex = 7;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbEstado
            // 
            this.lbEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(43, 97);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(72, 22);
            this.lbEstado.TabIndex = 170;
            this.lbEstado.Text = "Estado";
            // 
            // lbCidade
            // 
            this.lbCidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(134, 97);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(79, 22);
            this.lbCidade.TabIndex = 171;
            this.lbCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Location = new System.Drawing.Point(138, 124);
            this.txtCidade.MaxLength = 60;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(188, 31);
            this.txtCidade.TabIndex = 9;
            this.txtCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(43, 438);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(283, 55);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // CadastraFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbDireitos);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CadastraFornecedor";
            this.Size = new System.Drawing.Size(754, 703);
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
            ((System.ComponentModel.ISupportInitialize)(this.erroInscEstadual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroCNPJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.Label lbCNPJ;
        public System.Windows.Forms.TextBox txtPseudonimo;
        private System.Windows.Forms.Label lbPseudonimo;
        public System.Windows.Forms.MaskedTextBox txtInscEstadual;
        private System.Windows.Forms.Label lbInscricaoEstadual;
        public System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbTitulo;
        public System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox erroInscEstadual;
        private System.Windows.Forms.PictureBox erroCNPJ;
        private System.Windows.Forms.PictureBox erroEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Button btnEnviar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.Label lbCEP;
        public System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label lbRua;
        public System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.Label lbBairro;
        public System.Windows.Forms.TextBox txtRua;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbCidade;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.Label lbDireitos;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
