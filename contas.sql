create database contas
use contas

drop table Cliente
drop table Amigos

create table Cliente(
cliente_email VARCHAR(50) PRIMARY KEY,
cliente_senha VARCHAR(30) NOT NULL,
cliente_nome VARCHAR(45) NOT NULL,
cliente_cpf VARCHAR(15) NOT NULL,
cliente_ncartao NUMERIC(16) NOT NULL,
cliente_validade DATE NOT NULL,
cliente_cvv NUMERIC (3) NOT NULL,
cliente_plano VARCHAR (7) NOT NULL
)

create table Amigos(
amigos_email_usuario1 VARCHAR(50) FOREIGN KEY REFERENCES Cliente NOT NULL,
amigos_nome_usuario1 VARCHAR(45) NOT NULL,
amigos_email_usuario2 VARCHAR(50) FOREIGN KEY REFERENCES Cliente NOT NULL,
amigos_nome_usuario2 VARCHAR(45) NOT NULL,
primary key(amigos_email_usuario1,amigos_email_usuario2)
)

insert into Cliente values ('saolinmatadordeporco972@gmail.com','123456abc','Shaolin 2 o retorno', '000.341.453-32',8784235421348543,'2022-04-14',190,'Padrao')
insert into Cliente values ('amigo@gmail.com','123456abc','Shaolin 3 o retorno', '000.341.453-32',8784235421348543,'2022-04-14',190,'Padrao')

select * from Cliente

select * from Amigos

select amigos_email_usuario1, amigos_email_usuario2 from Amigos