# SisCont

Mateus Silva Freire e Matheus Duarte Queiroz

BD: PostgresSQL

Comando de criação de banco/tabelas:

```
CREATE DATABASE SisCont;

USE SisCont;

CREATE TABLE Usuarios(
    ID serial PRIMARY KEY,
    login VARCHAR(80) NOT NULL,
    senha VARCHAR(80) NOT NULL
);

CREATE TABLE Contas(
    ID serial PRIMARY KEY,
    banco VARCHAR(80) NOT NULL,
    contaNumero VARCHAR(80) NOT NULL,
    agencia VARCHAR(80) NOT NULL
);

CREATE TABLE Despesas (
    ID serial PRIMARY KEY,
    descricao VARCHAR(80) NOT NULL,
    fundo VARCHAR(80) NOT NULL,
    valor NUMERIC(5,2) NOT NULL
);

CREATE TABLE Despesas (
    ID serial PRIMARY KEY,
    descricao VARCHAR(80) NOT NULL,
    recurso VARCHAR(80) NOT NULL,
    orgao VARCHAR(80) NOT NULL,
    valor NUMERIC(5,2) NOT NULL
);

CREATE TABLE Empenhos (
    ID serial PRIMARY KEY,
    descricao VARCHAR(80) NOT NULL,
    despesa VARCHAR(80) NOT NULL,
    valor NUMERIC(5,2) NOT NULL
);

CREATE TABLE Liquidacoes (
    ID serial PRIMARY KEY,
    descricao VARCHAR(80) NOT NULL,
    empenho VARCHAR(80) NOT NULL,
    valor NUMERIC(5,2) NOT NULL
);

CREATE TABLE Pagamento (
    ID serial PRIMARY KEY,
    descricao VARCHAR(80) NOT NULL,
    liquidacao VARCHAR(80) NOT NULL,
    valor NUMERIC(5,2) NOT NULL
);

CREATE TABLE Estoque (
    ID serial PRIMARY KEY,
    produto VARCHAR(80) NOT NULL,
    quantidade numeric(4,0) NOT NULL,
    valorCusto NUMERIC(5,2) NOT NULL
);

CREATE TABLE Vendas (
    ID serial PRIMARY KEY,
    cliente VARCHAR(80) NOT NULL,
    produto VARCHAR(80) NOT NULL,
    quantidade NUMERIC(4,0) NOT NULL
);

CREATE TABLE Clientes (
    ID serial PRIMARY KEY,
    nome VARCHAR(80) NOT NULL,
    cpf VARCHAR(80) NOT NULL,
    email VARCHAR(80) NOT NULL
);
```
