using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashShark
{
    public partial class MainForm : Form
    {

        int x, arrastaX, arrastaY;

        public MainForm()
        {
            InitializeComponent();
            menu1.MouseWheel += pnRodaMenu;
            menu1.Home_Click += Home_Click;
            menu1.Sobre_Click += Sobre_Click;
            menu1.UsuCad_Click += UsuCad_Click;
            menu1.UsuEd_Click += UsuEd_Click;
            menu1.FuncCad_Click += FuncCad_Click;
            menu1.FuncEd_Click += FuncEd_Click;
            menu1.FornCad_Click += FornCad_Click;
            menu1.FornEd_Click += FornEd_Click;
            menu1.ProdCad_Click += ProdCad_Click;
            menu1.ProdEd_Click += ProdEd_Click;
            menu1.CliPed_Click += CliPed_Click;
            menu1.FunCar_Click += FunCar_Click;
            menu1.FunSal_Click += FunSal_Click;
            menu1.ForCom_Click += ForCom_Click;
            menu1.HistPed_Click += HistPed_Click;
            menu1.HistComp_Click += HistComp_Click;
            visualizaCliente1.EditaCli += editaCliente;
            visualizaFornecedor1.EditaForn += editaFornecedor;
            visualizaFuncionario1.EditaFunc += editaFuncionario;
            visualizaProduto1.EditaProd += editaProduto;
        }


        //
        // Editas
        //

        CadastraCliente frmCli = new CadastraCliente();
        private void editaCliente(object sender, EventArgs e)
        {
            frmCli = sender as CadastraCliente;
            frmCli.btnEnviar.Click -= frmCli.btnEnviar_Click;
            frmCli.btnEnviar.Click += ConfirmaEditarCliente;
            frmCli.btnCancelar.Click += CancelaEditarCliente;
            frmCli.AutoScroll = true;
            frmCli.btnPFisica.Enabled = false;
            frmCli.btnPJuridica.Enabled = false;
            frmCli.Parent = splitContainerContent.Panel2;
            frmCli.Dock = DockStyle.Fill;
            splitPrincipal.Panel2.Controls.Add(frmCli);
            frmCli.BringToFront();
        }

        private void CancelaEditarCliente(object sender, EventArgs e)
        {
            splitPrincipal.Panel2.Controls.Remove(frmCli);
        }

        private void ConfirmaEditarCliente(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            PessoaFisica pf = new PessoaFisica();
            PessoaJuridica pj = new PessoaJuridica();
            try
            {
                if (frmCli.btnPFisica.Checked && (frmCli.txtRG.Text.Contains(' ') || frmCli.txtCPF.Text.Contains(' ') || frmCli.txtEmail.Text == "" || frmCli.txtNome.Text == "" || frmCli.txtTelefone.Text.Contains(' ') || frmCli.txtRua.Text == "" || frmCli.txtBairro.Text == "" || frmCli.txtCep.Text.Contains(' ') || frmCli.txtCidade.Text == "" || frmCli.txtNum.Text == "" || frmCli.txtEstado.SelectedItem.ToString() == ""))
                    MessageBox.Show("Preencha todos os campos!");
                else if (frmCli.btnPJuridica.Checked && (frmCli.txtNome.Text == "" || frmCli.txtCNPJ.Text.Contains(' ') || frmCli.txtRazaoSocial.Text == "" || frmCli.txtInscEstadual.Text.Contains(' ') || frmCli.txtTelefone.Text.Contains(' ') || frmCli.txtRua.Text == "" || frmCli.txtBairro.Text == "" || frmCli.txtCep.Text.Contains(' ') || frmCli.txtCidade.Text == "" || frmCli.txtNum.Text == "" || frmCli.txtEstado.SelectedItem.ToString() == ""))
                    MessageBox.Show("Preencha todos os campos!");
                else
                {
                    bool vEmail = Validacoes.ValidaEmail(frmCli.txtEmail.Text);
                    if (vEmail)
                    {
                        cli.Nome = frmCli.txtNome.Text;
                        cli.Email = frmCli.txtEmail.Text;
                        cli.Telefone = frmCli.txtTelefone.Text;
                        cli.Logradouro = frmCli.txtRua.Text;
                        cli.Bairro = frmCli.txtBairro.Text;
                        cli.Uf = frmCli.txtEstado.SelectedItem.ToString();
                        cli.Cidade = frmCli.txtCidade.Text;
                        cli.Cep = frmCli.txtCep.Text;
                        cli.Numero = frmCli.txtNum.Text;
                        cli.Complemento = frmCli.txtComplemento.Text;
                        cli.Atualizar(int.Parse(frmCli.lbId.Text));
                        if (frmCli.btnPFisica.Checked)
                        {
                            pf.Nome = frmCli.txtNome.Text;
                            pf.Cpf = frmCli.txtCPF.Text;
                            pf.CarteiraIdentidade = frmCli.txtRG.Text;
                            pf.AtualizarPF(int.Parse(frmCli.lbId.Text));
                        }
                        else
                        {
                            pj.RazaoSocial = frmCli.txtRazaoSocial.Text;
                            pj.Cnpj = frmCli.txtCNPJ.Text;
                            pj.InscricaoEstadual = frmCli.txtInscEstadual.Text;
                            pj.AtualizarPJ(int.Parse(frmCli.lbId.Text));
                        }
                        splitPrincipal.Panel2.Controls.Remove(frmCli);
                        visualizaCliente1.recarrega();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao inserir.");
           }
        }
        
        CadastraFornecedor frmForn = new CadastraFornecedor();
        private void editaFornecedor(object sender, EventArgs e)
        {
            frmForn = sender as CadastraFornecedor;
            frmForn.btnEnviar.Click -= frmForn.btnEnviar_Click;
            frmForn.btnEnviar.Click += ConfirmaEditarFornecedor;
            frmForn.btnCancelar.Click += CancelaEditarFornecedor;
            frmForn.AutoScroll = true;
            frmForn.Parent = splitContainerContent.Panel2;
            frmForn.Dock = DockStyle.Fill;
            splitPrincipal.Panel2.Controls.Add(frmForn);
            frmForn.BringToFront();
        }

        private void CancelaEditarFornecedor(object sender, EventArgs e)
        {
            splitPrincipal.Panel2.Controls.Remove(frmForn);
        }

        private void ConfirmaEditarFornecedor(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();
            EspecificacaoFornecedor espForn = new EspecificacaoFornecedor();
            try
            {
                if (frmForn.txtNome.Text == "" || frmForn.txtEmail.Text == "" || frmForn.txtPseudonimo.Text.Contains(' ') || frmForn.txtCNPJ.Text.Contains(' ') || frmForn.txtInscEstadual.Text.Contains(' ') || frmForn.txtRua.Text == "" || frmForn.txtBairro.Text == "" || frmForn.txtCep.Text.Contains(' ') || frmForn.txtCidade.Text == "" || frmForn.txtNum.Text == "" || frmForn.txtEstado.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    bool vEmail = Validacoes.ValidaEmail(frmForn.txtEmail.Text);
                    if (vEmail)
                    {
                        int id = int.Parse(frmForn.lbId.Text);
                        forn.Nome = frmForn.txtNome.Text;
                        forn.Email = frmForn.txtEmail.Text;
                        espForn.Pseudonimo = frmForn.txtPseudonimo.Text;
                        forn.Cnpj = frmForn.txtCNPJ.Text;
                        forn.InscricaoEstadual = frmForn.txtInscEstadual.Text;
                        forn.Bairro = frmForn.txtBairro.Text;
                        forn.Uf = frmForn.txtEstado.SelectedItem.ToString();
                        forn.Cidade = frmForn.txtCidade.Text;
                        forn.Cep = frmForn.txtCep.Text;
                        forn.Numero = frmForn.txtNum.Text;
                        forn.Complemento = frmForn.txtComplemento.Text;
                        forn.Atualizar(id);
                        espForn.Atualizar(id);

                        splitPrincipal.Panel2.Controls.Remove(frmForn);
           
                        visualizaFornecedor1.recarrega();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao alterar!");
            }
        }

        CadastraFuncionario frmFunc = new CadastraFuncionario();
        private void editaFuncionario(object sender, EventArgs e)
        {
            frmFunc = sender as CadastraFuncionario;
            frmFunc.btnEnviar.Click -= frmFunc.btnEnviar_Click;
            frmFunc.btnEnviar.Click += ConfirmaEditarFuncionario;
            frmFunc.btnCancelar.Click += CancelaEditarFuncionario;
            frmFunc.AutoScroll = true;
            frmFunc.Parent = splitContainerContent.Panel2;
            frmFunc.Dock = DockStyle.Fill;
            splitPrincipal.Panel2.Controls.Add(frmFunc);
            frmFunc.BringToFront();
        }

        private void CancelaEditarFuncionario(object sender, EventArgs e)
        {
            splitPrincipal.Panel2.Controls.Remove(frmFunc);
        }

        private void ConfirmaEditarFuncionario(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();
            try
            {
                if (frmFunc.txtDataCont.Text.Contains(' ') || frmFunc.txtDataNasc.Text.Contains(' ') || frmFunc.txtNome.Text == "" || frmFunc.txtTelefone.Text.Contains(' ') || frmFunc.txtCPF.Text.Contains(' ') || frmFunc.txtRG.Text.Contains(' ') || frmFunc.txtRua.Text == "" || frmFunc.txtBairro.Text == "" || frmFunc.txtCep.Text.Contains(' ') || frmFunc.txtCidade.Text == "" || frmFunc.txtNum.Text == "" || frmFunc.txtEstado.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {

                    bool v2 = Validacoes.ValidaData(frmFunc.txtDataNasc.Text);
                    bool v1 = Validacoes.ValidaData(frmFunc.txtDataCont.Text);
                    bool vEmail = Validacoes.ValidaEmail(frmFunc.txtEmail.Text);
                    if (v1 && v2 && vEmail)
                    {
                        string[] contraAntes = frmFunc.txtDataCont.Text.Split('/');
                        string[] nascAntes = frmFunc.txtDataNasc.Text.Split('/');

                        string contra = contraAntes[2] + '-' + contraAntes[1] + '-' + contraAntes[0];
                        string nasc = nascAntes[2] + '-' + nascAntes[1] + '-' + nascAntes[0];

                        func.Id_func = int.Parse(frmFunc.lbId.Text);
                        func.Nome = frmFunc.txtNome.Text;
                        func.Email = frmFunc.txtEmail.Text;
                        func.Telefone = frmFunc.txtTelefone.Text;
                        func.Data_cont = contra;
                        func.Data_nasc = nasc;
                        func.Sexo = frmFunc.btnFem.Checked ? 'F' : 'M';
                        func.Cpf = frmFunc.txtCPF.Text;
                        func.Rg = frmFunc.txtRG.Text;
                        func.Logradouro = frmFunc.txtRua.Text;
                        func.Bairro = frmFunc.txtBairro.Text;
                        func.Uf = frmFunc.txtEstado.SelectedItem.ToString();
                        func.Cidade = frmFunc.txtCidade.Text;
                        func.Cep = frmFunc.txtCep.Text;
                        func.Numero = frmFunc.txtNum.Text;
                        func.Complemento = frmFunc.txtComplemento.Text;
                        func.Senha = frmFunc.txtSenha.Text;
                        func.Nome_cargo = frmFunc.txtCargo.Text;
                        func.Editar();

                        splitPrincipal.Panel2.Controls.Remove(frmFunc);
           
                        visualizaFuncionario1.recarrega();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar!" + ex);
            }
        }

        CadastraProduto frmProd = new CadastraProduto();
        private void editaProduto(object sender, EventArgs e)
        {
            frmProd = sender as CadastraProduto;
            frmProd.btnEnviar.Click -= frmProd.btnEnviar_Click;
            frmProd.btnEnviar.Click += ConfirmaEditarProduto;
            frmProd.btnCancelar.Click += CancelaEditarProduto;
            frmProd.AutoScroll = true;
            frmProd.Parent = splitContainerContent.Panel2;
            frmProd.Dock = DockStyle.Fill;
            splitPrincipal.Panel2.Controls.Add(frmProd);
            frmProd.BringToFront();
        }

        private void CancelaEditarProduto(object sender, EventArgs e)
        {
            splitPrincipal.Panel2.Controls.Remove(frmProd);
        }

        private void ConfirmaEditarProduto(object sender, EventArgs e)
        {
            Produto prod = new Produto();
            try
            {
                if (frmProd.txtNome.Text == "" || frmProd.txtDescricao.Text == "" || frmProd.txtMarca.Text == "" || frmProd.txtModelo.Text == "" || frmProd.txtCor.Text == "" || frmProd.txtPreco.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    int id = int.Parse(frmProd.lbId.Text);
                    string data = DateTime.Now.ToShortDateString();
                    string[] hojeAntes = data.Split('/');
                    string hoje = hojeAntes[2] + '-' + hojeAntes[1] + '-' + hojeAntes[0];
                    prod.Nome = frmProd.txtNome.Text;
                    prod.Descricao = frmProd.txtDescricao.Text;
                    prod.MarcaImpressora = frmProd.txtMarca.Text;
                    prod.UltimaAtualizacao = hoje;
                    prod.Modelo = frmProd.txtModelo.Text;
                    prod.Cor = frmProd.txtCor.Text;
                    prod.Preco = frmProd.txtPreco.Text;

                    prod.Atualizar(id);
                    visualizaProduto1.recarrega();

                    splitPrincipal.Panel2.Controls.Remove(frmProd);
       
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar!" + ex);
            }
        }

        //
        // Botões do menu
        //

        private void Home_Click(object sender, EventArgs e)
        {
            menu1.pnLateral.Parent = menu1;
            menu1.pnLateral.Top = menu1.btnHome.Top;
            menu1.pnLateral.BringToFront();
            home1.BringToFront();
        }

        private void Sobre_Click(object sender, EventArgs e)
        {
            menu1.pnLateral.Parent = menu1;
            menu1.pnLateral.Top = menu1.btnSobre.Top;
            menu1.pnLateral.BringToFront();
            sobre1.BringToFront();
        }

        private void UsuCad_Click(object sender, EventArgs e)
        {
            menu1.pnLateral.Parent = menu1.pnCli;
            menu1.pnLateral.Top = menu1.btnCliCad.Top;
            menu1.pnLateral.BringToFront();
            cadastraCliente1.BringToFront();
        }

        private void UsuEd_Click(object sender, EventArgs e)
        {
            menu1.pnLateral.Parent = menu1.pnCli;
            menu1.pnLateral.Top = menu1.btnCliEdi.Top;
            menu1.pnLateral.BringToFront();
            visualizaCliente1.BringToFront();
            visualizaCliente1.recarrega();
        }

        private void CliPed_Click(object sender, EventArgs e)
        {
            menu1.pnLateral.Parent = menu1.pnCli;
            menu1.pnLateral.Top = menu1.btnCliPed.Top;
            menu1.pnLateral.BringToFront();
            pedido1.BringToFront();
            pedido1.recarrega();
        }

        private void FuncCad_Click(object sender, EventArgs e)
        {
            menu1.pnLateral.Parent = menu1.pnFunc;
            menu1.pnLateral.Top = menu1.btnFunCad.Top;
            menu1.pnLateral.BringToFront();
            cadastraFuncionario1.BringToFront();
        }

        private void FuncEd_Click(object sender, EventArgs e)
        {
            menu1.pnLateral.Parent = menu1.pnFunc;
            menu1.pnLateral.Top = menu1.btnFunEdi.Top;
            menu1.pnLateral.BringToFront();
            visualizaFuncionario1.BringToFront();
            visualizaFuncionario1.recarrega();
        }

        private void FunCar_Click(object sender, EventArgs e)
        {
            menu1.pnLateral.Parent = menu1.pnFunc;
            menu1.pnLateral.Top = menu1.btnFunCar.Top;
            menu1.pnLateral.BringToFront();
            atualizaCargo1.BringToFront();
            atualizaCargo1.recarrega();
        }

        private void FunSal_Click(object sender, EventArgs e)
        {
            menu1.pnLateral.Parent = menu1.pnFunc;
            menu1.pnLateral.Top = menu1.btnFunSal.Top;
            menu1.pnLateral.BringToFront();
            atualizaSalario1.BringToFront();
            atualizaSalario1.recarrega();
        }

        private void FornCad_Click(object sender, EventArgs e)
        {
            menu1.pnLateral.Parent = menu1.pnForn;
            menu1.pnLateral.Top = menu1.btnForCad.Top;
            menu1.pnLateral.BringToFront();
            cadastraFornecedor1.BringToFront();
        }

        private void FornEd_Click(object sender, EventArgs e)
        {
            menu1.pnLateral.Parent = menu1.pnForn;
            menu1.pnLateral.Top = menu1.btnForEdi.Top;
            menu1.pnLateral.BringToFront();
            visualizaFornecedor1.BringToFront();
            visualizaFornecedor1.recarrega();
        }

        private void ForCom_Click(object sender, EventArgs e)
        {
            menu1.pnLateral.Parent = menu1.pnForn;
            menu1.pnLateral.Top = menu1.btnForCom.Top;
            menu1.pnLateral.BringToFront();
            compra1.BringToFront();
            compra1.recarrega();
        }

        private void ProdCad_Click(object sender, EventArgs e)
        {
            menu1.pnLateral.Parent = menu1.pnProd;
            menu1.pnLateral.Top = menu1.btnProCad.Top;
            menu1.pnLateral.BringToFront();
            cadastraProduto1.BringToFront();
        }

        private void ProdEd_Click(object sender, EventArgs e)
        {
            menu1.pnLateral.Parent = menu1.pnProd;
            menu1.pnLateral.Top = menu1.btnProEdi.Top;
            menu1.pnLateral.BringToFront();
            visualizaProduto1.BringToFront();
            visualizaProduto1.recarrega();
        }
        private void HistPed_Click(object sender, EventArgs e)
        {
            menu1.pnLateral.Parent = menu1.pnHist;
            menu1.pnLateral.Top = menu1.btnHistPed.Top;
            menu1.pnLateral.BringToFront();
            historicoPedido1.BringToFront();
            historicoPedido1.Recarrega();
        }
        private void HistComp_Click(object sender, EventArgs e)
        {
            menu1.pnLateral.Parent = menu1.pnHist;
            menu1.pnLateral.Top = menu1.btnHistComp.Top;
            menu1.pnLateral.BringToFront();
            historicoCompra1.BringToFront();
            historicoCompra1.Recarrega();
        }
        //
        // Barra superior
        //

        private void splitContainer1_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = arrastaX + MousePosition.X;
            this.Top = arrastaY + MousePosition.Y;
        }

        private void splitContainer1_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            arrastaX = this.Left - MousePosition.X;
            arrastaY = this.Top - MousePosition.Y;
        }

        private void pnRodaMenu(object sender, MouseEventArgs e)
        {
            if (e.Delta == -120 && menu1.Height + menu1.Top > this.Height)
                x -= 35;
            else if (e.Delta == 120 && menu1.Top < -10)
                x += 35;
            menu1.Top = x;
        }

        private void btnDesliga_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(("Tem certeza que deseja sair?"), "Sair do Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Backup bkp = new Backup();
            bkp.ShowDialog();
        }

        private void btnMaximiza_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                home1.panel3.Padding = new Padding(10, 5, 10, 0);
                sobre1.panel3.Padding = new Padding(10, 5, 10, 0);

                cadastraCliente1.splitContainer1.Panel1.Padding = new Padding(40, 0, 10, 0);
                cadastraCliente1.splitContainer1.Panel2.Padding = new Padding(10, 0, 40, 0);
                cadastraCliente1.lbDireitos.Left = splitContainerContent.Panel2.Width / 2 - 188;
                frmCli.splitContainer1.Panel1.Padding = new Padding(50, 10, 10, 10);
                frmCli.splitContainer1.Panel2.Padding = new Padding(10, 10, 50, 10);
                frmCli.lbDireitos.Left = splitContainerContent.Panel2.Width / 2 - 188;

                cadastraFornecedor1.splitContainer1.Panel1.Padding = new Padding(40, 0, 10, 0);
                cadastraFornecedor1.splitContainer1.Panel2.Padding = new Padding(10, 0, 40, 0);
                cadastraFornecedor1.lbDireitos.Left = splitContainerContent.Panel2.Width / 2 - 188;
                frmForn.splitContainer1.Panel1.Padding = new Padding(50, 10, 10, 10);
                frmForn.splitContainer1.Panel2.Padding = new Padding(10, 10, 50, 10);
                frmForn.lbDireitos.Left = splitContainerContent.Panel2.Width / 2 - 188;

                cadastraFuncionario1.splitContainer1.Panel1.Padding = new Padding(40, 0, 10, 0);
                cadastraFuncionario1.splitContainer1.Panel2.Padding = new Padding(10, 0, 40, 0);
                cadastraFuncionario1.lbDireitos.Left = splitContainerContent.Panel2.Width / 2 - 188;
                frmFunc.splitContainer1.Panel1.Padding = new Padding(50, 10, 10, 10);
                frmFunc.splitContainer1.Panel2.Padding = new Padding(10, 10, 50, 10);
                frmFunc.lbDireitos.Left = splitContainerContent.Panel2.Width / 2 - 188;

                cadastraProduto1.splitContainer1.Panel1.Padding = new Padding(40, 0, 10, 0);
                cadastraProduto1.splitContainer1.Panel2.Padding = new Padding(10, 0, 40, 0);
                cadastraProduto1.lbDireitos.Left = splitContainerContent.Panel2.Width / 2 - 188;
                frmProd.splitContainer1.Panel1.Padding = new Padding(50, 10, 10, 10);
                frmProd.splitContainer1.Panel2.Padding = new Padding(10, 10, 50, 10);
                frmProd.lbDireitos.Left = splitContainerContent.Panel2.Width / 2 - 188;

                visualizaCliente1.panel4.Height = 275;
                visualizaFornecedor1.panel4.Height = 275;
                visualizaFuncionario1.panel4.Height = 275;
                visualizaProduto1.panel4.Height = 275;

                pedido1.splitContainer1.Height = 333;

                pedido1.lbCPFCli.Top -= 30;
                pedido1.lbNomeCliente.Top -= 60;
                pedido1.lbCodProd.Top -= 90;
                pedido1.lbNomeProd.Top -= 120;
                pedido1.lbQuantidade.Top -= 150;
                pedido1.txtCPFCli.Top -= 30;
                pedido1.txtNomeCli.Top -= 60;
                pedido1.txtCodProd.Top -= 90;
                pedido1.txtNomeProd.Top -= 120;
                pedido1.txtQuantidade.Top -= 150;

                compra1.splitContainer1.Height = 333;
                compra1.lbCNPJForn.Top -= 30;
                compra1.lbNomeCliente.Top -= 60;
                compra1.lbCodProd.Top -= 90;
                compra1.lbNomeProd.Top -= 120;
                compra1.lbQuantidade.Top -= 150;
                compra1.txtCNPJCod.Top -= 30;
                compra1.txtNomeForn.Top -= 60;
                compra1.txtCodProd.Top -= 90;
                compra1.txtNomeProd.Top -= 120;
                compra1.txtQuantidade.Top -= 150;

                home1.richTextBox1.Font = new Font(home1.richTextBox1.Font.FontFamily, 12);

                atualizaCargo1.splitContainer1.Height = 340;
                atualizaCargo1.splitContainer1.Panel1.Padding = new Padding(0, 0, 0, 0);
                atualizaCargo1.splitContainer1.Panel2.Padding = new Padding(0, 0, 0, 0);

                atualizaSalario1.splitContainer1.Height = 340;
                atualizaSalario1.splitContainer1.Panel1.Padding = new Padding(0, 0, 0, 0);
                atualizaSalario1.splitContainer1.Panel2.Padding = new Padding(0, 0, 0, 0);
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                home1.panel3.Padding = new Padding(splitContainerContent.Panel2.Width/10, splitContainerContent.Panel2.Height / 10, splitContainerContent.Panel2.Width / 10, 10);
                sobre1.panel3.Padding = new Padding(splitContainerContent.Panel2.Width / 10, 20, splitContainerContent.Panel2.Width / 10, 10);

                cadastraCliente1.splitContainer1.Panel1.Padding = new Padding(splitContainerContent.Panel2.Width / 10, 50, 20, 0);
                cadastraCliente1.splitContainer1.Panel2.Padding = new Padding(20, 50, splitContainerContent.Panel2.Width / 10, 0);
                cadastraCliente1.lbDireitos.Left = splitContainerContent.Panel2.Width / 2 - 188;
                frmCli.splitContainer1.Panel1.Padding = new Padding(splitContainerContent.Panel2.Width / 10, 50, 20, 0);
                frmCli.splitContainer1.Panel2.Padding = new Padding(20, 50, splitContainerContent.Panel2.Width / 10, 0);
                frmCli.lbDireitos.Left = splitContainerContent.Panel2.Width / 2 - 188;

                cadastraFornecedor1.splitContainer1.Panel1.Padding = new Padding(splitContainerContent.Panel2.Width / 10, 50, 20, 0);
                cadastraFornecedor1.splitContainer1.Panel2.Padding = new Padding(20, 50, splitContainerContent.Panel2.Width / 10, 0);
                cadastraFornecedor1.lbDireitos.Left = splitContainerContent.Panel2.Width / 2 - 188;
                frmForn.splitContainer1.Panel1.Padding = new Padding(splitContainerContent.Panel2.Width / 10, 50, 20, 0);
                frmForn.splitContainer1.Panel2.Padding = new Padding(20, 50, splitContainerContent.Panel2.Width / 10, 0);
                frmForn.lbDireitos.Left = splitContainerContent.Panel2.Width / 2 - 188;

                cadastraFuncionario1.splitContainer1.Panel1.Padding = new Padding(splitContainerContent.Panel2.Width / 10, 50, 20, 0);
                cadastraFuncionario1.splitContainer1.Panel2.Padding = new Padding(20, 50, splitContainerContent.Panel2.Width / 10, 0);
                cadastraFuncionario1.lbDireitos.Left = splitContainerContent.Panel2.Width / 2 - 188;
                frmFunc.splitContainer1.Panel1.Padding = new Padding(splitContainerContent.Panel2.Width / 10, 50, 20, 0);
                frmFunc.splitContainer1.Panel2.Padding = new Padding(20, 50, splitContainerContent.Panel2.Width / 10, 0);
                frmFunc.lbDireitos.Left = splitContainerContent.Panel2.Width / 2 - 188;

                cadastraProduto1.splitContainer1.Panel1.Padding = new Padding(splitContainerContent.Panel2.Width / 10, 50, 20, 0);
                cadastraProduto1.splitContainer1.Panel2.Padding = new Padding(20, 50, splitContainerContent.Panel2.Width / 10, 0);
                cadastraProduto1.lbDireitos.Left = splitContainerContent.Panel2.Width / 2 - 188;
                frmProd.splitContainer1.Panel1.Padding = new Padding(splitContainerContent.Panel2.Width / 10, 50, 20, 0);
                frmProd.splitContainer1.Panel2.Padding = new Padding(20, 50, splitContainerContent.Panel2.Width / 10, 0);
                frmProd.lbDireitos.Left = splitContainerContent.Panel2.Width / 2 - 188;

                visualizaCliente1.panel4.Height = (int) (splitContainerContent.Panel2.Height * 0.65);
                visualizaFornecedor1.panel4.Height = (int)(splitContainerContent.Panel2.Height * 0.65);
                visualizaFuncionario1.panel4.Height = (int)(splitContainerContent.Panel2.Height * 0.65);
                visualizaProduto1.panel4.Height = (int)(splitContainerContent.Panel2.Height * 0.65);

                pedido1.splitContainer1.Height = (int)(splitContainerContent.Panel2.Height * 0.65);
                pedido1.lbCPFCli.Top += 30;
                pedido1.lbNomeCliente.Top += 60;
                pedido1.lbCodProd.Top += 90;
                pedido1.lbNomeProd.Top += 120;
                pedido1.lbQuantidade.Top += 150;
                pedido1.txtCPFCli.Top += 30;
                pedido1.txtNomeCli.Top += 60;
                pedido1.txtCodProd.Top += 90;
                pedido1.txtNomeProd.Top += 120;
                pedido1.txtQuantidade.Top += 150;

                compra1.splitContainer1.Height = (int)(splitContainerContent.Panel2.Height * 0.65);
                compra1.lbCNPJForn.Top += 30;
                compra1.lbNomeCliente.Top += 60;
                compra1.lbCodProd.Top += 90;
                compra1.lbNomeProd.Top += 120;
                compra1.lbQuantidade.Top += 150;
                compra1.txtCNPJCod.Top += 30;
                compra1.txtNomeForn.Top += 60;
                compra1.txtCodProd.Top += 90;
                compra1.txtNomeProd.Top += 120;
                compra1.txtQuantidade.Top += 150;

                home1.richTextBox1.Font = new Font(home1.richTextBox1.Font.FontFamily, 16);

                atualizaCargo1.splitContainer1.Height = (int)(splitContainerContent.Panel2.Height * 0.65);
                atualizaCargo1.splitContainer1.Panel1.Padding = new Padding(50, 100, 50, 0);
                atualizaCargo1.splitContainer1.Panel2.Padding = new Padding(50, 100, 50, 0);

                atualizaSalario1.splitContainer1.Height = (int)(splitContainerContent.Panel2.Height * 0.65);
                atualizaSalario1.splitContainer1.Panel1.Padding = new Padding(50, 100, 50, 0);
                atualizaSalario1.splitContainer1.Panel2.Padding = new Padding(50, 100, 50, 0);
            }
        }

        private void splitPrincipal_Panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnMaximiza.PerformClick();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://splashshark.epizy.com");
        }

        private void btnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
