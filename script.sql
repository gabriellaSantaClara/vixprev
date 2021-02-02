create database Vixprev

use Vixprev

create table usuarios
(
iduser int not NULL,
usuario VARCHAR(50),
senha VARCHAR(20)
)


insert into usuarios values(1,'user','user')

select * from usuarios  

create table favoritos
(
id int NOT NULL IDENTITY,
iduser int not NULL,
nome VARCHAR(50),
link VARCHAR(100)
)

select * from favoritos 


ALTER TABLE favoritas
  ADD column id int(11) NOT NULL AUTO_INCREMENT,
  ADD PRIMARY KEY (id);