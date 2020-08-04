using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashShark
{
    class Estoque
    {
        // Atributos
        private string data;
        public string Data { get { return data; } set { data = value; } }

        private double quantidade;
        public double Quantidade { get { return quantidade; } set { quantidade = value; } }

        private string tipoMovimento;
        public string TipoMovimento { get { return tipoMovimento; } set { tipoMovimento = value; } }

        //Métodos
        public void Lancar(int cod_prod)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("insert into estoque (codigo_produto, quantidade, data, tipoMovimento) values (?,?,?,?)", objcon);

            //parametros
            objcmd.Parameters.Add("@codigo_produto", MySqlDbType.Int32).Value = cod_prod;
            objcmd.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = quantidade;
            objcmd.Parameters.Add("@data", MySqlDbType.VarChar, 10).Value = data;
            objcmd.Parameters.Add("@tipoMovimento", MySqlDbType.VarChar, 14).Value = tipoMovimento;
            //comando para executar a query
            objcmd.ExecuteNonQuery();
            // fecha a conexao
            objcon.Close();

            MessageBox.Show("Dados inseridos com sucesso!");
        }

        protected void buscarSaldo()
        {

        }

        public void atualizaSaldo(int cod_prod)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("insert into estoque (codigo_produto, quantidade, data, tipoMovimento) values (?,?,?,?)", objcon);

            //parametros
            objcmd.Parameters.Add("@tipoMovimento", MySqlDbType.VarChar, 20).Value = cod_prod;
            objcmd.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = quantidade;
            objcmd.Parameters.Add("@data", MySqlDbType.VarChar, 10).Value = data;
            objcmd.Parameters.Add("@tipoMovimento", MySqlDbType.VarChar, 14).Value = tipoMovimento;
            //comando para executar a query
            objcmd.ExecuteNonQuery();
            // fecha a conexao
            objcon.Close();

            MessageBox.Show("Dados alterados com sucesso!");
        }
    }

    class Produto
    {
        // Atributos
        private string codigo;
        public string Codigo { get { return codigo; } set { codigo = value; } }

        private string nome;
        public string Nome { get { return nome; } set { nome = value; } }

        private string descricao;
        public string Descricao { get { return descricao; } set { descricao = value; } }

        private string modelo;
        public string Modelo { get { return modelo; } set { modelo = value; } }

        private string marcaImpressora;
        public string MarcaImpressora { get { return marcaImpressora; } set { marcaImpressora = value; } }

        private string cor;
        public string Cor { get { return cor; } set { cor = value; } }

        private string ulitmaAtualizacao;
        public string UltimaAtualizacao { get { return ulitmaAtualizacao; } set { ulitmaAtualizacao = value; } }

        private string saldo;
        public string Saldo { get { return saldo; } set { saldo = value; } }

        private string preco;
        public string Preco { get { return preco; } set { preco = value; } }

        //Métodos
        public void Buscar(DataGridView dtg, string col, string valor, bool like)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            string query = "";
            if (like)
                query = "SELECT * FROM produto where " + col + " like '%" + valor + "%'";
            else
                query = "SELECT * FROM produto where " + col + " =" + valor;

            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter(query, objCon);
            conexaoAdapter.Fill(conexaoDataset, "produtos");
            dtg.DataSource = conexaoDataset;
            dtg.DataMember = "produtos";
            objCon.Close();

        }

        public void Listar(DataGridView dtg)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("Select * from Produtos", objCon);
            conexaoAdapter.Fill(conexaoDataset, "cliente");
            dtg.DataSource = conexaoDataset;
            dtg.DataMember = "cliente";
            objCon.Close();
        }

        public void Criar()
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("insert into produto (nome, descricao, modelo, marcaImpressora, cor, ultimaAtualizacao, saldo, preco) values (?,?,?,?,?,?,?,?)", objcon);

            //parametros
            objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 70).Value = nome;
            objcmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = descricao;
            objcmd.Parameters.Add("@modelo", MySqlDbType.VarChar, 45).Value = modelo;
            objcmd.Parameters.Add("@marcaImpressora", MySqlDbType.VarChar, 45).Value = marcaImpressora;
            objcmd.Parameters.Add("@cor", MySqlDbType.VarChar, 45).Value = cor;
            objcmd.Parameters.Add("@ultimaAtualizacao", MySqlDbType.VarChar, 20).Value = ulitmaAtualizacao;
            objcmd.Parameters.Add("@saldo", MySqlDbType.Double).Value = saldo;
            objcmd.Parameters.Add("@preco", MySqlDbType.Double).Value = preco;
            //comando para executar a query
            objcmd.ExecuteNonQuery();
            MySqlCommand cmd = new MySqlCommand("SELECT codigo_produto from produto ORDER BY codigo_produto DESC LIMIT 1", objcon);
            int cod = int.Parse(cmd.ExecuteScalar().ToString());
            // fecha a conexao
            objcon.Close();

            Estoque est = new Estoque();
            est.Data = ulitmaAtualizacao;
            est.Quantidade = double.Parse(saldo);
            est.TipoMovimento = "Entrada";
            est.Lancar(cod);
        }

        public void Atualizar(int cod_prod)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("UPDATE produto SET nome=?, descricao=?, modelo=?, marcaImpressora=?, cor=?, ultimaAtualizacao=?, preco=? WHERE codigo_produto = ?", objcon);
            //parametros
            objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 70).Value = nome;
            objcmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = descricao;
            objcmd.Parameters.Add("@modelo", MySqlDbType.VarChar, 45).Value = modelo;
            objcmd.Parameters.Add("@marcaImpressora", MySqlDbType.VarChar, 45).Value = marcaImpressora;
            objcmd.Parameters.Add("@cor", MySqlDbType.VarChar, 45).Value = cor;
            objcmd.Parameters.Add("@ultimaAtaulizacao", MySqlDbType.Date).Value = ulitmaAtualizacao;
            objcmd.Parameters.Add("@preco", MySqlDbType.Decimal).Value = preco;
            objcmd.Parameters.Add("@codigo_produto", MySqlDbType.Int32).Value = cod_prod;
            //comando para executar a query
            objcmd.ExecuteNonQuery();
            // fecha a conexao
            objcon.Close();

            MessageBox.Show("Dados alterados com sucesso!");
        }

        public void Excluir(string cod_prod)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            MySqlCommand objcmd = new MySqlCommand("delete from produto where codigo_produto = ?", objcon);
            objcmd.Parameters.Clear();
            objcmd.Parameters.Add("@codigo_produto", MySqlDbType.Int32).Value = cod_prod;
            objcmd.CommandType = CommandType.Text;
            objcmd.ExecuteNonQuery();
            objcon.Close();
        }

        public void Mostrar(DataGridView dtg)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("SELECT produto.codigo_produto 'Id', produto.nome 'Nome', produto.descricao 'Descricao', produto.modelo 'Modelo', produto.marcaImpressora 'Marca', cor 'Cor', DATE_FORMAT(produto.ultimaAtualizacao,'%d/%m/%Y') 'Ultima atualizacao', produto.preco 'Preco', estoque.quantidade 'Quantidade' FROM produto INNER JOIN estoque on estoque.codigo_produto = produto.codigo_produto", objCon);
            conexaoAdapter.Fill(conexaoDataset, "produto");
            dtg.DataSource = conexaoDataset;
            dtg.DataMember = "produto";
            objCon.Close();
        }

    }

    class OrdemCompra
    {
        private int numero;
        public int Numero { get { return numero; } set { numero = value; } }

        private DateTime emissao;
        public DateTime Emissao { get { return emissao; } set { emissao = value; } }

        private bool atendida;
        public bool Atendida { get { return atendida; } set { atendida = value; } }

        private DateTime previsao;
        public DateTime Previsao { get { return previsao; } set { previsao = value; } }

        //Métodos
        public void Buscar(DataGridView dtg, string col, string valor, bool like)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            string query = "";
            if (like)
                query = "SELECT * FROM MostrarCompras where " + col + " like '%" + valor + "%'";
            else
                query = "SELECT * FROM MostrarCompras where " + col + " =" + valor;

            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter(query, objCon);
            conexaoAdapter.Fill(conexaoDataset, "MostrarCompras");
            dtg.DataSource = conexaoDataset;
            dtg.DataMember = "MostrarCompras";
            objCon.Close();
        }

        public void Listar(DataGridView dtg)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("Select * from MostrarCompras", objCon);
            conexaoAdapter.Fill(conexaoDataset, "MostrarCompras");
            dtg.DataSource = conexaoDataset;
            dtg.DataMember = "MostrarCompras";
            objCon.Close();
        }

        public void Atualizar(int num_compra)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("update compra set atendida = ? where numero_compra = ?", objcon);
            //parametros
            objcmd.Parameters.Add("@atendida", MySqlDbType.Bit).Value = atendida;
            objcmd.Parameters.Add("@numero_compra", MySqlDbType.Int32).Value = num_compra;
            objcmd.ExecuteNonQuery();
            // fecha a conexao
            objcon.Close();
        }

        public void Baixar(int num_compra)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("update compra set atendida = ? where numero_compra = ?", objcon);
            //parametros
            objcmd.Parameters.Add("@atendida", MySqlDbType.Bit).Value = Convert.ToInt16(atendida);
            objcmd.Parameters.Add("@numero_compra", MySqlDbType.Int32).Value = num_compra;
            objcmd.ExecuteNonQuery();
            // fecha a conexao
            objcon.Close();
        }

        public void Emitir(int id_forn)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("insert into compra (id_fornecedor, emissao, previsao, atendida) values (?,?,?,?)", objcon);
            //parametros
            objcmd.Parameters.Add("@id_fornecedor", MySqlDbType.Int32).Value = id_forn;
            objcmd.Parameters.Add("@emissao", MySqlDbType.Date).Value = emissao;
            objcmd.Parameters.Add("@previsao", MySqlDbType.Date).Value = previsao;
            objcmd.Parameters.Add("@atendida", MySqlDbType.Bit).Value = atendida;
            objcmd.ExecuteNonQuery();
            MySqlCommand cmd = new MySqlCommand("SELECT numero_compra from compra ORDER BY numero_compra DESC LIMIT 1", objcon);
            numero = Convert.ToInt32(cmd.ExecuteScalar());
            // fecha a conexao
            objcon.Close();
        }
    }

    class ItemCompra
    {
        private double qtdComprada;
        public double QtdComprada { get { return qtdComprada; } set { qtdComprada = value; } }

        //Métodos
        public void Criar(int num_compra, int cod_produto)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("insert into itemcompra (numero_compra, codigo_produto, quantidade) values (?,?,?)", objcon);
            //parametros
            objcmd.Parameters.Add("@numero_compra", MySqlDbType.Int32).Value = num_compra;
            objcmd.Parameters.Add("@codigo_produto", MySqlDbType.VarChar, 20).Value = cod_produto;
            objcmd.Parameters.Add("@qtdComprada", MySqlDbType.Int32).Value = qtdComprada;
            //comando para executar a query
            objcmd.ExecuteNonQuery();
            // fecha a conexao
            objcon.Close();
        }

        public void Atualizar(int num_compra, int cod_produto)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("Update itemcompra set codigo_produto=?, quantidade=? where numero_compra = ?", objcon);
            //parametros
            objcmd.Parameters.Add("@codigo_produto", MySqlDbType.VarChar, 20).Value = cod_produto;
            objcmd.Parameters.Add("@qtdComprada", MySqlDbType.Int32).Value = qtdComprada;
            objcmd.Parameters.Add("@numero_compra", MySqlDbType.Int32).Value = num_compra;
            objcmd.ExecuteNonQuery();
            // fecha a conexao
            objcon.Close();
        }

        public void Excluir(int num_compra, int cod_prod)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            MySqlCommand objcmd = new MySqlCommand("delete from itemCompra where numero_compra = ? AND codigo_produto = ?", objcon);
            objcmd.Parameters.Clear();
            objcmd.Parameters.Add("@numero_compra", MySqlDbType.Int32).Value = num_compra;
            objcmd.Parameters.Add("@codigo_produto", MySqlDbType.Int32).Value = cod_prod;
            objcmd.CommandType = CommandType.Text;
            objcmd.ExecuteNonQuery();
            objcon.Close();
        }
    }

    class EspecificacaoFornecedor
    {
        //Atributos
        private string pseudonimo;
        public string Pseudonimo { get { return pseudonimo; } set { pseudonimo = value; } }

        //Métodos
        public void Atualizar(int id_fornecedor)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("UPDATE fornecedor SET pseudonimo=? WHERE id_fornecedor = ?", objcon);

            //parametros
            objcmd.Parameters.Add("@pseudonimo", MySqlDbType.VarChar, 50).Value = pseudonimo;
            objcmd.Parameters.Add("@id_fornecedor", MySqlDbType.Int32).Value = id_fornecedor;
            //comando para executar a query
            objcmd.ExecuteNonQuery();

            // fecha a conexao
            objcon.Close();
        }
    }

    class Fornecedor
    {
        private string nome;
        public string Nome { get { return nome; } set { nome = value; } }

        private int mostraDesativados;
        public int MostraDesativados { get { return mostraDesativados; } set { mostraDesativados = value; } }
        
        private string logradouro;
        public string Logradouro { get { return logradouro; } set { logradouro = value; } }

        private string numero;
        public string Numero { get { return numero; } set { numero = value; } }

        private string bairro;
        public string Bairro { get { return bairro; } set { bairro = value; } }

        private string cidade;
        public string Cidade { get { return cidade; } set { cidade = value; } }

        private string uf;
        public string Uf { get { return uf; } set { uf = value; } }

        private string complemento;
        public string Complemento { get { return complemento; } set { complemento = value; } }

        private string cep;
        public string Cep { get { return cep; } set { cep = value; } }

        private string email;
        public string Email { get { return email; } set { email = value; } }

        private string cnpj;
        public string Cnpj { get { return cnpj; } set { cnpj = value; } }

        private string inscricaoEstadual;
        public string InscricaoEstadual { get { return inscricaoEstadual; } set { inscricaoEstadual = value; } }

        //Métodos
        public void Buscar(DataGridView dtg, string col, string valor, bool like)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            string query = "";
            if (like)
                query = "SELECT id_fornecedor 'Id', nome 'Nome', email 'Email', cnpj 'CNPJ', inscricaoEstadual 'Inscricao Estadual' FROM fornecedor where " + col + " like '%" + valor + "%'";
            else
                query = "SELECT id_fornecedor 'Id', nome 'Nome', email 'Email', cnpj 'CNPJ', inscricaoEstadual 'Inscricao Estadual' FROM fornecedor where " + col + " =" + valor;

            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter(query, objCon);
            conexaoAdapter.Fill(conexaoDataset, "fornecedor");
            dtg.DataSource = conexaoDataset;
            dtg.DataMember = "fornecedor";
            objCon.Close();
        }

        public void Criar(string pseudo)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();

            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("insert into fornecedor (nome, email, cnpj, inscricaoEstadual, pseudonimo) values (?,?,?,?,?)", objcon);
            MySqlCommand objcmdEnd = new MySqlCommand("insert into endereco (logradouro, bairro, uf, cep, cidade, numero, complemento) values (?,?,?,?,?,?,?)", objcon);
            MySqlCommand objcmdFornEnd = new MySqlCommand("insert into fornecedorEndereco (id_fornecedor, id_endereco) values (?,?)", objcon);

            //parametros
            objcmdEnd.Parameters.Add("@logradouro", MySqlDbType.VarChar, 100).Value = logradouro;
            objcmdEnd.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = bairro;
            objcmdEnd.Parameters.Add("@uf", MySqlDbType.VarChar, 70).Value = uf;
            objcmdEnd.Parameters.Add("@cep", MySqlDbType.VarChar, 2).Value = cep;
            objcmdEnd.Parameters.Add("@cidade", MySqlDbType.VarChar, 70).Value = cidade;
            objcmdEnd.Parameters.Add("@complemento", MySqlDbType.VarChar, 70).Value = complemento;
            objcmdEnd.Parameters.Add("@numero", MySqlDbType.VarChar, 6).Value = numero;
            objcmdEnd.ExecuteNonQuery();
            MySqlCommand cmd1 = new MySqlCommand("SELECT id_endereco from endereco ORDER BY id_endereco DESC LIMIT 1", objcon);
            int id2 = Convert.ToInt32(cmd1.ExecuteScalar());
            objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 70).Value = nome;
            objcmd.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = email;
            objcmd.Parameters.Add("@cnpj", MySqlDbType.VarChar, 18).Value = cnpj;
            objcmd.Parameters.Add("@inscricaoEstadual", MySqlDbType.VarChar, 13).Value = inscricaoEstadual;
            objcmd.Parameters.Add("@pseudonimo", MySqlDbType.VarChar, 50).Value = pseudo;
            objcmd.ExecuteNonQuery();
            MySqlCommand cmd2 = new MySqlCommand("SELECT id_fornecedor from fornecedor ORDER BY id_fornecedor DESC LIMIT 1", objcon);
            int id1 = Convert.ToInt32(cmd2.ExecuteScalar());

            objcmdFornEnd.Parameters.Add("@id_fornecedor", MySqlDbType.Int32).Value = id1;
            objcmdFornEnd.Parameters.Add("@id_endereco", MySqlDbType.Int32).Value = id2;
            objcmdFornEnd.ExecuteNonQuery();
            // fecha a conexao
            objcon.Close();

            MessageBox.Show("Dados inseridos com sucesso!");
        }

        public void Atualizar(int id_fornecedor)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("UPDATE fornecedor SET nome=?, email=?, cnpj=?, inscricaoEstadual=? WHERE id_fornecedor = ?", objcon);
            MySqlCommand objcmdEnd = new MySqlCommand("UPDATE endereco SET logradouro=?, bairro=?, uf=?, cep=?, cidade=?, numero=?, complemento=? WHERE id_endereco = ?", objcon);

            //parametros
            objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 70).Value = nome;
            objcmd.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = email;
            objcmd.Parameters.Add("@cnpj", MySqlDbType.VarChar, 18).Value = cnpj;
            objcmd.Parameters.Add("@inscricaoEstadual", MySqlDbType.VarChar, 13).Value = inscricaoEstadual;
            objcmd.Parameters.Add("@id_fornecedor", MySqlDbType.Int32).Value = id_fornecedor;
            //comando para executar a query
            objcmd.ExecuteNonQuery();

            EspecificacaoFornecedor espForn = new EspecificacaoFornecedor();
            espForn.Atualizar(id_fornecedor);

            MySqlCommand cmd = new MySqlCommand("SELECT id_endereco from fornecedorEndereco where id_fornecedor =" + id_fornecedor, objcon);
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            objcmdEnd.Parameters.Add("@logradouro", MySqlDbType.VarChar, 100).Value = logradouro;
            objcmdEnd.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = bairro;
            objcmdEnd.Parameters.Add("@uf", MySqlDbType.VarChar, 70).Value = uf;
            objcmdEnd.Parameters.Add("@cep", MySqlDbType.VarChar, 2).Value = cep;
            objcmdEnd.Parameters.Add("@cidade", MySqlDbType.VarChar, 70).Value = cidade;
            objcmdEnd.Parameters.Add("@numero", MySqlDbType.VarChar, 6).Value = numero;
            objcmdEnd.Parameters.Add("@complemento", MySqlDbType.VarChar, 70).Value = complemento;
            objcmdEnd.Parameters.Add("@id_endereco", MySqlDbType.Int16).Value = id;
            objcmdEnd.ExecuteNonQuery();
            // fecha a conexao
            objcon.Close();
        }

        public void Excluir(int id_fornecedor)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            MySqlCommand objcmd = new MySqlCommand("delete from fornecedor where id_fornecedor = ?", objcon);
            objcmd.Parameters.Clear();
            objcmd.Parameters.Add("@id_fornecedor", MySqlDbType.Int32).Value = id_fornecedor;
            objcmd.CommandType = CommandType.Text;
            objcmd.ExecuteNonQuery();
            objcon.Close();
        }

        public void Mostrar(DataGridView dtg)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("SELECT id_fornecedor'Id', nome 'Nome', pseudonimo 'Pseudonimo', email 'Email', cnpj 'CNPJ', inscricaoEstadual 'Inscricao Estadual' FROM fornecedor WHERE flg_ativo =" + mostraDesativados, objCon);
            conexaoAdapter.Fill(conexaoDataset, "fornecedor");
            dtg.DataSource = conexaoDataset;
            dtg.DataMember = "fornecedor";
            objCon.Close();
        }

    }

    class Cliente
    {
        // Atributos
        private string nome;
        public string Nome { get { return nome; } set { nome = value; } }

        private int mostraDesativados;
        public int MostraDesativados { get { return mostraDesativados; } set { mostraDesativados = value; } }

        private string telefone;
        public string Telefone { get { return telefone; } set { telefone = value; } }

        private string enderecoEletronico;
        public string Email { get { return enderecoEletronico; } set { enderecoEletronico = value; } }

        private string logradouro;
        public string Logradouro { get { return logradouro; } set { logradouro = value; } }

        private string numero;
        public string Numero { get { return numero; } set { numero = value; } }

        private string bairro;
        public string Bairro { get { return bairro; } set { bairro = value; } }

        private string cidade;
        public string Cidade { get { return cidade; } set { cidade = value; } }

        private string cep;
        public string Cep { get { return cep; } set { cep = value; } }

        private string uf;
        public string Uf { get { return uf; } set { uf = value; } }

        private string complemento;
        public string Complemento { get { return complemento; } set { complemento = value; } }

        //Métodos
        public void Buscar(DataGridView dtg, string col, string valor, bool like)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            string query = "";
            if (like)
                query = "SELECT id_cliente 'Id', nome 'Nome', email 'Email', telefone 'Telefone' FROM cliente where " + col + " like '%" + valor + "%'";
            else
                query = "SELECT id_cliente 'Id', nome 'Nome', email 'Email', telefone 'Telefone' FROM cliente where " + col + " =" + valor;

            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter(query, objCon);
            conexaoAdapter.Fill(conexaoDataset, "cliente");
            dtg.DataSource = conexaoDataset;
            dtg.DataMember = "cliente";
            objCon.Close();
        }

        public void Criar()
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("insert into cliente (telefone, nome, email) values (?,?,?)", objcon);
            MySqlCommand objcmdCliEnd = new MySqlCommand("insert into clienteEndereco (id_cliente, id_endereco) values (?,?)", objcon);
            MySqlCommand objcmdEnd = new MySqlCommand("insert into endereco (logradouro, bairro, uf, cep, cidade, numero,complemento) values (?,?,?,?,?,?,?)", objcon);
            //parametros
            objcmdEnd.Parameters.Add("@logradouro", MySqlDbType.VarChar, 100).Value = logradouro;
            objcmdEnd.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = bairro;
            objcmdEnd.Parameters.Add("@uf", MySqlDbType.VarChar, 70).Value = uf;
            objcmdEnd.Parameters.Add("@cep", MySqlDbType.VarChar, 2).Value = cep;
            objcmdEnd.Parameters.Add("@cidade", MySqlDbType.VarChar, 70).Value = cidade;
            objcmdEnd.Parameters.Add("@numero", MySqlDbType.VarChar, 6).Value = numero;
            objcmdEnd.Parameters.Add("@complemento", MySqlDbType.VarChar, 70).Value = complemento;
            objcmdEnd.ExecuteNonQuery();
            MySqlCommand cmd1 = new MySqlCommand("SELECT id_endereco from endereco ORDER BY id_endereco DESC LIMIT 1", objcon);
            int id2 = Convert.ToInt32(cmd1.ExecuteScalar());

            objcmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 20).Value = telefone;
            objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            objcmd.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = enderecoEletronico;
            objcmd.ExecuteNonQuery();
            MySqlCommand cmd2 = new MySqlCommand("SELECT id_cliente from cliente ORDER BY id_cliente DESC LIMIT 1", objcon);
            int id1 = Convert.ToInt32(cmd2.ExecuteScalar());

            objcmdCliEnd.Parameters.Add("@id_cliente", MySqlDbType.Int32).Value = id1;
            objcmdCliEnd.Parameters.Add("@id_endereco", MySqlDbType.Int32).Value = id2;
            objcmdCliEnd.ExecuteNonQuery();
            // fecha a conexao
            objcon.Close();
        }

        public void Atualizar(int id_cli)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("UPDATE cliente SET telefone=?, nome=?, email=? WHERE id_cliente = ?", objcon);
            MySqlCommand objcmdEnd = new MySqlCommand("UPDATE endereco SET logradouro=?, bairro=?, uf=?, cep=?, cidade=?, numero=?, complemento=? WHERE id_endereco = ?", objcon);
            //parametros
            objcmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 20).Value = telefone;
            objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            objcmd.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = enderecoEletronico;
            objcmd.Parameters.Add("@id_cliente", MySqlDbType.Int32).Value = id_cli;
            //comando para executar a query
            objcmd.ExecuteNonQuery();

            MySqlCommand cmd = new MySqlCommand("SELECT id_endereco from clienteEndereco where id_cliente =" + id_cli, objcon);
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            objcmdEnd.Parameters.Add("@logradouro", MySqlDbType.VarChar, 100).Value = logradouro;
            objcmdEnd.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = bairro;
            objcmdEnd.Parameters.Add("@uf", MySqlDbType.VarChar, 70).Value = uf;
            objcmdEnd.Parameters.Add("@cep", MySqlDbType.VarChar, 2).Value = cep;
            objcmdEnd.Parameters.Add("@cidade", MySqlDbType.VarChar, 70).Value = cidade;
            objcmdEnd.Parameters.Add("@numero", MySqlDbType.VarChar, 6).Value = numero;
            objcmdEnd.Parameters.Add("@complemento", MySqlDbType.VarChar, 70).Value = complemento;
            objcmdEnd.Parameters.Add("@id_endereco", MySqlDbType.Int16).Value = id;
            objcmdEnd.ExecuteNonQuery();
            // fecha a conexao
            objcon.Close();
        }

        public void Excluir(int id_cli)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            MySqlCommand objcmd = new MySqlCommand("delete from cliente where id_cliente = ?", objcon);
            objcmd.Parameters.Clear();
            objcmd.Parameters.Add("@id_cliente", MySqlDbType.Int32).Value = id_cli;
            objcmd.CommandType = CommandType.Text;
            objcmd.ExecuteNonQuery();
            objcon.Close();
        }

        public void MostrarPF(DataGridView dtg)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("SELECT * FROM clientePF WHERE Ativo = " + mostraDesativados, objCon);
            conexaoAdapter.Fill(conexaoDataset, "clientePf");
            dtg.DataSource = conexaoDataset;
            dtg.DataMember = "clientePF";
            objCon.Close();
        }

        public void MostrarPJ(DataGridView dtg)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("SELECT * FROM clientePJ WHERE Ativo = "+mostraDesativados, objCon);
            conexaoAdapter.Fill(conexaoDataset, "clientePf");
            dtg.DataSource = conexaoDataset;
            dtg.DataMember = "clientePF";
            objCon.Close();
        }

    }

    class PessoaFisica : Cliente
    {
        private string cpf;
        public string Cpf { get { return cpf; } set { cpf = value; } }

        private string carteiraIdentidade;
        public string CarteiraIdentidade { get { return carteiraIdentidade; } set { carteiraIdentidade = value; } }

        //Métodos

        public void BuscarPF(DataGridView dtg, string col, string valor, bool like)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            string query = "";
            if (like)
                query = "SELECT * FROM ClientePF where " + col + " like '%" + valor + "%'";
            else
                query = "SELECT * FROM ClientePF where " + col + " =" + valor;

            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter(query, objCon);
            conexaoAdapter.Fill(conexaoDataset, "ClientePF");
            dtg.DataSource = conexaoDataset;
            dtg.DataMember = "ClientePF";
            objCon.Close();
        }

        public void AtualizarPF(int id_cli)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("UPDATE pessoaFisica SET nome=?, cpf=?, rg=? WHERE id_cliente = ?", objcon);
            //parametros
            objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = Nome;
            objcmd.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = cpf;
            objcmd.Parameters.Add("@rg", MySqlDbType.VarChar, 12).Value = carteiraIdentidade;
            objcmd.Parameters.Add("@id_cliente", MySqlDbType.Int32).Value = id_cli;
            //comando para executar a query
            objcmd.ExecuteNonQuery();
            // fecha a conexao
            objcon.Close();

            MessageBox.Show("Dados alterados com sucesso!");
        }

        public void CriarPF()
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("insert into pessoaFisica (id_cliente, nome, cpf, rg) values (?,?,?,?)", objcon);

            //parametros
            MySqlCommand cmd = new MySqlCommand("SELECT id_cliente from cliente ORDER BY id_cliente DESC LIMIT 1", objcon);
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            objcmd.Parameters.Add("@id_cliente", MySqlDbType.Int32).Value = id;
            objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = Nome;
            objcmd.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = cpf;
            objcmd.Parameters.Add("@rg", MySqlDbType.VarChar, 12).Value = carteiraIdentidade;
            //comando para executar a query
            objcmd.ExecuteNonQuery();
            // fecha a conexao
            objcon.Close();

            MessageBox.Show("Dados inseridos com sucesso!");
        }
        public void ExcluiPF(int id_cli)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            MySqlCommand objcmd = new MySqlCommand("delete from pessoaFisica where id_cliente = ?", objcon);
            objcmd.Parameters.Clear();
            objcmd.Parameters.Add("@id_cliente", MySqlDbType.Int32).Value = id_cli;
            objcmd.CommandType = CommandType.Text;
            objcmd.ExecuteNonQuery();
            objcon.Close();

            Excluir(id_cli);
        }
    }

    class PessoaJuridica : Cliente
    {
        private string razaoSocial;
        public string RazaoSocial { get { return razaoSocial; } set { razaoSocial = value; } }

        private string cnpj;
        public string Cnpj { get { return cnpj; } set { cnpj = value; } }

        private string inscricaoEstadual;
        public string InscricaoEstadual { get { return inscricaoEstadual; } set { inscricaoEstadual = value; } }

        //Métodos

        public void BuscarPJ(DataGridView dtg, string col, string valor, bool like)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            string query = "";
            if (like)
                query = "SELECT * FROM ClientePJ where " + col + " like '%" + valor + "%'";
            else
                query = "SELECT * FROM ClientePJ where " + col + " =" + valor;

            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter(query, objCon);
            conexaoAdapter.Fill(conexaoDataset, "ClientePJ");
            dtg.DataSource = conexaoDataset;
            dtg.DataMember = "ClientePJ";
            objCon.Close();
        }

        public void AtualizarPJ(int id_cli)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("UPDATE pessoaJuridica SET inscricaoEstadual=?, cnpj=?, razaoSocial=? WHERE id_cliente = ?", objcon);
            //parametros
            objcmd.Parameters.Add("@inscricaoEstaduala", MySqlDbType.VarChar, 13).Value = inscricaoEstadual;
            objcmd.Parameters.Add("@cnpj", MySqlDbType.VarChar, 18).Value = cnpj;
            objcmd.Parameters.Add("@razaoSocial", MySqlDbType.VarChar, 50).Value = razaoSocial;
            objcmd.Parameters.Add("@id_cliente", MySqlDbType.Int32).Value = id_cli;
            //comando para executar a query
            objcmd.ExecuteNonQuery();
            // fecha a conexao
            objcon.Close();
        }

        public void CriarPJ()
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("insert into pessoaJuridica (id_cliente, inscricaoEstadual, cnpj, razaoSocial) values (?,?,?,?)", objcon);

            //parametros
            MySqlCommand cmd = new MySqlCommand("SELECT id_cliente from cliente ORDER BY id_cliente DESC LIMIT 1", objcon);
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            objcmd.Parameters.Add("@id_cliente", MySqlDbType.Int32).Value = id;
            objcmd.Parameters.Add("@inscricaoEstadual", MySqlDbType.VarChar, 13).Value = inscricaoEstadual;
            objcmd.Parameters.Add("@cnpj", MySqlDbType.VarChar, 18).Value = cnpj;
            objcmd.Parameters.Add("@razaoSocial", MySqlDbType.VarChar, 50).Value = razaoSocial;
            //comando para executar a query
            objcmd.ExecuteNonQuery();
            // fecha a conexao
            objcon.Close();

            MessageBox.Show("Dados inseridos com sucesso!");
        }

        public void ExcluirPJ(int id_cli)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            MySqlCommand objcmd = new MySqlCommand("delete from pessoaJuridica where id_cliente = ?", objcon);
            objcmd.Parameters.Clear();
            objcmd.Parameters.Add("@id_cliente", MySqlDbType.Int32).Value = id_cli;
            objcmd.CommandType = CommandType.Text;
            objcmd.ExecuteNonQuery();
            objcon.Close();

            Excluir(id_cli);
        }
    }

    class ClientePedido
    {
        private int numero;
        public int Numero { get { return numero; } set { numero = value; } }

        private DateTime emissao;
        public DateTime Emissao { get { return emissao; } set { emissao = value; } }

        //Métodos
        public void Buscar(DataGridView dtg, string col, string valor, bool like)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            string query = "";
            if (like)
                query = "SELECT * FROM MostrarPedidos where " + col + " like '%" + valor + "%'";
            else
                query = "SELECT * FROM MostrarPedidos where " + col + " =" + valor;

            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter(query, objCon);
            conexaoAdapter.Fill(conexaoDataset, "MostrarPedidos");
            dtg.DataSource = conexaoDataset;
            dtg.DataMember = "MostrarPedidos";
            objCon.Close();
        }

        public void Listar(DataGridView dtg)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("Select * from MostrarPedidos", objCon);
            conexaoAdapter.Fill(conexaoDataset, "MostrarPedidos");
            dtg.DataSource = conexaoDataset;
            dtg.DataMember = "MostrarPedidos";
            objCon.Close();
        }

        public void Criar(int id_cli)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("insert into pedido (id_cliente, emissao) values (?,?)", objcon);
            //parametros
            objcmd.Parameters.Add("@id_cliente", MySqlDbType.Int64).Value = id_cli;
            objcmd.Parameters.Add("@emissao", MySqlDbType.Date).Value = emissao;
            objcmd.ExecuteNonQuery();


            MySqlCommand cmd = new MySqlCommand("SELECT numero_pedido from pedido ORDER BY numero_pedido DESC LIMIT 1", objcon);
            numero = Convert.ToInt32(cmd.ExecuteScalar());
            // fecha a conexao
            objcon.Close();
        }

        public void Baixar()
        {
            Nota_Fiscal NF = new Nota_Fiscal();
            NF.Emitir();
        }

        public void Fechar()
        {

        }
    }

    class Item_Pedido
    {
        private double quantidade;
        public double Quantidade { get { return quantidade; } set { quantidade = value; } }

        private double preco;
        public double Preco { get { return preco; } set { preco = value; } }

        //Métodos
        public void Criar(int num_pedido, int cod_produto)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("insert into itemPedido (numero_pedido, codigo_produto, preco, quantidade) values (?,?,?,?)", objcon);
            //parametros
            objcmd.Parameters.Add("@numero_pedido", MySqlDbType.Int32).Value = num_pedido;
            objcmd.Parameters.Add("@codigo_produto", MySqlDbType.Int32).Value = cod_produto;
            objcmd.Parameters.Add("@preco", MySqlDbType.Double).Value = preco;
            objcmd.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = quantidade;
            objcmd.ExecuteNonQuery();
            // fecha a conexao
            objcon.Close();
        }

        public void Atualizar(int num_pedido, int cod_produto)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("Update itemPedido set codigo_produto=?,preco=?, quantidade=? where numero_pedido = ?", objcon);
            //parametros
            objcmd.Parameters.Add("@codigo_pedido", MySqlDbType.VarChar, 20).Value = cod_produto;
            objcmd.Parameters.Add("@preco", MySqlDbType.Double).Value = preco;
            objcmd.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = quantidade;
            objcmd.Parameters.Add("@numero_pedido", MySqlDbType.Int32).Value = num_pedido;
            objcmd.ExecuteNonQuery();
            //comando para executar a query
            objcmd.ExecuteNonQuery();
            // fecha a conexao
            objcon.Close();
        }

        public void Excluir(int num_pedido, int codigo_produto)
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            MySqlCommand objcmd = new MySqlCommand("delete from itemPedido where numero_pedido = ? AND codigo_produto = ?", objcon);
            objcmd.Parameters.Clear();
            objcmd.Parameters.Add("@numero_pedido", MySqlDbType.Int32).Value = num_pedido;
            objcmd.Parameters.Add("@codigo_produto", MySqlDbType.Int32).Value = codigo_produto;
            objcmd.CommandType = CommandType.Text;
            objcmd.ExecuteNonQuery();
            objcon.Close();
        }
    }

    class Nota_Fiscal
    {
        private int numero;
        public int Numero { get { return numero; } set { numero = value; } }

        private DateTime emissao;
        public DateTime Emissao { get { return emissao; } set { emissao = value; } }

        //Métodos
        public void Criar()
        {

        }

        public void Emitir()
        {

        }
    }
    class Item_Nota_Fiscal
    {
        private double quantidade;
        public double Quantidade { get { return quantidade; } set { quantidade = value; } }

        private double preco;
        public double Preco { get { return preco; } set { preco = value; } }

        //Métodos
        public void Criar()
        {

        }

        public void Atualizar()
        {

        }

        public void Excluir()
        {

        }
    }

    class TEF
    {
        //métodos
        public void Pagar()
        {

        }

        private void Validar()
        {

        }
    }

    class Telecheque
    {
        //métodos
        public void Pagar()
        {

        }

        private void Validar()
        {

        }
    }

    class Funcionario
    {
        //Atributos
        private int id_func;
        public int Id_func { get { return id_func; } set { id_func = value; } }
        
        private int mostraDesativados;
        public int MostraDesativados { get { return mostraDesativados; } set { mostraDesativados = value; } }

        private string nome;
        public string Nome { get { return nome; } set { nome = value; } }

        private string email;
        public string Email { get { return email; } set { email = value; } }

        private string rg;
        public string Rg { get { return rg; } set { rg = value; } }

        private string cpf;
        public string Cpf { get { return cpf; } set { cpf = value; } }

        private char sexo;
        public char Sexo { get { return sexo; } set { sexo = value; } }

        private string telefone;
        public string Telefone { get { return telefone; } set { telefone = value; } }

        private string data_nasc;
        public string Data_nasc { get { return data_nasc; } set { data_nasc = value; } }

        private string data_cont;
        public string Data_cont { get { return data_cont; } set { data_cont = value; } }

        private string logradouro;
        public string Logradouro { get { return logradouro; } set { logradouro = value; } }

        private string numero;
        public string Numero { get { return numero; } set { numero = value; } }

        private string bairro;
        public string Bairro { get { return bairro; } set { bairro = value; } }

        private string cidade;
        public string Cidade { get { return cidade; } set { cidade = value; } }

        private string cep;
        public string Cep { get { return cep; } set { cep = value; } }

        private string uf;
        public string Uf { get { return uf; } set { uf = value; } }

        private string complemento;
        public string Complemento { get { return complemento; } set { complemento = value; } }

        private string nome_cargo;
        public string Nome_cargo { get { return nome_cargo; } set { nome_cargo = value; } }

        private double salario;
        public double Salario { get { return salario; } set { salario = value; } }

        private string senha;
        public string Senha { get { return senha; } set { senha = value; } }

        //Métodos
        public void Criar()
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand cmd7 = new MySqlCommand("SELECT id_funcionario from funcionario WHERE cpf ='"+cpf+"'", objcon);

            if (cmd7.ExecuteScalar() != null)
            {
                MessageBox.Show("CPF já cadastrado.");
            }
            else
            {
                MySqlCommand objcmd = new MySqlCommand("insert into funcionario (id_endereco, nome, data_contratacao, data_nascimento,telefone, CPF, rg, email, sexo) values (?,?,?,?,?,?,?,?,?)", objcon);
                MySqlCommand objcmdEnd = new MySqlCommand("insert into endereco (logradouro, bairro, uf, cep, cidade, numero, complemento) values (?,?,?,?,?,?,?)", objcon);

                //parametros

                objcmdEnd.Parameters.Add("@logradouro", MySqlDbType.VarChar, 100).Value = logradouro;
                objcmdEnd.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = bairro;
                objcmdEnd.Parameters.Add("@uf", MySqlDbType.VarChar, 70).Value = uf;
                objcmdEnd.Parameters.Add("@cep", MySqlDbType.VarChar, 2).Value = cep;
                objcmdEnd.Parameters.Add("@cidade", MySqlDbType.VarChar, 70).Value = cidade;
                objcmdEnd.Parameters.Add("@numero", MySqlDbType.VarChar, 6).Value = numero;
                objcmdEnd.Parameters.Add("@complemento", MySqlDbType.VarChar, 70).Value = complemento;
                objcmdEnd.ExecuteNonQuery();
                MySqlCommand cmd = new MySqlCommand("SELECT id_endereco from endereco ORDER BY id_endereco DESC LIMIT 1", objcon);
                int id = Convert.ToInt32(cmd.ExecuteScalar());

                objcmd.Parameters.Add("@id_endereco", MySqlDbType.Int32).Value = id;
                objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
                objcmd.Parameters.Add("@data_contratacao", MySqlDbType.Date).Value = data_cont;
                objcmd.Parameters.Add("@data_nascimento", MySqlDbType.Date).Value = data_nasc;
                objcmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 25).Value = telefone;
                objcmd.Parameters.Add("@CPF", MySqlDbType.VarChar, 14).Value = cpf;
                objcmd.Parameters.Add("@rg", MySqlDbType.VarChar, 12).Value = rg;
                objcmd.Parameters.Add("@email", MySqlDbType.VarChar, 80).Value = email;
                objcmd.Parameters.Add("@sexo", MySqlDbType.Enum).Value = sexo;

                //comando para executar a query
                objcmd.ExecuteNonQuery();

                MySqlCommand cmd8 = new MySqlCommand("SELECT id_funcionario from funcionario ORDER BY id_funcionario DESC LIMIT 1", objcon);
                int id_func = Convert.ToInt32(cmd8.ExecuteScalar());


                int is_gerente = 0;
                int is_funcionario = 1;
                if (nome_cargo.ToLower().Contains("gerente"))
                {
                    is_gerente = 1;
                    is_funcionario = 0;
                }

                MySqlCommand objcmdLogin = new MySqlCommand("insert into login (email_recuperacao, is_dono, is_gerente, is_funcionario, usuario, senha) values (?,?,?,?,?,?)", objcon);

                //parametros
                objcmdLogin.Parameters.Add("@email_recuperacao", MySqlDbType.VarChar, 50).Value = email;
                objcmdLogin.Parameters.Add("@is_dono", MySqlDbType.Bit, 1).Value = 0;
                objcmdLogin.Parameters.Add("@is_gerente", MySqlDbType.Bit, 1).Value = is_gerente;
                objcmdLogin.Parameters.Add("@is_funcionario", MySqlDbType.Bit, 1).Value = is_funcionario;
                objcmdLogin.Parameters.Add("@usuario", MySqlDbType.VarChar, 50).Value = nome;
                objcmdLogin.Parameters.Add("@senha", MySqlDbType.VarChar, 50).Value = Validacoes.HashValue(senha);


                //comando para executar a query
                objcmdLogin.ExecuteNonQuery();


                // fecha a conexao
                objcon.Close();

                CargoFuncionario cargoFunc = new CargoFuncionario();
                cargoFunc.Nome = nome_cargo;
                cargoFunc.Criar(id_func);

                SalarioFuncionario salFunc = new SalarioFuncionario();
                salFunc.Salario = salario;
                salFunc.Criar(id_func);

                MessageBox.Show("Dados inseridos com sucesso!");
            }
        }

        public void Editar()
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela
            MySqlCommand objcmd = new MySqlCommand("UPDATE funcionario SET nome=?, data_contratacao=?, data_nascimento=?,telefone=?, cpf=?, rg=?, email=?, sexo=? WHERE id_funcionario = ?", objcon);
            MySqlCommand objcmdEnd = new MySqlCommand("UPDATE endereco SET logradouro=?, bairro=?, uf=?, cep=?, cidade=?, numero=?, complemento=? WHERE id_endereco = ?", objcon);
            //parametros
            objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            objcmd.Parameters.Add("@data_contratacao", MySqlDbType.Date).Value = data_cont;
            objcmd.Parameters.Add("@data_nascimento", MySqlDbType.Date).Value = data_nasc;
            objcmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 25).Value = telefone;
            objcmd.Parameters.Add("@CPF", MySqlDbType.VarChar, 14).Value = cpf;
            objcmd.Parameters.Add("@rg", MySqlDbType.VarChar, 12).Value = rg;
            objcmd.Parameters.Add("@email", MySqlDbType.VarChar, 80).Value = email;
            objcmd.Parameters.Add("@sexo", MySqlDbType.Enum).Value = sexo;
            objcmd.Parameters.Add("@id_funcionario", MySqlDbType.Int16).Value = id_func;
            //comando para executar a query
            objcmd.ExecuteNonQuery();

            MySqlCommand cmd = new MySqlCommand("SELECT id_endereco from funcionario where id_funcionario =" + id_func, objcon);
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            objcmdEnd.Parameters.Add("@logradouro", MySqlDbType.VarChar, 100).Value = logradouro;
            objcmdEnd.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = bairro;
            objcmdEnd.Parameters.Add("@uf", MySqlDbType.VarChar, 70).Value = uf;
            objcmdEnd.Parameters.Add("@cep", MySqlDbType.VarChar, 2).Value = cep;
            objcmdEnd.Parameters.Add("@cidade", MySqlDbType.VarChar, 70).Value = cidade;
            objcmdEnd.Parameters.Add("@numero", MySqlDbType.VarChar, 6).Value = numero;
            objcmdEnd.Parameters.Add("@complemento", MySqlDbType.VarChar, 70).Value = complemento;
            objcmdEnd.Parameters.Add("@id_endereco", MySqlDbType.Int16).Value = id;
            objcmdEnd.ExecuteNonQuery();


            int is_gerente = 0;
            int is_funcionario = 1;
            if (nome_cargo.ToLower().Contains("gerente"))
            {
                is_gerente = 1;
                is_funcionario = 0;
            }

            MySqlCommand objcmdLogin = new MySqlCommand("insert into login (email_recuperacao, is_dono, is_gerente, is_funcionario, usuario, senha) values (?,?,?,?,?,?)", objcon);

            //parametros
            objcmdLogin.Parameters.Add("@email_recuperacao", MySqlDbType.VarChar, 50).Value = email;
            objcmdLogin.Parameters.Add("@is_dono", MySqlDbType.Bit, 1).Value = 0;
            objcmdLogin.Parameters.Add("@is_gerente", MySqlDbType.Bit, 1).Value = is_gerente;
            objcmdLogin.Parameters.Add("@is_funcionario", MySqlDbType.Bit, 1).Value = is_funcionario;
            objcmdLogin.Parameters.Add("@usuario", MySqlDbType.VarChar, 50).Value = nome;
            objcmdLogin.Parameters.Add("@senha", MySqlDbType.VarChar, 50).Value = Validacoes.HashValue(senha);


            //comando para executar a query
            objcmdLogin.ExecuteNonQuery();

            // fecha a conexao
            objcon.Close();
            MessageBox.Show("Dados alterados com sucesso!");
        }

        public void Excluir()
        {
            // passa a string de conexao
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            MySqlCommand objcmd = new MySqlCommand("delete from funcionario where id_funcionario = ?", objcon);
            objcmd.Parameters.Clear();
            objcmd.Parameters.Add("@id_funcionario", MySqlDbType.Int16).Value = id_func;
            objcmd.CommandType = CommandType.Text;
            objcmd.ExecuteNonQuery();
            objcon.Close();

            MessageBox.Show("Registro removido!");
        }

        public void Buscar(DataGridView dtg, string col, string valor, bool like)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            string query = "";
            if (like)
                query = "SELECT id_funcionario 'Id', nome 'Nome', telefone 'Telefone', email 'Email', rg 'RG', cpf 'CPF', DATE_FORMAT(data_contratacao,'%d/%m/%Y') 'Data de Contratacao', DATE_FORMAT(data_nascimento,'%d/%m/%Y') 'Data de Nascimento', sexo 'Sexo' FROM funcionario where " + col + " like '%" + valor + "%'";
            else
                query = "SELECT id_funcionario 'Id', nome 'Nome', telefone 'Telefone', email 'Email', rg 'RG', cpf 'CPF', DATE_FORMAT(data_contratacao,'%d/%m/%Y') 'Data de Contratacao', DATE_FORMAT(data_nascimento,'%d/%m/%Y') 'Data de Nascimento', sexo 'Sexo' FROM funcionario where " + col + " =" + valor;

            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter(query, objCon);
            conexaoAdapter.Fill(conexaoDataset, "funcionario");
            dtg.DataSource = conexaoDataset;
            dtg.DataMember = "funcionario";
            objCon.Close();
        }

        public void Mostrar(DataGridView dtg)
        {
            MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            objCon.Open();
            DataSet conexaoDataset = new DataSet();
            MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("SELECT id_funcionario 'Id', nome 'Nome', telefone 'Telefone', email 'Email', rg 'RG', cpf 'CPF', DATE_FORMAT(data_contratacao,'%d/%m/%Y') 'Data de Contratacao', DATE_FORMAT(data_nascimento,'%d/%m/%Y') 'Data de Nascimento', sexo 'Sexo' FROM funcionario where flg_ativo ="+mostraDesativados, objCon);
            conexaoAdapter.Fill(conexaoDataset, "funcionario");
            dtg.DataSource = conexaoDataset;
            dtg.DataMember = "funcionario";
            objCon.Close();
        }

    }

    class CargoFuncionario
    {
        //Atributos

        private string nome;
        public string Nome { get { return nome; } set { nome = value; } }


        //Métodos

        public void Criar(int id_func)
        {
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela

            MySqlCommand objcmd = new MySqlCommand("insert into cargos (id_funcionario, nome, inicio_data, fim_data) values (?,?,?,?)", objcon);
            MySqlCommand cmd = new MySqlCommand("mudaCargo", objcon);
            cmd.CommandType = CommandType.StoredProcedure;

            //parametros
            cmd.Parameters.AddWithValue("idFuncionario", id_func);
            objcmd.Parameters.Add("@id_funcionario", MySqlDbType.Int32).Value = id_func;
            objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            objcmd.Parameters.Add("@inicio_data", MySqlDbType.Date).Value = DateTime.Now;
            objcmd.Parameters.Add("@fim_data", MySqlDbType.Date).Value = DateTime.Parse("01-01-9999");
            
            objcmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();

            objcon.Close();

        }

    }

    class SalarioFuncionario
    {
        //Atributos

        private double salario;
        public double Salario { get { return salario; } set { salario = value; } }


        //Métodos

        public void Criar(int id_func)
        {
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=splash_shark;Character Set=utf8");
            // abre o banco
            objcon.Open();
            // comando para inserir na tabela

            MySqlCommand objcmd = new MySqlCommand("insert into salarios (id_funcionario, valor_salario, inicio_data, fim_data) values (?,?,?,?)", objcon);
            MySqlCommand cmd = new MySqlCommand("mudaSalario", objcon);
            cmd.CommandType = CommandType.StoredProcedure;

            //parametros
            cmd.Parameters.AddWithValue("idFuncionario", id_func);
            objcmd.Parameters.Add("@id_funcionario", MySqlDbType.Int32).Value = id_func;
            objcmd.Parameters.Add("@valor_salario", MySqlDbType.Double).Value = salario;
            objcmd.Parameters.Add("@inicio_data", MySqlDbType.Date).Value = DateTime.Now;
            objcmd.Parameters.Add("@fim_data", MySqlDbType.Date).Value = DateTime.Parse("01-01-9999");
            
            objcmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();

            objcon.Close();

        }
    }

}