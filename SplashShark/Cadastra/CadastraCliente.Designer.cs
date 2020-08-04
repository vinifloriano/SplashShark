namespace SplashShark
{
    partial class CadastraCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastraCliente));
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lbTipoPessoa = new System.Windows.Forms.Label();
            this.btnPFisica = new System.Windows.Forms.RadioButton();
            this.btnPJuridica = new System.Windows.Forms.RadioButton();
            this.lbCEP = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lbNum = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lbRua = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbRG = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.lbId = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbInscricaoEstadual = new System.Windows.Forms.Label();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lbRazaoSocial = new System.Windows.Forms.Label();
            this.txtInscEstadual = new System.Windows.Forms.MaskedTextBox();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.erroRG = new System.Windows.Forms.PictureBox();
            this.erroCPF = new System.Windows.Forms.PictureBox();
            this.erroInscEstadual = new System.Windows.Forms.PictureBox();
            this.erroCNPJ = new System.Windows.Forms.PictureBox();
            this.erroEmail = new System.Windows.Forms.PictureBox();
            this.lbDireitos = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroRG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroInscEstadual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroCNPJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(43, 95);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(65, 22);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.AcceptsReturn = true;
            this.txtNome.AcceptsTab = true;
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(43, 120);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(283, 31);
            this.txtNome.TabIndex = 3;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(44, 173);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 22);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsReturn = true;
            this.txtEmail.AcceptsTab = true;
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(44, 198);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(283, 31);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lbTelefone
            // 
            this.lbTelefone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(44, 24);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(87, 22);
            this.lbTelefone.TabIndex = 5;
            this.lbTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Location = new System.Drawing.Point(48, 46);
            this.txtTelefone.Mask = "(99)00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(283, 31);
            this.txtTelefone.TabIndex = 8;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbTipoPessoa
            // 
            this.lbTipoPessoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTipoPessoa.AutoSize = true;
            this.lbTipoPessoa.Location = new System.Drawing.Point(39, 23);
            this.lbTipoPessoa.Name = "lbTipoPessoa";
            this.lbTipoPessoa.Size = new System.Drawing.Size(143, 22);
            this.lbTipoPessoa.TabIndex = 7;
            this.lbTipoPessoa.Text = "Tipo de Pessoa";
            // 
            // btnPFisica
            // 
            this.btnPFisica.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPFisica.AutoSize = true;
            this.btnPFisica.Checked = true;
            this.btnPFisica.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnPFisica.Location = new System.Drawing.Point(62, 48);
            this.btnPFisica.Name = "btnPFisica";
            this.btnPFisica.Size = new System.Drawing.Size(72, 25);
            this.btnPFisica.TabIndex = 1;
            this.btnPFisica.TabStop = true;
            this.btnPFisica.Text = "Física";
            this.btnPFisica.UseVisualStyleBackColor = true;
            this.btnPFisica.CheckedChanged += new System.EventHandler(this.btnPFisica_CheckedChanged);
            // 
            // btnPJuridica
            // 
            this.btnPJuridica.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPJuridica.AutoSize = true;
            this.btnPJuridica.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnPJuridica.Location = new System.Drawing.Point(218, 48);
            this.btnPJuridica.Name = "btnPJuridica";
            this.btnPJuridica.Size = new System.Drawing.Size(92, 25);
            this.btnPJuridica.TabIndex = 2;
            this.btnPJuridica.Text = "Jurídica";
            this.btnPJuridica.UseVisualStyleBackColor = true;
            // 
            // lbCEP
            // 
            this.lbCEP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCEP.AutoSize = true;
            this.lbCEP.Location = new System.Drawing.Point(44, 95);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(46, 22);
            this.lbCEP.TabIndex = 10;
            this.lbCEP.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCep.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtCep.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCep.Location = new System.Drawing.Point(48, 120);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(109, 31);
            this.txtCep.TabIndex = 9;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // txtNum
            // 
            this.txtNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum.Location = new System.Drawing.Point(185, 120);
            this.txtNum.MaxLength = 6;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(146, 31);
            this.txtNum.TabIndex = 10;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbNum
            // 
            this.lbNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(181, 96);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(83, 22);
            this.lbNum.TabIndex = 13;
            this.lbNum.Text = "Número";
            // 
            // txtRua
            // 
            this.txtRua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRua.Location = new System.Drawing.Point(48, 355);
            this.txtRua.MaxLength = 60;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(283, 31);
            this.txtRua.TabIndex = 14;
            this.txtRua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbRua
            // 
            this.lbRua.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(44, 330);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(47, 22);
            this.lbRua.TabIndex = 15;
            this.lbRua.Text = "Rua";
            // 
            // lbBairro
            // 
            this.lbBairro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(43, 252);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(61, 22);
            this.lbBairro.TabIndex = 106;
            this.lbBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBairro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Location = new System.Drawing.Point(48, 277);
            this.txtBairro.MaxLength = 60;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(283, 31);
            this.txtBairro.TabIndex = 13;
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbEstado
            // 
            this.lbEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(44, 173);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(72, 22);
            this.lbEstado.TabIndex = 108;
            this.lbEstado.Text = "Estado";
            // 
            // lbCidade
            // 
            this.lbCidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(131, 174);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(79, 22);
            this.lbCidade.TabIndex = 109;
            this.lbCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Location = new System.Drawing.Point(135, 199);
            this.txtCidade.MaxLength = 60;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(195, 31);
            this.txtCidade.TabIndex = 12;
            this.txtCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(47, 507);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(284, 55);
            this.btnEnviar.TabIndex = 16;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lbCPF
            // 
            this.lbCPF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(44, 252);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(45, 22);
            this.lbCPF.TabIndex = 114;
            this.lbCPF.Text = "CPF";
            // 
            // lbRG
            // 
            this.lbRG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbRG.AutoSize = true;
            this.lbRG.Location = new System.Drawing.Point(44, 330);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(39, 22);
            this.lbRG.TabIndex = 115;
            this.lbRG.Text = "RG";
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPF.Location = new System.Drawing.Point(43, 277);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(284, 31);
            this.txtCPF.TabIndex = 5;
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // txtRG
            // 
            this.txtRG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRG.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtRG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRG.Location = new System.Drawing.Point(44, 355);
            this.txtRG.Mask = "00,000,000-A";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(283, 31);
            this.txtRG.TabIndex = 6;
            this.txtRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtRG.Leave += new System.EventHandler(this.txtRG_Leave);
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
            this.txtEstado.Location = new System.Drawing.Point(48, 200);
            this.txtEstado.MaxDropDownItems = 5;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(72, 30);
            this.txtEstado.TabIndex = 11;
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(669, 20);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(26, 22);
            this.lbId.TabIndex = 116;
            this.lbId.Text = "id";
            this.lbId.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(43, 507);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(284, 55);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            // 
            // lbInscricaoEstadual
            // 
            this.lbInscricaoEstadual.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbInscricaoEstadual.AutoSize = true;
            this.lbInscricaoEstadual.Location = new System.Drawing.Point(43, 409);
            this.lbInscricaoEstadual.Name = "lbInscricaoEstadual";
            this.lbInscricaoEstadual.Size = new System.Drawing.Size(168, 22);
            this.lbInscricaoEstadual.TabIndex = 148;
            this.lbInscricaoEstadual.Text = "Incrição Estadual";
            this.lbInscricaoEstadual.Visible = false;
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Location = new System.Drawing.Point(44, 330);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(59, 22);
            this.lbCNPJ.TabIndex = 147;
            this.lbCNPJ.Text = "CNPJ";
            this.lbCNPJ.Visible = false;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.AcceptsReturn = true;
            this.txtRazaoSocial.AcceptsTab = true;
            this.txtRazaoSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRazaoSocial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtRazaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazaoSocial.Location = new System.Drawing.Point(43, 277);
            this.txtRazaoSocial.MaxLength = 60;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(283, 31);
            this.txtRazaoSocial.TabIndex = 149;
            this.txtRazaoSocial.Visible = false;
            this.txtRazaoSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbRazaoSocial
            // 
            this.lbRazaoSocial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbRazaoSocial.AutoSize = true;
            this.lbRazaoSocial.Location = new System.Drawing.Point(44, 252);
            this.lbRazaoSocial.Name = "lbRazaoSocial";
            this.lbRazaoSocial.Size = new System.Drawing.Size(125, 22);
            this.lbRazaoSocial.TabIndex = 119;
            this.lbRazaoSocial.Text = "Razão Social";
            this.lbRazaoSocial.Visible = false;
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInscEstadual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtInscEstadual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInscEstadual.Location = new System.Drawing.Point(43, 434);
            this.txtInscEstadual.Mask = "000,000,000,000";
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.Size = new System.Drawing.Size(283, 31);
            this.txtInscEstadual.TabIndex = 149;
            this.txtInscEstadual.Visible = false;
            this.txtInscEstadual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCNPJ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCNPJ.Location = new System.Drawing.Point(44, 355);
            this.txtCNPJ.Mask = "00,000,000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(283, 31);
            this.txtCNPJ.TabIndex = 150;
            this.txtCNPJ.Visible = false;
            this.txtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtCNPJ.Leave += new System.EventHandler(this.txtCNPJ_Leave);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComplemento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.Location = new System.Drawing.Point(47, 434);
            this.txtComplemento.MaxLength = 60;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(283, 31);
            this.txtComplemento.TabIndex = 15;
            this.txtComplemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnviaComEnter);
            // 
            // lbComplemento
            // 
            this.lbComplemento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(44, 409);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(142, 22);
            this.lbComplemento.TabIndex = 158;
            this.lbComplemento.Text = "Complemento";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lbId);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 60);
            this.panel2.TabIndex = 159;
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
            this.lbTitulo.Location = new System.Drawing.Point(104, 11);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(168, 23);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Cadastra Cliente";
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
            this.splitContainer1.Panel1.Controls.Add(this.erroRG);
            this.splitContainer1.Panel1.Controls.Add(this.erroCPF);
            this.splitContainer1.Panel1.Controls.Add(this.erroInscEstadual);
            this.splitContainer1.Panel1.Controls.Add(this.erroCNPJ);
            this.splitContainer1.Panel1.Controls.Add(this.erroEmail);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel1.Controls.Add(this.txtInscEstadual);
            this.splitContainer1.Panel1.Controls.Add(this.txtCNPJ);
            this.splitContainer1.Panel1.Controls.Add(this.lbRazaoSocial);
            this.splitContainer1.Panel1.Controls.Add(this.txtRG);
            this.splitContainer1.Panel1.Controls.Add(this.lbTipoPessoa);
            this.splitContainer1.Panel1.Controls.Add(this.txtRazaoSocial);
            this.splitContainer1.Panel1.Controls.Add(this.btnPFisica);
            this.splitContainer1.Panel1.Controls.Add(this.txtCPF);
            this.splitContainer1.Panel1.Controls.Add(this.btnPJuridica);
            this.splitContainer1.Panel1.Controls.Add(this.lbInscricaoEstadual);
            this.splitContainer1.Panel1.Controls.Add(this.lbCNPJ);
            this.splitContainer1.Panel1.Controls.Add(this.lbNome);
            this.splitContainer1.Panel1.Controls.Add(this.lbEmail);
            this.splitContainer1.Panel1.Controls.Add(this.lbRG);
            this.splitContainer1.Panel1.Controls.Add(this.lbCPF);
            this.splitContainer1.Panel1.Controls.Add(this.txtEmail);
            this.splitContainer1.Panel1.Controls.Add(this.txtNome);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtComplemento);
            this.splitContainer1.Panel2.Controls.Add(this.btnEnviar);
            this.splitContainer1.Panel2.Controls.Add(this.lbComplemento);
            this.splitContainer1.Panel2.Controls.Add(this.txtTelefone);
            this.splitContainer1.Panel2.Controls.Add(this.lbTelefone);
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
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 40, 0);
            this.splitContainer1.Size = new System.Drawing.Size(754, 592);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.TabIndex = 160;
            // 
            // erroRG
            // 
            this.erroRG.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.erroRG.Image = ((System.Drawing.Image)(resources.GetObject("erroRG.Image")));
            this.erroRG.Location = new System.Drawing.Point(333, 355);
            this.erroRG.Name = "erroRG";
            this.erroRG.Size = new System.Drawing.Size(31, 31);
            this.erroRG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erroRG.TabIndex = 157;
            this.erroRG.TabStop = false;
            this.toolTip1.SetToolTip(this.erroRG, "Insira um RG  válido.");
            this.erroRG.Visible = false;
            // 
            // erroCPF
            // 
            this.erroCPF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.erroCPF.Image = ((System.Drawing.Image)(resources.GetObject("erroCPF.Image")));
            this.erroCPF.Location = new System.Drawing.Point(333, 277);
            this.erroCPF.Name = "erroCPF";
            this.erroCPF.Size = new System.Drawing.Size(31, 31);
            this.erroCPF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erroCPF.TabIndex = 156;
            this.erroCPF.TabStop = false;
            this.toolTip1.SetToolTip(this.erroCPF, "Insira um CPF válido.");
            this.erroCPF.Visible = false;
            // 
            // erroInscEstadual
            // 
            this.erroInscEstadual.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.erroInscEstadual.Image = ((System.Drawing.Image)(resources.GetObject("erroInscEstadual.Image")));
            this.erroInscEstadual.Location = new System.Drawing.Point(333, 434);
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
            this.erroCNPJ.Location = new System.Drawing.Point(333, 355);
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
            this.erroEmail.Location = new System.Drawing.Point(333, 198);
            this.erroEmail.Name = "erroEmail";
            this.erroEmail.Size = new System.Drawing.Size(31, 31);
            this.erroEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erroEmail.TabIndex = 152;
            this.erroEmail.TabStop = false;
            this.toolTip1.SetToolTip(this.erroEmail, "Insira um email válido.");
            this.erroEmail.Visible = false;
            // 
            // lbDireitos
            // 
            this.lbDireitos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbDireitos.AutoSize = true;
            this.lbDireitos.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lbDireitos.Location = new System.Drawing.Point(192, 708);
            this.lbDireitos.Name = "lbDireitos";
            this.lbDireitos.Size = new System.Drawing.Size(376, 19);
            this.lbDireitos.TabIndex = 113;
            this.lbDireitos.Text = "© 2019. Todos os direitos reservados a SplashShark Inc.";
            // 
            // CadastraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.lbDireitos);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "CadastraCliente";
            this.Size = new System.Drawing.Size(754, 730);
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
            ((System.ComponentModel.ISupportInitialize)(this.erroRG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroInscEstadual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroCNPJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbTipoPessoa;
        private System.Windows.Forms.Label lbCEP;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbRG;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.MaskedTextBox txtTelefone;
        public System.Windows.Forms.RadioButton btnPFisica;
        public System.Windows.Forms.RadioButton btnPJuridica;
        public System.Windows.Forms.MaskedTextBox txtCep;
        public System.Windows.Forms.TextBox txtNum;
        public System.Windows.Forms.TextBox txtRua;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.Button btnEnviar;
        public System.Windows.Forms.MaskedTextBox txtCPF;
        public System.Windows.Forms.MaskedTextBox txtRG;
        public System.Windows.Forms.ComboBox txtEstado;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label lbId;
        public System.Windows.Forms.TextBox txtRazaoSocial;
        public System.Windows.Forms.MaskedTextBox txtInscEstadual;
        public System.Windows.Forms.MaskedTextBox txtCNPJ;
        public System.Windows.Forms.Label lbRazaoSocial;
        public System.Windows.Forms.Label lbInscricaoEstadual;
        public System.Windows.Forms.Label lbCNPJ;
        public System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbTitulo;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Label lbDireitos;
        private System.Windows.Forms.PictureBox erroInscEstadual;
        private System.Windows.Forms.PictureBox erroCNPJ;
        private System.Windows.Forms.PictureBox erroEmail;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox erroCPF;
        private System.Windows.Forms.PictureBox erroRG;
    }
}
