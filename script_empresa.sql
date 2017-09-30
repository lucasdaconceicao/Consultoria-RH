-- RODAR O SCRIPT EM UM USUARIO QUE TENHA PERMISSAO DE DBA
CREATE USER 'administrator'@'localhost' IDENTIFIED BY '1234';
GRANT ALL PRIVILEGES ON * . * TO 'administrator'@'localhost';
CREATE DATABASE EMPRESA;
USE EMPRESA;

CREATE TABLE FUNCIONARIOS
(
	ID_FUNCIONARIO INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
	NOME_FUNCIONARIO VARCHAR(100) NOT NULL,
	IDADE_FUNCIONARIO VARCHAR(20) NOT NULL,
	ESTADO_CIVIL_FUNCIONARIO VARCHAR(100) NOT NULL,
	CPF_FUNCIONARIO VARCHAR(100) NOT NULL UNIQUE,
	NASCIMENTO_FUNCIONARIO DATE NOT NULL,
	MATRICULA_FUNCIONARIO VARCHAR(50) NOT NULL,
	FUNCAO_FUNCIONARIO VARCHAR(50) NOT NULL,
	ENDERECO_FUNCIONARIO VARCHAR(100) NOT NULL,
	TELEFONE_FUNCIONARIO VARCHAR(30) NOT NULL,
	PIS_FUNCIONARIO VARCHAR(30) NOT NULL,
	CARTEIRA_TRABALHO_FUNCIONARIO VARCHAR(30) NOT NULL,
	RG_FUNCIONARIO VARCHAR(30) NOT NULL,
	SEXO_FUNCIONARIO CHAR(1) NOT NULL
	-- CRIAR CONSTRAINT AKI DA TABELA DEPARTAMENTO
);

CREATE TABLE DEPARTAMENTO
(
	ID_DEPARTAMENTO INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
	NOME_DEPARTAMENTO VARCHAR(100) NOT NULL
);

CREATE TABLE USUARIOS
(
	ID_USUARIO INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
	LOGIN_USUARIO VARCHAR(100) NOT NULL,
	SENHA_USUARIO VARCHAR(20) NOT NULL,
	STATUS_USUARIO VARCHAR(50) NULL
);
INSERT INTO usuarios(LOGIN_USUARIO,SENHA_USUARIO) VALUES ("admin",1234);
	    