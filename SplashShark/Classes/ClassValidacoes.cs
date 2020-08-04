using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Globalization;

namespace SplashShark
{
    class Validacoes
    {

        public static bool ValidaData(string data)
        {
            bool valida;
            try
            {
                string[] datinhas = data.Split('/');
                int dia = int.Parse(datinhas[0]);
                int mes = int.Parse(datinhas[1]);
                int ano = int.Parse(datinhas[2]);

                if (!(mes >= 1 && mes <= 12) || !(dia >= 1 && dia <= 31))
                    valida = false;
                else
                {
                    double resto = mes % 2d;
                    if (dia <= 28 && mes == 2)
                        valida = true;
                    if (mes < 8 && resto == 0 && dia == 31 || mes >= 8 && resto != 0 && dia == 31)
                        valida = false;
                    else
                        valida = true;
                }
            }
            catch
            {
                valida = false;
            }
            return valida;
        }

        public static bool ValidaEmail(string email)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(email, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidaRG(string RG, string tabela)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            MySqlCommand cmd1 = new MySqlCommand("SELECT rg from " + tabela + " where rg = '" + RG + "'", objCon);
            if (cmd1.ExecuteScalar() != null)
            {
                MessageBox.Show("RG já cadastrado");
                return false;
            }
            objCon.Close();

            RG = RG.Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "").Trim();
            if (RG.Length == 9)
            {
                int n1 = int.Parse(RG.Substring(0, 1));
                int n2 = int.Parse(RG.Substring(1, 1));
                int n3 = int.Parse(RG.Substring(2, 1));
                int n4 = int.Parse(RG.Substring(3, 1));
                int n5 = int.Parse(RG.Substring(4, 1));
                int n6 = int.Parse(RG.Substring(5, 1));
                int n7 = int.Parse(RG.Substring(6, 1));
                int n8 = int.Parse(RG.Substring(7, 1));

                string DV = RG.Substring(8, 1);

                int Soma = n1 * 2 + n2 * 3 + n3 * 4 + n4 * 5 + n5 * 6 + n6 * 7 + n7 * 8 + n8 * 9;

                string digitoVerificador = Convert.ToString(Soma % 11);

                // Se o dígito verificador for igual a 1, automaticamente ele se tornará o algarismo romano X,
                // pois será feito o cálculo de 11 - o dígito verificador. No caso, ficaria 11 - 1, que é igual a 10.

                if (digitoVerificador == "1")
                {
                    digitoVerificador = "X";
                }

                // Se o dígito verificador for igual a 0, automaticamente ele se torna 0, pois 11 - 0 é igual a 11, e
                // não será permitido isso no dígito verificador, então automaticamente o dígito será 0.
                else if (digitoVerificador == "0")
                {
                    digitoVerificador = "0";
                }

                // Se não for nem 0 nem 1, vai ser feito 11 - o dígito verificador. Por exemplo, se o a soma dividida por 11
                // deu resto 5, será feito 11 - 5, que é igual a 6. Então automaticamente o dígito verificador do RG se tornará o número 6!

                else
                {
                    digitoVerificador = (11 - int.Parse(digitoVerificador)).ToString();
                }

                // Verificar se o dígito verificador é igual ao DV do RG que está sendo validado.

                if (digitoVerificador == DV)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool ValidaCPF(string CPF, string tabela)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            MySqlCommand cmd1 = new MySqlCommand("SELECT cpf from " + tabela + " where cpf = '" + CPF + "'", objCon);
            if (cmd1.ExecuteScalar() != null)
            {
                MessageBox.Show("CPF já cadastrado");
                return false;
            }
            objCon.Close();

            string teste = CPF;
            teste = teste.Trim();
            if (teste.Length < 14)
            {
                return false;
            }

            else if (CPF == "000.000.000-00" ||
                     CPF == "111.111.111-11" ||
                     CPF == "222.222.222-22" ||
                     CPF == "333.333.333-33" ||
                     CPF == "444.444.444-44" ||
                     CPF == "555.555.555-55" ||
                     CPF == "666.666.666-66" ||
                     CPF == "777.777.777-77" ||
                     CPF == "888.888.888-88" ||
                     CPF == "999.999.999-99")
            {
                return false;
            }
            else
            {
                //Vetor para teste do primeiro digito
                int[] mult1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                //Vetor para teste do segundo digito
                int[] mult2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                //String onde vai ser amarzenado o CPF


                string auxCPF;
                string Digito;
                int soma;
                int resto;

                //Se caso tiver espaço em branco sera removido 
                CPF = CPF.Trim();

                //Removo pntos e traços e substitui por nada
                CPF = CPF.Replace(".", "").Replace("-", "");

                //Pega os 9 primeiros digitos do CPF
                auxCPF = CPF.Substring(0, 9);

                soma = 0;

                for (int i = 0; i < 9; i++)
                {
                    //MessageBox.Show(auxCPF[i].ToString());
                    soma += int.Parse(auxCPF[i].ToString()) * mult1[i];
                }

                //Descobre o resto da divisão
                resto = soma % 11;

                if (resto < 2)
                {
                    //Se o resto for menor do que 2 ele vai ter um valor igua a 0
                    resto = 0;
                }
                else
                {
                    //Se não for maior do que 2 o resto vai receber o valor de 11 menos o resto
                    resto = 11 - resto;
                }
                //Guarda o primeiro digito 
                Digito = resto.ToString();
                //Passa pra aux do cpf
                auxCPF = auxCPF + Digito;
                //Soma fica a 0
                soma = 0;

                for (int i = 0; i < 10; i++)
                {
                    soma += int.Parse(auxCPF[i].ToString()) * mult2[i];
                }

                resto = soma % 11;

                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                auxCPF = auxCPF + resto;

                if (CPF == auxCPF)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
        }

        public static bool ValidaCNPJ(string cnpj, string tabela)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            MySqlCommand cmd1 = new MySqlCommand("SELECT cnpj from " + tabela + " where cnpj = '" + cnpj + "'", objCon);
            if (cmd1.ExecuteScalar() != null)
            {
                MessageBox.Show("CNPJ já cadastrado");
                return false;
            }
            objCon.Close();

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
            {
                return false;
            }
            else
            {
                string tempCnpj = cnpj.Substring(0, 12);
                int soma = 0;

                for (int i = 0; i < 12; i++)
                {
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
                }
                int resto = (soma % 11);
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                    resto = 11 - resto;

                string digito = resto.ToString();
                tempCnpj = tempCnpj + digito;
                soma = 0;
                for (int i = 0; i < 13; i++)
                {
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
                }
                resto = (soma % 11);
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                    digito = digito + resto.ToString();
                }
                tempCnpj = tempCnpj + resto.ToString();

                if (cnpj != tempCnpj.ToString())
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static void TeclaLetra(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 32 || e.KeyChar == 8 || e.KeyChar == 127) || (e.KeyChar > 64 && e.KeyChar < 91) || (e.KeyChar > 96 && e.KeyChar < 123) || (e.KeyChar >= 192 && e.KeyChar <= 255))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public static void TeclaNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 127))
                e.Handled = true;
        }

        public static void TeclaDinheiro(object sender, KeyPressEventArgs e)
        {
            TextBox txtDin = sender as TextBox;
            if ((e.KeyChar == 44 || e.KeyChar == 46) && !txtDin.Text.Contains(","))
            {
                txtDin.Text += ",";
                e.Handled = true;
                txtDin.SelectionStart = txtDin.Text.Length;
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 127))
                e.Handled = true;
        }

        public static void TeclaModelo(object sender, KeyPressEventArgs e)
        {
            TextBox txtMod = sender as TextBox;
            if (e.KeyChar == 45 && !txtMod.Text.Contains("-"))
            {
                txtMod.Text += "-";
                e.Handled = true;
                txtMod.SelectionStart = txtMod.Text.Length;
            }
            else if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8 || e.KeyChar == 127))
                e.Handled = false;
            else if ((e.KeyChar == 32 || e.KeyChar == 8 || e.KeyChar == 127) || (e.KeyChar > 64 && e.KeyChar < 91) || (e.KeyChar > 96 && e.KeyChar < 123) || (e.KeyChar >= 192 && e.KeyChar <= 255))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public static int geraPontosSenha(string senha)
        {
            if (senha == null) return 0;
            int pontosPorTamanho = GetPontoPorTamanho(senha);
            int pontosPorMinusculas = GetPontoPorMinusculas(senha);
            int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
            int pontosPorDigitos = GetPontoPorDigitos(senha);
            int pontosPorSimbolos = GetPontoPorSimbolos(senha);
            if (pontosPorMinusculas == 0 || pontosPorMaiusculas == 0 || pontosPorDigitos == 0) return 0;
            return pontosPorTamanho + pontosPorMinusculas + pontosPorMaiusculas + pontosPorDigitos + pontosPorSimbolos;
        }

        private static int GetPontoPorTamanho(string senha)
        {
            return Math.Min(10, senha.Length) * 5;
        }

        private static int GetPontoPorMinusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private static int GetPontoPorMaiusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private static int GetPontoPorDigitos(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private static int GetPontoPorSimbolos(string senha)
        {
            int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        public static string ValidaSenha(string senha)
        {
            int placar = geraPontosSenha(senha);

            if (placar < 30)
                return "Fraca";
            else if (placar < 50)
                return "Fraca";
            else if (placar < 70)
                return "Média";
            else if (placar < 80)
                return "Forte";
            else
                return "Segura";
        }

        private static Timer tmValidaErro;
        private static int j = 0;
        private static bool[] erro;
        private static PictureBox[] pbErro;
        public static void ValidaErro(PictureBox[] pb)
        {
            tmValidaErro = new Timer();
            tmValidaErro.Tick += ValidaErroTick;
            pbErro = pb;
            erro = new bool[pb.Length];
            tmValidaErro.Interval = 150;
            for (int i = 0; i < pb.Length; i++)
            {
                erro[i] = pb[i].Visible;
            }
            tmValidaErro.Enabled = true;
        }
        private static void ValidaErroTick(object sender, EventArgs e)
        {
            for (int i = 0; i < pbErro.Length; i++)
                pbErro[i].Visible = j % 2 == 0 && erro[i] ? true : false;
            if (j == 8)
                tmValidaErro.Enabled = false;
            j++;
        }

        public static string HashValue(string value)
        {
            UnicodeEncoding encoding = new UnicodeEncoding();
            byte[] hashBytes;
            using (HashAlgorithm hash = SHA1.Create())
                hashBytes = hash.ComputeHash(encoding.GetBytes(value));

            StringBuilder hashValue = new StringBuilder(hashBytes.Length * 2);
            foreach (byte b in hashBytes)
            {
                hashValue.AppendFormat(CultureInfo.InvariantCulture, "{0:X2}", b);
            }

            return hashValue.ToString();
        }
    }
}
