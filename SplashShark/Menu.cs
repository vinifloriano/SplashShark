using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashShark
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
            Recolher();
        }

        public event EventHandler Home_Click, Sobre_Click, UsuCad_Click, UsuEd_Click, FuncCad_Click, FuncEd_Click, FornCad_Click, FornEd_Click, ProdCad_Click, ProdEd_Click, CliPed_Click, FunCar_Click, FunSal_Click, ForCom_Click, HistPed_Click, HistComp_Click;
        internal int i, h, c = 0;
        int[] h1 = new int[5];
        Panel p;
        internal bool recolher_usu = true, recolher_forn = true, recolher_func = true, recolher_prod = true, recolher_hist = true;

        private void Recolher()
        {
            h1[0] = pnCli.Height;
            h1[1] = pnFunc.Height;
            h1[2] = pnForn.Height;
            h1[3] = pnProd.Height;
            h1[4] = pnHist.Height;

            pnCli.Height = 0;
            pnFunc.Height = 0;
            pnForn.Height = 0;
            pnProd.Height = 0;
            pnHist.Height = 0;

            btnFuncionario.Top -= h1[0] + 9;
            pnFunc.Top -= h1[0] + 9;
            btnFornecedor.Top -= h1[0] + h1[1] + 21;
            pnForn.Top -= h1[0] + h1[1] + 21;
            btnProduto.Top -= h1[0] + h1[1] + h1[2] + 31;
            pnProd.Top -= h1[0] + h1[1] + h1[2] + 31;
            btnHistorico.Top -= h1[0] + h1[1] + h1[2] + h1[3] + 37;
            pnHist.Top -= h1[0] + h1[1] + h1[2] + h1[3] + 37;
        }

        private void btnHistComp_Click(object sender, EventArgs e)
        {
            EventHandler handler = HistComp_Click;
            handler?.Invoke(this, e);
        }

        private void btnHistPed_Click(object sender, EventArgs e)
        {
            EventHandler handler = HistPed_Click;
            handler?.Invoke(this, e);
        }

        private void btnForCom_Click(object sender, EventArgs e)
        {
            EventHandler handler = ForCom_Click;
            handler?.Invoke(this, e);
        }

        private void btnCliPed_Click(object sender, EventArgs e)
        {
            EventHandler handler = CliPed_Click;
            handler?.Invoke(this, e);
        }

        private void btnFunCar_Click(object sender, EventArgs e)
        {
            EventHandler handler = FunCar_Click;
            handler?.Invoke(this, e);
        }

        private void btnFunSal_Click(object sender, EventArgs e)
        {
            EventHandler handler = FunSal_Click;
            handler?.Invoke(this, e);
        }

        private void PnRecolher1(object sender, EventArgs e)
        {
            i = 0;
            if (!recolher_usu)
            {
                recolher_usu = true;
                h1[0] = pnCli.Height;
            }
            else
                recolher_usu = false;
            h = h1[0];
            p = pnCli;
            btnCliente.Enabled = false;
            timer1.Enabled = true;
        }

        private void PnRecolher2(object sender, EventArgs e)
        {
            i = 0;
            if (!recolher_func)
            {
                recolher_func = true;
                h1[1] = pnFunc.Height;
            }
            else
                recolher_func = false;
            h = h1[1];
            p = pnFunc;
            btnFuncionario.Enabled = false;
            timer1.Enabled = true;
        }

        private void PnRecolher3(object sender, EventArgs e)
        {
            i = 0;
            if (!recolher_forn)
            {
                recolher_forn = true;
                h1[2] = pnForn.Height;
            }
            else
                recolher_forn = false;
            h = h1[2];
            p = pnForn;
            btnFornecedor.Enabled = false;
            timer1.Enabled = true;
        }

        private void PnRecolher4(object sender, EventArgs e)
        {
            i = 0;
            if (!recolher_prod)
            {
                recolher_prod = true;
                h1[3] = pnProd.Height;
            }
            else
                recolher_prod = false;
            h = h1[3];
            p = pnProd;
            btnProduto.Enabled = false;
            timer1.Enabled = true;
        }

        private void PnRecolher5(object sender, EventArgs e)
        {
            i = 0;
            if (!recolher_hist)
            {
                recolher_hist = true;
                h1[4] = pnHist.Height;
            }
            else
                recolher_hist = false;
            h = h1[4];
            p = pnHist;
            btnHistorico.Enabled = false;
            timer1.Enabled = true;
        }

        private void btnProCad_Click(object sender, EventArgs e)
        {
            EventHandler handler = ProdCad_Click;
            handler?.Invoke(this, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Panel[] dropdown = { pnFunc, pnForn, pnProd, pnHist };
            Button[] dropdown1 = { btnFuncionario, btnFornecedor, btnProduto, btnHistorico };
            i++;
            if (p == pnForn && recolher_forn || p == pnCli && recolher_usu || p == pnFunc && recolher_func || p == pnProd && recolher_prod || p == pnHist && recolher_hist)
            {
                p.Height = Convert.ToInt32(h - 50 * (h / 1000d) * i);
                
                int q = 0;
                switch (p.Name)
                {
                    case "pnCli":
                        q = 0;
                        this.Height -= 10;
                        break;
                    case "pnFunc":
                        q = 1;
                        this.Height -= 10;
                        break;
                    case "pnForn":
                        q = 2;
                        this.Height -= 10;
                        break;
                    case "pnProd":
                        q = 3;
                        this.Height -= 10;
                        break;
                    case "pnHist":
                        q = 4;
                        break;
                }
                for (int j = q; j < dropdown.Length; j++)
                {
                    dropdown[j].Top = Convert.ToInt32(dropdown[j].Top - 5 * (h / 1000d * i));
                    dropdown1[j].Top = Convert.ToInt32(dropdown1[j].Top - 5 * (h / 1000d * i));
                }
                if (p.Height == 0)
                {
                    btnCliente.Enabled = true;
                    btnFornecedor.Enabled = true;
                    btnFuncionario.Enabled = true;
                    btnProduto.Enabled = true;
                    btnHistorico.Enabled = true;
                    timer1.Enabled = false;
                    p = null;
                }
            }
            else if (p == pnForn && !recolher_forn || p == pnCli && !recolher_usu || p == pnFunc && !recolher_func || p == pnProd && !recolher_prod || p == pnHist && !recolher_hist)
            {
                p.Height = Convert.ToInt32(50 * (h / 1000d) * i);
                
                int q = 0;
                switch (p.Name)
                {
                    case "pnCli":
                        q = 0;
                        this.Height += 10;
                        break;
                    case "pnFunc":
                        q = 1;
                        this.Height += 10;
                        break;
                    case "pnForn":
                        q = 2;
                        this.Height += 10;
                        break;
                    case "pnProd":
                        q = 3;
                        this.Height += 10;
                        break;
                    case "pnHist":
                        q = 4;
                        break;
                }
                for (int j = q; j < dropdown.Length; j++)
                {
                    dropdown[j].Top = Convert.ToInt32(dropdown[j].Top + 5 * (h / 1000d * i));
                    dropdown1[j].Top = Convert.ToInt32(dropdown1[j].Top + 5 * (h / 1000d * i));
                }
                if (p.Height >= h)
                {
                    btnCliente.Enabled = true;
                    btnFornecedor.Enabled = true;
                    btnFuncionario.Enabled = true;
                    btnProduto.Enabled = true;
                    btnHistorico.Enabled = true;
                    timer1.Enabled = false;
                    p = null;
                }
            }
        }

        private void btnProEdi_Click(object sender, EventArgs e)
        {
            EventHandler handler = ProdEd_Click;
            handler?.Invoke(this, e);
        }

        private void btnForEdi_Click(object sender, EventArgs e)
        {
            EventHandler handler = FornEd_Click;
            handler?.Invoke(this, e);
        }

        private void btnForCad_Click(object sender, EventArgs e)
        {
            EventHandler handler = FornCad_Click;
            handler?.Invoke(this, e);
        }

        private void btnFunEdi_Click(object sender, EventArgs e)
        {
            EventHandler handler = FuncEd_Click;
            handler?.Invoke(this, e);
        }

        private void btnFunCad_Click(object sender, EventArgs e)
        {
            EventHandler handler = FuncCad_Click;
            handler?.Invoke(this, e);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            EventHandler handler = Home_Click;
            handler?.Invoke(this, e);
        }
        private void btnSobre_Click(object sender, EventArgs e)
        {
            EventHandler handler = Sobre_Click;
            handler?.Invoke(this, e);
        }

        private void btnCliEdi_Click(object sender, EventArgs e)
        {
            EventHandler handler = UsuEd_Click;
            handler?.Invoke(this, e);
        }

        private void btnCliCad_Click(object sender, EventArgs e)
        {
            EventHandler handler = UsuCad_Click;
            handler?.Invoke(this, e);
        }


    }
}
