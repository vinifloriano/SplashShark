-- -----------------------------------------------------
-- Schema splash_shark
-- -----------------------------------------------------
DROP DATABASE IF EXISTS `splash_shark`;
CREATE DATABASE IF NOT EXISTS `splash_shark` DEFAULT CHARACTER SET utf8 ;
USE `splash_shark` ;


-- -----------------------------------------------------
-- Table `splash_shark`.`produto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`produto` (
  `codigo_produto` INT AUTO_INCREMENT NOT NULL PRIMARY KEY UNIQUE,
  `nome` VARCHAR(70) NOT NULL,
  `descricao` VARCHAR(100) NOT NULL,
  `modelo` VARCHAR(45) NOT NULL,
  `marcaImpressora` VARCHAR(45) NOT NULL,
  `cor` VARCHAR(45) NOT NULL,
  `ultimaAtualizacao` VARCHAR(20) NOT NULL,
  `saldo` DOUBLE NOT NULL,
  `preco` DECIMAL(10,2) NOT NULL)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `splash_shark`.`estoque`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`estoque` (
  `id_estoque` INT NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
  `codigo_produto` INT NOT NULL,
  `quantidade` INT NOT NULL,
  `data` VARCHAR(10) NOT NULL,
  `tipoMovimento` VARCHAR(45) NOT NULL,
  CONSTRAINT `fk_est_produto`
    FOREIGN KEY (`codigo_produto`)
    REFERENCES `splash_shark`.`produto` (`codigo_produto`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `splash_shark`.`fornecedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`fornecedor` (
  `id_fornecedor` INT NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
  `nome` VARCHAR(70) NOT NULL,
  `email` VARCHAR(100) NOT NULL,
  `cnpj` VARCHAR(18) NOT NULL UNIQUE,
  `inscricaoEstadual` VARCHAR(15) NOT NULL,
  `pseudonimo` VARCHAR(50) NOT NULL,
  `flg_ativo` BIT(1) DEFAULT 1)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `splash_shark`.`Compra`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`Compra` (
  `numero_compra` INT NOT NULL PRIMARY KEY AUTO_INCREMENT UNIQUE,
  `id_fornecedor` INT NOT NULL,
  `emissao` DATE NOT NULL,
  `previsao` DATE NOT NULL,
  `atendida` TINYINT NOT NULL,
  CONSTRAINT `fk_cf_fornecedor`
    FOREIGN KEY (`id_fornecedor`)
    REFERENCES `splash_shark`.`fornecedor` (`id_fornecedor`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `splash_shark`.`itemCompra`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`itemCompra` (
  `numero_compra` INT NOT NULL,
  `codigo_produto` INT NOT NULL,
  `quantidade` DOUBLE NOT NULL,
  CONSTRAINT `fk_ic_compra`
    FOREIGN KEY (`numero_compra`)
    REFERENCES `splash_shark`.`Compra` (`numero_compra`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_ic_produto`
    FOREIGN KEY (`codigo_produto`)
    REFERENCES `splash_shark`.`produto` (`codigo_produto`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
    PRIMARY KEY(`numero_compra`,`codigo_produto`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `splash_shark`.`endereco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`endereco` (
  `id_endereco` INT NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
  `logradouro` VARCHAR(100) NOT NULL,
  `bairro` VARCHAR(70) NOT NULL,
  `uf` CHAR(2) NOT NULL,
  `cep` VARCHAR(9) NOT NULL,
  `cidade` VARCHAR(70) NOT NULL,
  `numero` VARCHAR(6) NOT NULL,
  `complemento` VARCHAR(70) NULL)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `splash_shark`.`fornecedorEndereco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`fornecedorEndereco` (
  `id_fornecedor` INT NOT NULL,
  `id_endereco` INT NOT NULL,
  CONSTRAINT `fk_fe_fornecedor`
    FOREIGN KEY (`id_fornecedor`)
    REFERENCES `splash_shark`.`fornecedor` (`id_fornecedor`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_fe_endereco`
    FOREIGN KEY (`id_endereco`)
    REFERENCES `splash_shark`.`endereco` (`id_endereco`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `splash_shark`.`cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`cliente` (
  `id_cliente` INT NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
  `telefone` VARCHAR(20) NOT NULL,
  `nome` VARCHAR(100) NOT NULL,
  `email` VARCHAR(100) NOT NULL,
  `flg_ativo` BIT(1) DEFAULT 1)
ENGINE = InnoDB;
-- -----------------------------------------------------
-- Table `splash_shark`.`clienteEndereco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`clienteEndereco` (
  `id_cliente` INT NOT NULL,
  `id_endereco` INT NOT NULL,
  CONSTRAINT `fk_ce_cliente`
    FOREIGN KEY (`id_cliente`)
    REFERENCES `splash_shark`.`cliente` (`id_cliente`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_ce_endereco`
    FOREIGN KEY (`id_endereco`)
    REFERENCES `splash_shark`.`endereco` (`id_endereco`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `splash_shark`.`pessoaFisica`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`pessoaFisica` (
  `id_cliente` INT NOT NULL PRIMARY KEY UNIQUE,
  `nome` VARCHAR(100) NOT NULL,
  `cpf` VARCHAR(14) NOT NULL UNIQUE,
  `rg` VARCHAR(12) NOT NULL,
  CONSTRAINT `fk_pf_cliente`
    FOREIGN KEY (`id_cliente`)
    REFERENCES `splash_shark`.`cliente` (`id_cliente`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `splash_shark`.`pessoaJuridica`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`pessoaJuridica` (
  `id_cliente` INT NOT NULL PRIMARY KEY UNIQUE,
  `inscricaoEstadual` VARCHAR(15) NOT NULL,
  `cnpj` VARCHAR(18) NOT NULL,
  `razaoSocial` VARCHAR(50) NOT NULL,
  CONSTRAINT `fk_pj_cliente`
    FOREIGN KEY (`id_cliente`)
    REFERENCES `splash_shark`.`cliente` (`id_cliente`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `splash_shark`.`pedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`pedido` (
  `numero_pedido` INT NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
  `id_cliente` INT NOT NULL,
  `emissao` DATE NOT NULL,
  CONSTRAINT `fk_ped_cli`
    FOREIGN KEY (`id_cliente`)
    REFERENCES `splash_shark`.`cliente` (`id_cliente`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `splash_shark`.`notaFiscal`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`notaFiscal` (
  `numero_notaFiscal` INT NOT NULL PRIMARY KEY AUTO_INCREMENT UNIQUE,
  `id_cliente` INT NOT NULL,
  `emissao` DATE NOT NULL,
  CONSTRAINT `fk_nf_cli`
    FOREIGN KEY (`id_cliente`)
    REFERENCES `splash_shark`.`cliente` (`id_cliente`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `splash_shark`.`itemNotaFiscal`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`itemNotaFiscal` (
  `id_notaFiscal` INT NOT NULL,
  `numero_pedido` INT NOT NULL,
  `preco` DOUBLE NOT NULL,
  `quantidade` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_notaFiscal`),
  CONSTRAINT `fk_notaFiscal`
    FOREIGN KEY (`id_notaFiscal`)
    REFERENCES `splash_shark`.`notaFiscal` (`numero_notaFiscal`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_if_ped`
    FOREIGN KEY (`numero_pedido`)
    REFERENCES `splash_shark`.`pedido` (`numero_pedido`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `splash_shark`.`itemPedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`itemPedido` (
  `numero_pedido` INT NOT NULL,
  `codigo_produto` INT NOT NULL,
  `preco` DOUBLE NOT NULL,
  `quantidade` INT NOT NULL,
  PRIMARY KEY (`numero_pedido`, `codigo_produto`),
  CONSTRAINT `fk_ip_ped`
    FOREIGN KEY (`numero_pedido`)
    REFERENCES `splash_shark`.`pedido` (`numero_pedido`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_ip_pro`
    FOREIGN KEY (`codigo_produto`)
    REFERENCES `splash_shark`.`produto` (`codigo_produto`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `splash_shark`.`funcionario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`funcionario` (
  `id_funcionario` INT NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
  `id_endereco` INT NOT NULL,
  `nome` VARCHAR(100) NOT NULL,
  `email` VARCHAR(80) NOT NULL,
  `telefone` VARCHAR(25) NOT NULL,
  `rg` VARCHAR(12) NOT NULL,
  `cpf` VARCHAR(14) NOT NULL UNIQUE,
  `sexo` ENUM('M','F') NOT NULL,
  `data_nascimento` DATE NOT NULL,
  `data_contratacao` DATE NOT NULL,
  `flg_ativo` BIT(1) DEFAULT 1,
  CONSTRAINT `fk_func_end`
    FOREIGN KEY (`id_endereco`)
    REFERENCES `splash_shark`.`endereco` (`id_endereco`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `splash_shark`.`cargos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`cargos` (
  `id_cargo` INT NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
  `id_funcionario` INT NOT NULL,
  `nome` VARCHAR(45) NOT NULL,
  `inicio_data` DATE NOT NULL,
  `fim_data` DATE NOT NULL,
  CONSTRAINT `fk_cg_func`
    FOREIGN KEY (`id_funcionario`)
    REFERENCES `splash_shark`.`funcionario` (`id_funcionario`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `splash_shark`.`salarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `splash_shark`.`salarios` (
  `id_salario` INT NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
  `id_funcionario` INT NOT NULL,
  `valor_salario` DOUBLE NOT NULL,
  `inicio_data` DATE NOT NULL,
  `fim_data` DATE NOT NULL,
  CONSTRAINT `id_sal_func`
    FOREIGN KEY (`id_funcionario`)
    REFERENCES `splash_shark`.`funcionario` (`id_funcionario`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


DROP TABLE IF EXISTS `login`;
CREATE TABLE IF NOT EXISTS `login` (
  `id_login` int(11) NOT NULL AUTO_INCREMENT,
  `email_recuperacao` varchar(50) DEFAULT NULL,
  `is_dono` bit(1) DEFAULT NULL,
  `is_gerente` bit(1) DEFAULT NULL,
  `is_funcionario` bit(1) DEFAULT NULL,
  `usuario` varchar(50) DEFAULT NULL,
  `senha` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_login`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

CREATE VIEW `ClientePF` AS 
SELECT c.id_cliente ID, c.nome Nome, c.email Email, pf.cpf CPF, pf.rg RG, c.telefone Telefone, concat(en.logradouro, ', ', en.numero) 'Endereço', en.cep 'CEP', en.bairro 'Bairro', en.cidade 'Cidade', en.uf 'Estado', c.flg_ativo 'Ativo' FROM cliente c
INNER JOIN pessoaFisica pf ON pf.id_cliente = c.id_cliente
INNER JOIN clienteendereco cli_en ON  c.id_cliente = cli_en.id_cliente
INNER JOIN endereco en ON  cli_en.id_endereco = en.id_endereco;

CREATE VIEW `ClientePJ` AS
SELECT c.id_cliente ID, c.nome Nome, c.email Email, c.telefone Telefone, pj.cnpj CNPJ, pj.inscricaoEstadual 'Inscricao Estadual', pj.razaoSocial 'Razao Social', concat(en.logradouro, ', ', en.numero) 'Endereço', en.cep 'CEP', en.bairro 'Bairro', en.cidade 'Cidade', en.uf 'Estado', c.flg_ativo 'Ativo'  FROM cliente c
INNER JOIN pessoaJuridica pj ON pj.id_cliente = c.id_cliente
INNER JOIN clienteendereco cli_en ON  c.id_cliente = cli_en.id_cliente
INNER JOIN endereco en ON  cli_en.id_endereco = en.id_endereco;

CREATE VIEW `Produtos` AS
SELECT p.codigo_produto 'Codigo', nome Nome, modelo Modelo, marcaImpressora Marca, cor Cor, ultimaAtualizacao 'Ultima Atualizacao', saldo Quantidade, preco 'Preco', tipoMovimento "Tipo Movimento"
FROM produto p
INNER JOIN estoque e
on e.codigo_produto = p.codigo_produto;

CREATE VIEW `MostrarPedidos` AS
SELECT numero_pedido 'Numero', c.nome Nome, emissao 'Emissao' from pedido p
inner join cliente c
on c.id_cliente = p.id_cliente;

CREATE VIEW `MostrarCompras` AS
SELECT numero_compra, f.nome, emissao, previsao, atendida FROM compra c
INNER JOIN fornecedor f
ON f.id_fornecedor = c.id_fornecedor;

DELIMITER $$
CREATE PROCEDURE pega_cliente (IN id_cli int, OUT resultado varchar(20))
BEGIN
	DECLARE cpf varchar(14) DEFAULT (SELECT cpf from pessoafisica WHERE id_cliente = id_cli);
    DECLARE cnpj varchar(18) DEFAULT (SELECT cnpj from pessoajuridica WHERE id_cliente = id_cli);
    SET resultado = CONCAT(COALESCE(cpf, ''),COALESCE(cnpj,''));
END $$
DELIMITER ;


create view itempedidoview as SELECT codigo_produto, FORMAT(preco,2), quantidade FROM itempedido;

DELIMITER $$
CREATE PROCEDURE mudaSalario(IN idFuncionario INT)
BEGIN
	DECLARE novo_salario INT default (select id_salario from salarios order by id_salario desc limit 1);
    DECLARE antigo_salario INT default (select id_salario from salarios where id_funcionario = idFuncionario and id_salario != novo_salario order by id_salario desc limit 1);
    UPDATE salarios SET fim_data = curdate() where id_salario = antigo_salario;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE mudaCargo(IN idFuncionario INT)
BEGIN
	DECLARE novo_cargo INT default (select id_cargo from cargos order by id_cargo desc limit 1);
    DECLARE antigo_cargo INT default (select id_cargo from cargos where id_funcionario = idFuncionario and id_cargo != novo_cargo order by id_cargo desc limit 1);
    UPDATE cargos SET fim_data = curdate() where id_cargo = antigo_cargo;
END $$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER maisPedido AFTER INSERT
ON itempedido
FOR EACH ROW
BEGIN
	UPDATE estoque e SET quantidade = e.quantidade - new.quantidade where codigo_produto = new.codigo_produto;
END $$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER menosPedido AFTER DELETE
ON itempedido
FOR EACH ROW
BEGIN
	UPDATE estoque e SET quantidade = e.quantidade + old.quantidade where codigo_produto = old.codigo_produto;
END $$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER maisCompra AFTER UPDATE
ON compra
FOR EACH ROW
BEGIN
	declare numero int default new.numero_compra;
	declare cont INT default 0;
	declare prod int default 0;
	declare qtd int default 0;
	declare total int default (select count(*) from itemcompra where numero_compra = numero);
	IF (new.atendida = 1) THEN
		while cont < total do
			set prod = (select codigo_produto from itemcompra where numero_compra = numero limit cont,1);
			set qtd = (select qtdComprada from itemcompra where codigo_produto = prod and numero_compra = numero);
			update estoque set quantidade = quantidade + qtd where codigo_produto = prod;
		set cont = cont + 1;
    end while;
    END IF;
END $$
DELIMITER ;
