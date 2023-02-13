CREATE DATABASE PruebaSD

USE PruebaSD

CREATE TABLE Usuario (
	usuID numeric(12) primary  key,
	nombre varchar(100),
	apellido varchar(100)
)

INSERT INTO Usuario VALUES (1,'nombre1','apell1')
INSERT INTO Usuario VALUES (2,'nombre2','apell2')
INSERT INTO Usuario VALUES (3,'nombre3','apell3')
INSERT INTO Usuario VALUES (4,'nombre4','apell4')
INSERT INTO Usuario VALUES (5,'nombre5','apell5')


SELECT * FROM Usuario