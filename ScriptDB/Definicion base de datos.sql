CREATE DATABASE BD_Banco;
USE BD_Banco;

CREATE TABLE usuario(

	dpi varchar(13) PRIMARY KEY,
	nombres varchar(30) NOT NULL,
	apellidos varchar(30) NOT NULL,
	correo varchar(20) NOT NULL,
	password varchar(20) NOT NULL
);

CREATE TABLE cuenta(
	no_cuenta int PRIMARY KEY,
	saldo decimal(10,2) NOT NULL,
	usuario varchar(13) NOT NULL,
	FOREIGN KEY(usuario) REFERENCES usuario(dpi)
);

Create Table Historial(
	correlativo int identity primary key,
	Descripcion varchar(max)

);



