create procedure sp_GetProducts
as
begin
select * from Product
end

create procedure sp_GetProductById(@id int)
as
begin
select * from Product where PID=@id
end

create procedure sp_Insert(@pid int,@Pname varchar(30),@price money,@stock int)
as
begin
insert into Product values(@pid,@Pname,@price,@stock)
end

create procedure sp_delete(@pid int)
as
begin
delete from Product where PID=@pid
end

create procedure sp_Update(@pid int,@Pname varchar(30),@price money,@stock int)
as
begin
update Product set Price=@price,Stock=@stock where PID=@pid
end
