
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
insert into empleado values('Ximena', 'Aguila', 'xaguila@tpc403.net', 963852741);
insert into empleado values('Rodrigo', 'Lorca', 'rlorca@tpc403.net', 985263798);
insert into empleado values('Lorena', 'Parra', 'lparra@tpc403.net', 936147258);

go
drop procedure sp_listar_empleado;
go
create procedure sp_listar_empleado
as
	select * from empleado;
go

drop procedure sp_buscar_empleado;
go
create procedure sp_buscar_empleado
@num int
as
	select * from empleado
	where num = @num;
go

drop procedure sp_insert_empleado;
go
create procedure sp_insert_empleado
@nombres varchar(50),
@apellidos varchar(50),
@email varchar(50),
@telefono int
as
	insert into empleado (nombres, apellidos, email, telefono)
	values(@nombres, @apellidos, @email, @telefono);
go

drop procedure sp_update_empleado;
go
create procedure sp_update_empleado
@num int,
@nombres varchar(50),
@apellidos varchar(50),
@email varchar(50),
@telefono int
as
	update empleado set  
	nombres = @nombres, 
	apellidos = @apellidos, 
	email = @email, 
	telefono = @telefono
	where num = @num;
go

drop procedure sp_delete_empleado;
go
create procedure sp_delete_empleado
@num int
as
	delete from empleado
	where num = @num;
go

select * from empleado;