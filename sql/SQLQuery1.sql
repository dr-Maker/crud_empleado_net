
-- create database net_crudempleado;

use net_crudempleado;
go
drop table empleado;
go
create table empleado(
num int identity(1001,1),
nombres varchar(50),
apellidos varchar(50),
email varchar(50),
telefono int,
primary key(num),
unique(email)
);

insert into empleado values('Leon', 'Pardo', 'lpardo@tpc403.net', 987654321);

select * from empleado;