CREATE DATABASE SisCont;

USE SisCont;

CREATE TABLE Usuarios(
    ID serial PRIMARY KEY,
    Login VARCHAR(80) NOT NULL,
    password VARCHAR(80) NOT NULL
);

