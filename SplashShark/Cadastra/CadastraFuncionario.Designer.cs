namespace SplashShark
{
    partial class CadastraFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastraFuncionario));
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lbRG = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbDireitos = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.lbCEP = new System.Windows.Forms.Label();
            this.btnFem = new System.Windows.Forms.RadioButton();
            this.btnMasc = new System.Windows.Forms.RadioButton();
            this.lbSexo = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.lbDataNasc = new System.Windows.Forms.Label();
            this.txtDataCont = new System.Windows.Forms.MaskedTextBox();
            this.lbDataCont = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lbCargo = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lbSalario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.lbConfSenha = new System.Windows.Forms.Label();
            this.lbForcaSenha = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.erroCPF = new System.Windows.Forms.PictureBox();
            this.erroRG = new System.Windows.Forms.PictureBox();
            this.erroDataNasc = new System.Windows.Forms.PictureBox();
            this.erroDataCont = new System.Windows.Forms.PictureBox();
            this.erroEmail = new System.Windows.Forms.PictureBox();
            this.erroSenha = new System.Windows.Forms.PictureBox();
            this.erroConfSenha = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.erroCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroRG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroDataNasc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroDataCont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroConfSenha)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.txtEstado.Location = new System.Drawing.Point(47, 210);
            this.txtEstado.MaxDropDownItems = 5;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(68, 30);
            this.txtEstado.TabIndex = 14;
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // txtRua
            // 
            this.txtRua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRua.Location = new System.Drawing.Point(47, 368);
            this.txtRua.MaxLength = 60;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(283, 31);
            this.txtRua.TabIndex = 17;
            this.txtRua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // txtNum
            // 
            this.txtNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum.Location = new System.Drawing.Point(190, 131);
            this.txtNum.MaxLength = 6;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(140, 31);
            this.txtNum.TabIndex = 13;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // txtRG
            // 
            this.txtRG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRG.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtRG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRG.Location = new System.Drawing.Point(43, 289);
            this.txtRG.Mask = "00,000,000-A";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(283, 31);
            this.txtRG.TabIndex = 4;
            this.txtRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtRG.Leave += new System.EventHandler(this.txtRG_Leave);
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPF.Location = new System.Drawing.Point(43, 210);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(283, 31);
            this.txtCPF.TabIndex = 3;
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // lbRG
            // 
            this.lbRG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbRG.AutoSize = true;
            this.lbRG.Location = new System.Drawing.Point(40, 264);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(39, 22);
            this.lbRG.TabIndex = 143;
            this.lbRG.Text = "RG";
            // 
            // lbCPF
            // 
            this.lbCPF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(39, 185);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(45, 22);
            this.lbCPF.TabIndex = 142;
            this.lbCPF.Text = "CPF";
            // 
            // lbDireitos
            // 
            this.lbDireitos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbDireitos.AutoSize = true;
            this.lbDireitos.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lbDireitos.Location = new System.Drawing.Point(190, 25);
            this.lbDireitos.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
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
            this.btnEnviar.Location = new System.Drawing.Point(47, 751);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(283, 55);
            this.btnEnviar.TabIndex = 20;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Location = new System.Drawing.Point(154, 210);
            this.txtCidade.MaxLength = 60;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(176, 31);
            this.txtCidade.TabIndex = 15;
            this.txtCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbCidade
            // 
            this.lbCidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(150, 180);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(79, 22);
            this.lbCidade.TabIndex = 140;
            this.lbCidade.Text = "Cidade";
            // 
            // lbEstado
            // 
            this.lbEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(43, 180);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(72, 22);
            this.lbEstado.TabIndex = 139;
            this.lbEstado.Text = "Estado";
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBairro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Location = new System.Drawing.Point(47, 289);
            this.txtBairro.MaxLength = 60;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(283, 31);
            this.txtBairro.TabIndex = 16;
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbBairro
            // 
            this.lbBairro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(43, 259);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(61, 22);
            this.lbBairro.TabIndex = 138;
            this.lbBairro.Text = "Bairro";
            // 
            // lbRua
            // 
            this.lbRua.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(43, 338);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(47, 22);
            this.lbRua.TabIndex = 135;
            this.lbRua.Text = "Rua";
            // 
            // lbNum
            // 
            this.lbNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(186, 101);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(83, 22);
            this.lbNum.TabIndex = 134;
            this.lbNum.Text = "Número";
            // 
            // txtCep
            // 
            this.txtCep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCep.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtCep.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCep.Location = new System.Drawing.Point(47, 131);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(112, 31);
            this.txtCep.TabIndex = 12;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // lbCEP
            // 
            this.lbCEP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCEP.AutoSize = true;
            this.lbCEP.Location = new System.Drawing.Point(43, 106);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(46, 22);
            this.lbCEP.TabIndex = 130;
            this.lbCEP.Text = "CEP";
            // 
            // btnFem
            // 
            this.btnFem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFem.AutoSize = true;
            this.btnFem.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnFem.Location = new System.Drawing.Point(231, 52);
            this.btnFem.Name = "btnFem";
            this.btnFem.Size = new System.Drawing.Size(99, 25);
            this.btnFem.TabIndex = 11;
            this.btnFem.Text = "Feminino";
            this.btnFem.UseVisualStyleBackColor = true;
            // 
            // btnMasc
            // 
            this.btnMasc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMasc.AutoSize = true;
            this.btnMasc.Checked = true;
            this.btnMasc.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnMasc.Location = new System.Drawing.Point(47, 52);
            this.btnMasc.Name = "btnMasc";
            this.btnMasc.Size = new System.Drawing.Size(112, 25);
            this.btnMasc.TabIndex = 10;
            this.btnMasc.TabStop = true;
            this.btnMasc.Text = "Masculino";
            this.btnMasc.UseVisualStyleBackColor = true;
            // 
            // lbSexo
            // 
            this.lbSexo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(43, 27);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(52, 22);
            this.lbSexo.TabIndex = 127;
            this.lbSexo.Text = "Sexo";
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsReturn = true;
            this.txtEmail.AcceptsTab = true;
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(43, 131);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(283, 31);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(39, 106);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 22);
            this.lbEmail.TabIndex = 121;
            this.lbEmail.Text = "Email";
            // 
            // txtNome
            // 
            this.txtNome.AcceptsReturn = true;
            this.txtNome.AcceptsTab = true;
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(43, 52);
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
            this.lbNome.Location = new System.Drawing.Point(43, 27);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(65, 22);
            this.lbNome.TabIndex = 116;
            this.lbNome.Text = "Nome";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataNasc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDataNasc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataNasc.Location = new System.Drawing.Point(43, 368);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(283, 31);
            this.txtDataNasc.TabIndex = 5;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            this.txtDataNasc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtDataNasc.Leave += new System.EventHandler(this.txtDataNasc_Leave);
            // 
            // lbDataNasc
            // 
            this.lbDataNasc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDataNasc.AutoSize = true;
            this.lbDataNasc.Location = new System.Drawing.Point(39, 343);
            this.lbDataNasc.Name = "lbDataNasc";
            this.lbDataNasc.Size = new System.Drawing.Size(201, 22);
            this.lbDataNasc.TabIndex = 145;
            this.lbDataNasc.Text = "Data de Nascimento";
            // 
            // txtDataCont
            // 
            this.txtDataCont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataCont.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDataCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataCont.Location = new System.Drawing.Point(43, 447);
            this.txtDataCont.Mask = "00/00/0000";
            this.txtDataCont.Name = "txtDataCont";
            this.txtDataCont.Size = new System.Drawing.Size(283, 31);
            this.txtDataCont.TabIndex = 6;
            this.txtDataCont.ValidatingType = typeof(System.DateTime);
            this.txtDataCont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtDataCont.Leave += new System.EventHandler(this.txtDataCont_Leave);
            // 
            // lbDataCont
            // 
            this.lbDataCont.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDataCont.AutoSize = true;
            this.lbDataCont.Location = new System.Drawing.Point(39, 422);
            this.lbDataCont.Name = "lbDataCont";
            this.lbDataCont.Size = new System.Drawing.Size(214, 22);
            this.lbDataCont.TabIndex = 147;
            this.lbDataCont.Text = "Data de Contratação";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Location = new System.Drawing.Point(43, 526);
            this.txtTelefone.Mask = "(99)00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(283, 31);
            this.txtTelefone.TabIndex = 7;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbTelefone
            // 
            this.lbTelefone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(39, 501);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(87, 22);
            this.lbTelefone.TabIndex = 149;
            this.lbTelefone.Text = "Telefone";
            // 
            // txtCargo
            // 
            this.txtCargo.AcceptsReturn = true;
            this.txtCargo.AcceptsTab = true;
            this.txtCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCargo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCargo.Location = new System.Drawing.Point(47, 605);
            this.txtCargo.MaxLength = 60;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(283, 31);
            this.txtCargo.TabIndex = 20;
            this.txtCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnviaComEnter);
            // 
            // lbCargo
            // 
            this.lbCargo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCargo.AutoSize = true;
            this.lbCargo.Location = new System.Drawing.Point(43, 575);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(69, 22);
            this.lbCargo.TabIndex = 151;
            this.lbCargo.Text = "Cargo";
            // 
            // txtSalario
            // 
            this.txtSalario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalario.Location = new System.Drawing.Point(47, 526);
            this.txtSalario.MaxLength = 6;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(283, 31);
            this.txtSalario.TabIndex = 19;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbSalario
            // 
            this.lbSalario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSalario.AutoSize = true;
            this.lbSalario.Location = new System.Drawing.Point(43, 496);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(69, 22);
            this.lbSalario.TabIndex = 153;
            this.lbSalario.Text = "Salário";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(43, 751);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(282, 55);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(670, 22);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(26, 22);
            this.lbId.TabIndex = 154;
            this.lbId.Text = "id";
            this.lbId.Visible = false;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComplemento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.Location = new System.Drawing.Point(47, 447);
            this.txtComplemento.MaxLength = 60;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(283, 31);
            this.txtComplemento.TabIndex = 18;
            this.txtComplemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            // 
            // lbComplemento
            // 
            this.lbComplemento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(43, 417);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(142, 22);
            this.lbComplemento.TabIndex = 156;
            this.lbComplemento.Text = "Complemento";
            // 
            // txtSenha
            // 
            this.txtSenha.AcceptsReturn = true;
            this.txtSenha.AcceptsTab = true;
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Location = new System.Drawing.Point(43, 605);
            this.txtSenha.MaxLength = 60;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(283, 31);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // lbSenha
            // 
            this.lbSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(39, 580);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(68, 22);
            this.lbSenha.TabIndex = 158;
            this.lbSenha.Text = "Senha";
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.AcceptsReturn = true;
            this.txtConfSenha.AcceptsTab = true;
            this.txtConfSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfSenha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtConfSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfSenha.Location = new System.Drawing.Point(43, 684);
            this.txtConfSenha.MaxLength = 60;
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '*';
            this.txtConfSenha.Size = new System.Drawing.Size(283, 31);
            this.txtConfSenha.TabIndex = 9;
            this.txtConfSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MudaComEnter);
            this.txtConfSenha.Leave += new System.EventHandler(this.txtConfSenha_Leave);
            // 
            // lbConfSenha
            // 
            this.lbConfSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbConfSenha.AutoSize = true;
            this.lbConfSenha.Location = new System.Drawing.Point(39, 659);
            this.lbConfSenha.Name = "lbConfSenha";
            this.lbConfSenha.Size = new System.Drawing.Size(163, 22);
            this.lbConfSenha.TabIndex = 160;
            this.lbConfSenha.Text = "Confirmar Senha";
            // 
            // lbForcaSenha
            // 
            this.lbForcaSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbForcaSenha.AutoSize = true;
            this.lbForcaSenha.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForcaSenha.Location = new System.Drawing.Point(267, 639);
            this.lbForcaSenha.Name = "lbForcaSenha";
            this.lbForcaSenha.Size = new System.Drawing.Size(0, 19);
            this.lbForcaSenha.TabIndex = 161;
            // 
            // erroCPF
            // 
            this.erroCPF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.erroCPF.Image = ((System.Drawing.Image)(resources.GetObject("erroCPF.Image")));
            this.erroCPF.Location = new System.Drawing.Point(333, 210);
            this.erroCPF.Name = "erroCPF";
            this.erroCPF.Size = new System.Drawing.Size(31, 31);
            this.erroCPF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erroCPF.TabIndex = 157;
            this.erroCPF.TabStop = false;
            this.toolTip1.SetToolTip(this.erroCPF, "Insira um CPF válido.");
            this.erroCPF.Visible = false;
            // 
            // erroRG
            // 
            this.erroRG.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.erroRG.Image = ((System.Drawing.Image)(resources.GetObject("erroRG.Image")));
            this.erroRG.Location = new System.Drawing.Point(333, 289);
            this.erroRG.Name = "erroRG";
            this.erroRG.Size = new System.Drawing.Size(31, 31);
            this.erroRG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erroRG.TabIndex = 161;
            this.erroRG.TabStop = false;
            this.toolTip1.SetToolTip(this.erroRG, "Insira um RG válido.");
            this.erroRG.Visible = false;
            // 
            // erroDataNasc
            // 
            this.erroDataNasc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.erroDataNasc.Image = ((System.Drawing.Image)(resources.GetObject("erroDataNasc.Image")));
            this.erroDataNasc.Location = new System.Drawing.Point(333, 368);
            this.erroDataNasc.Name = "erroDataNasc";
            this.erroDataNasc.Size = new System.Drawing.Size(31, 31);
            this.erroDataNasc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erroDataNasc.TabIndex = 162;
            this.erroDataNasc.TabStop = false;
            this.toolTip1.SetToolTip(this.erroDataNasc, "Insira uma data de nascimento válida.");
            this.erroDataNasc.Visible = false;
            // 
            // erroDataCont
            // 
            this.erroDataCont.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.erroDataCont.Image = ((System.Drawing.Image)(resources.GetObject("erroDataCont.Image")));
            this.erroDataCont.Location = new System.Drawing.Point(333, 447);
            this.erroDataCont.Name = "erroDataCont";
            this.erroDataCont.Size = new System.Drawing.Size(31, 31);
            this.erroDataCont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erroDataCont.TabIndex = 163;
            this.erroDataCont.TabStop = false;
            this.toolTip1.SetToolTip(this.erroDataCont, "Insira uma data de contratação válida.");
            this.erroDataCont.Visible = false;
            // 
            // erroEmail
            // 
            this.erroEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.erroEmail.Image = ((System.Drawing.Image)(resources.GetObject("erroEmail.Image")));
            this.erroEmail.Location = new System.Drawing.Point(333, 131);
            this.erroEmail.Name = "erroEmail";
            this.erroEmail.Size = new System.Drawing.Size(31, 31);
            this.erroEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erroEmail.TabIndex = 164;
            this.erroEmail.TabStop = false;
            this.toolTip1.SetToolTip(this.erroEmail, "Insira um email válido.");
            this.erroEmail.Visible = false;
            // 
            // erroSenha
            // 
            this.erroSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.erroSenha.Image = ((System.Drawing.Image)(resources.GetObject("erroSenha.Image")));
            this.erroSenha.Location = new System.Drawing.Point(333, 605);
            this.erroSenha.Name = "erroSenha";
            this.erroSenha.Size = new System.Drawing.Size(31, 31);
            this.erroSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erroSenha.TabIndex = 165;
            this.erroSenha.TabStop = false;
            this.toolTip1.SetToolTip(this.erroSenha, "Sua senha precisa ter ao menos 6 caracteres.\r\nAlém disso, ela precisa de uma letr" +
        "a maiuscula, \r\nminuscula e um digito para sua segurança.");
            this.erroSenha.Visible = false;
            // 
            // erroConfSenha
            // 
            this.erroConfSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.erroConfSenha.Image = ((System.Drawing.Image)(resources.GetObject("erroConfSenha.Image")));
            this.erroConfSenha.Location = new System.Drawing.Point(333, 684);
            this.erroConfSenha.Name = "erroConfSenha";
            this.erroConfSenha.Size = new System.Drawing.Size(31, 31);
            this.erroConfSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erroConfSenha.TabIndex = 166;
            this.erroConfSenha.TabStop = false;
            this.toolTip1.SetToolTip(this.erroConfSenha, "As senhas não conferem.");
            this.erroConfSenha.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lbId);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 60);
            this.panel2.TabIndex = 162;
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
            this.lbTitulo.Location = new System.Drawing.Point(61, 10);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(209, 23);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Cadastra Funcionário";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbForcaSenha);
            this.splitContainer1.Panel1.Controls.Add(this.erroConfSenha);
            this.splitContainer1.Panel1.Controls.Add(this.erroSenha);
            this.splitContainer1.Panel1.Controls.Add(this.erroEmail);
            this.splitContainer1.Panel1.Controls.Add(this.erroDataCont);
            this.splitContainer1.Panel1.Controls.Add(this.erroDataNasc);
            this.splitContainer1.Panel1.Controls.Add(this.erroRG);
            this.splitContainer1.Panel1.Controls.Add(this.erroCPF);
            this.splitContainer1.Panel1.Controls.Add(this.txtRG);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel1.Controls.Add(this.txtConfSenha);
            this.splitContainer1.Panel1.Controls.Add(this.txtCPF);
            this.splitContainer1.Panel1.Controls.Add(this.lbRG);
            this.splitContainer1.Panel1.Controls.Add(this.lbCPF);
            this.splitContainer1.Panel1.Controls.Add(this.lbConfSenha);
            this.splitContainer1.Panel1.Controls.Add(this.lbDataNasc);
            this.splitContainer1.Panel1.Controls.Add(this.txtSenha);
            this.splitContainer1.Panel1.Controls.Add(this.txtEmail);
            this.splitContainer1.Panel1.Controls.Add(this.txtDataNasc);
            this.splitContainer1.Panel1.Controls.Add(this.lbEmail);
            this.splitContainer1.Panel1.Controls.Add(this.lbSenha);
            this.splitContainer1.Panel1.Controls.Add(this.txtNome);
            this.splitContainer1.Panel1.Controls.Add(this.lbNome);
            this.splitContainer1.Panel1.Controls.Add(this.lbDataCont);
            this.splitContainer1.Panel1.Controls.Add(this.txtDataCont);
            this.splitContainer1.Panel1.Controls.Add(this.txtTelefone);
            this.splitContainer1.Panel1.Controls.Add(this.lbTelefone);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(40, 0, 10, 10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtSalario);
            this.splitContainer1.Panel2.Controls.Add(this.lbSexo);
            this.splitContainer1.Panel2.Controls.Add(this.btnMasc);
            this.splitContainer1.Panel2.Controls.Add(this.btnEnviar);
            this.splitContainer1.Panel2.Controls.Add(this.btnFem);
            this.splitContainer1.Panel2.Controls.Add(this.lbCEP);
            this.splitContainer1.Panel2.Controls.Add(this.txtComplemento);
            this.splitContainer1.Panel2.Controls.Add(this.lbCargo);
            this.splitContainer1.Panel2.Controls.Add(this.txtCargo);
            this.splitContainer1.Panel2.Controls.Add(this.txtCep);
            this.splitContainer1.Panel2.Controls.Add(this.lbComplemento);
            this.splitContainer1.Panel2.Controls.Add(this.lbNum);
            this.splitContainer1.Panel2.Controls.Add(this.lbRua);
            this.splitContainer1.Panel2.Controls.Add(this.lbBairro);
            this.splitContainer1.Panel2.Controls.Add(this.lbSalario);
            this.splitContainer1.Panel2.Controls.Add(this.txtBairro);
            this.splitContainer1.Panel2.Controls.Add(this.lbEstado);
            this.splitContainer1.Panel2.Controls.Add(this.lbCidade);
            this.splitContainer1.Panel2.Controls.Add(this.txtCidade);
            this.splitContainer1.Panel2.Controls.Add(this.txtNum);
            this.splitContainer1.Panel2.Controls.Add(this.txtRua);
            this.splitContainer1.Panel2.Controls.Add(this.txtEstado);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 40, 10);
            this.splitContainer1.Size = new System.Drawing.Size(754, 834);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.TabIndex = 163;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbDireitos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 894);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(754, 58);
            this.panel3.TabIndex = 164;
            // 
            // CadastraFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CadastraFuncionario";
            this.Size = new System.Drawing.Size(754, 952);
            ((System.ComponentModel.ISupportInitialize)(this.erroCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroRG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroDataNasc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroDataCont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroConfSenha)).EndInit();
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox txtEstado;
        public System.Windows.Forms.TextBox txtRua;
        public System.Windows.Forms.TextBox txtNum;
        public System.Windows.Forms.MaskedTextBox txtRG;
        public System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lbRG;
        private System.Windows.Forms.Label lbCPF;
        public System.Windows.Forms.Button btnEnviar;
        public System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbEstado;
        public System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Label lbNum;
        public System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label lbCEP;
        public System.Windows.Forms.RadioButton btnFem;
        public System.Windows.Forms.RadioButton btnMasc;
        private System.Windows.Forms.Label lbSexo;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        public System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.Label lbDataNasc;
        public System.Windows.Forms.MaskedTextBox txtDataCont;
        private System.Windows.Forms.Label lbDataCont;
        public System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lbTelefone;
        public System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lbCargo;
        public System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lbSalario;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label lbId;
        public System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lbComplemento;
        public System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lbSenha;
        public System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.Label lbConfSenha;
        private System.Windows.Forms.Label lbForcaSenha;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbTitulo;
        public System.Windows.Forms.Label lbDireitos;
        public System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox erroEmail;
        private System.Windows.Forms.PictureBox erroDataCont;
        private System.Windows.Forms.PictureBox erroDataNasc;
        private System.Windows.Forms.PictureBox erroRG;
        private System.Windows.Forms.PictureBox erroCPF;
        private System.Windows.Forms.PictureBox erroSenha;
        private System.Windows.Forms.PictureBox erroConfSenha;
        private System.Windows.Forms.Panel panel3;
    }
}
