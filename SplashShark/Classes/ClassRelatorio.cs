using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplashShark
{
    class ClassRelatorio
    {

        
        public static void geraNotaFiscal(int num_notafisca, string preco_total, int id_cliente)
        {
            string nome_cli = "", telefone_cli = "", end_cli = "", bairro_cli = "", uf_cli = "", cep_cli = "", cidade_cli = "";
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objCon.Open();
            

            MySqlCommand cmd = new MySqlCommand("select nome, telefone from cliente where id_cliente ="+id_cliente, objCon);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dtMensagens = new DataTable();
            da.Fill(dtMensagens);

            foreach (DataRow data in dtMensagens.Rows)
            {
                nome_cli = data[0].ToString();
                telefone_cli = data[1].ToString();
            }

            MySqlCommand cmd1 = new MySqlCommand("select end.logradouro, end.bairro, end.uf, end.cep, end.cidade, end.numero from endereco as end inner join clienteendereco as cli where cli.id_cliente =" + id_cliente, objCon);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            DataTable dtMensagens1 = new DataTable();
            da1.Fill(dtMensagens1);

            foreach (DataRow data in dtMensagens1.Rows)
            {
                end_cli = data[0].ToString() + ", " + data[5].ToString();
                bairro_cli = data[1].ToString();
                uf_cli = data[2].ToString();
                cep_cli = data[3].ToString();
                cidade_cli = data[4].ToString();
            }

            MySqlCommand command = new MySqlCommand("SELECT codigo_produto, FORMAT(preco,2) as preco, quantidade FROM itempedido where numero_pedido=" + num_notafisca.ToString(), objCon);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            MySqlCommand command2 = new MySqlCommand("SELECT produto.nome, produto.descricao, produto.modelo FROM produto INNER JOIN itempedido ON itempedido.codigo_produto = produto.codigo_produto WHERE itempedido.numero_pedido=" + num_notafisca.ToString(), objCon);
            DataTable dt2 = new DataTable();
            dt2.Load(command2.ExecuteReader());
            objCon.Close();

            ReportViewer reportViewer = new ReportViewer();

            reportViewer.ProcessingMode = ProcessingMode.Local;

            // Caminho para o relatório
            reportViewer.LocalReport.ReportEmbeddedResource = "SplashShark.ReportNotaFiscal.rdlc";

            // Parâmetros do Relatório
            List<ReportParameter> listaParametros = new List<ReportParameter>();

            listaParametros.Add(new ReportParameter("num_NotaFiscal", num_notafisca.ToString()));
            listaParametros.Add(new ReportParameter("data_recebimento", DateTime.Now.ToShortDateString()));
            listaParametros.Add(new ReportParameter("vencimento", DateTime.Now.AddDays(30).ToShortDateString()));
            listaParametros.Add(new ReportParameter("preco_total", preco_total));
            listaParametros.Add(new ReportParameter("nome_cli", nome_cli));
            listaParametros.Add(new ReportParameter("endereco_cli", end_cli));
            listaParametros.Add(new ReportParameter("municipio_cli", cidade_cli));
            listaParametros.Add(new ReportParameter("bairro_cli", bairro_cli));
            listaParametros.Add(new ReportParameter("telefone_cli", telefone_cli));
            listaParametros.Add(new ReportParameter("uf_cli", uf_cli));
            listaParametros.Add(new ReportParameter("cep_cli", cep_cli));
            listaParametros.Add(new ReportParameter("hora_saida", DateTime.Now.ToShortTimeString()));

            reportViewer.LocalReport.SetParameters(listaParametros);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetNotaFiscal", dt));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetNotaFiscal2", dt2));

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extensions;

            byte[] bytePDF = reportViewer.LocalReport.Render(
                "Pdf", null, out mimeType, out encoding, out extensions, out streamids, out warnings
                );

            FileStream fileStreamPDF = null;
            string nomeArquivoPDF = Path.GetTempPath() + "NotaFiscal" + 
                DateTime.Now.ToString("dd_MM_yyy-HH_mm_ss") + ".pdf";
            fileStreamPDF = new FileStream(nomeArquivoPDF, FileMode.Create);
            fileStreamPDF.Write(bytePDF, 0, bytePDF.Length);
            fileStreamPDF.Close();
            Process.Start(nomeArquivoPDF);





        }

    }
}
