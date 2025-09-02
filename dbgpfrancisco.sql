-- CRIANDO O BANCO DE DADOS


CREATE DATABASE dbgpfrancisco;

-- ENTRANDO NO BANCO DE DADOS


USE dbgpfrancisco;

-- CRIANDO A TABELA DE VOLUNTÁRIOS


CREATE TABLE tbVoluntarios(

codVol INT NOT NULL AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
telCel VARCHAR(15) NOT NULL,
cpf VARCHAR(14) NOT NULL,
cep VARCHAR(9) NOT NULL,
nomeRua VARCHAR(100) NOT NULL,
numero VARCHAR(5) NOT NULL,
complemento VARCHAR(100),
bairro VARCHAR(100) NOT NULL,
cidade VARCHAR(100) NOT NULL,
estado VARCHAR(2) NOT NULL,
email VARCHAR(100) NOT NULL,
senha VARCHAR(256) NOT NULL,
salt VARCHAR(64) NOT NULL,
PRIMARY KEY(codVol)
);

-- CRIANDO A TABELA DE USUÁRIOS

CREATE TABLE tbUsuarios(

codUsu INT NOT NULL AUTO_INCREMENT,
email VARCHAR(100) NOT NULL,
senha VARCHAR(100) NOT NULL,
codVol INT NOT NULL,
PRIMARY KEY(codUsu),
FOREIGN KEY(codVol) REFERENCES tbVoluntarios(codVol)
);

-- CRIANDO A TABELA DE PRODUTOS
	
CREATE TABLE tbProdutos(

codProd INT NOT NULL AUTO_INCREMENT,  
nome VARCHAR(100) NOT NULL,
quantidade BIGINT NOT NULL,
peso DECIMAL(10,3) NOT NULL,
unidade VARCHAR(10) NOT NULL,
codBar VARCHAR(50) NOT NULL,
dataArrecadacao DATETIME NOT NULL,
dataDeValidade DATETIME NOT NULL,
codUsu INT NOT NULL,
PRIMARY KEY(codProd, codBar),
FOREIGN KEY(codUsu) REFERENCES tbUsuarios(codUsu)
);

-- CRIANDO A TABELA DE CESTAS

CREATE TABLE tbCestas(

codCes INT NOT NULL AUTO_INCREMENT,
nomeProduto VARCHAR(100) NOT NULL,
dataDistribuicao DATE NOT NULL,
quantidade BIGINT NOT NULL,
codProd INT(20) NOT NULL,
PRIMARY KEY(codCes),
FOREIGN KEY(codProd) REFERENCES tbProdutos(codProd)
);

-- CRIANDO A TABELA DE ESTOQUE

CREATE TABLE tbArmarios(

codArm INT(2) NOT NULL, 
nomeProduto VARCHAR(100) NOT NULL,
quantidade BIGINT NOT NULL,
dataLimiteDistribuicao DATETIME NOT NULL,
dataDeValidade DATETIME NOT NULL,
dataDeSaida DATETIME NOT NULL,
dataDeEntrada DATETIME NOT NULL,
codProd INT NOT NULL,
PRIMARY KEY(codArm),
FOREIGN KEY(codProd) REFERENCES tbProdutos(codProd) 
);



-- -- INSERINDO VOLUNTÁRIO

-- INSERT INTO tbVoluntarios(nome, telCel, cpf, cep, nomeRua, numero, bairro, email, senha, salt)VALUES('Edna', 'Hellen', '1199999-9999', '999.999.999-99', '99999-999', 'Av. 9 de Julho', '999', 'Paulista', 'ednahellen@gmail.com', '99999999', '888BBB');


-- -- INSERINDO USUÁRIO

-- INSERT INTO tbUsuarios(codVol, email, senha)VALUES(1,'ednahellen@gmail.com', '999999999');


-- -- INSERINDO PRODUTOS

-- INSERT INTO tbProdutos(nome, quantidade, peso, unidade, codBar, dataArrecadacao, dataDeValidade, codUsu)VALUES('Arroz Camil', 3, 5, 'KG', '5555', '2025-05-08', '2025-10-05',1);

-- INSERT INTO tbProdutos(nome, quantidade, peso, unidade,  codBar, dataArrecadacao, dataDeValidade, codUsu)VALUES('Arroz Camil', 3, 5, 'KG', '5555', '2025-08-10', '2025-05-17',1);

-- INSERT INTO tbProdutos(nome, quantidade, peso, unidade,  codBar, dataArrecadacao, dataDeValidade, codUsu)VALUES('Arroz Camil', 3, 5, 'KG', '8888', '2025-08-10', '2025-05-17',1);

-- INSERT INTO tbProdutos(nome, quantidade, peso, unidade,  codBar, dataArrecadacao, dataDeValidade, codUsu)VALUES('Arroz Tio João', 10, 5, 'KG', '8786', '2024-02-10', '2022-03-17',1);


-- -- INSERINDO CESTAS

-- INSERT INTO tbCestas(nomeProduto, dataDistribuicao, quantidade, codProd)VALUES('Arroz Camil', '2025-10-11', 1, 1);


-- -- INSERINDO PRODUTO ESTOQUE

-- INSERT INTO tbArmarios(nomeProduto, quantidade, dataLimiteDistribuicao, dataDeValidade, dataDeSaida, dataDeEntrada, codProd)VALUES('Arroz Camil',10,'2026-10-17','2025-10-07','2025-11-03','2025-08-10', 1);


