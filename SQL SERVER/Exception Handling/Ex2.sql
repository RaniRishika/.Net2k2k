create procedure sp_add(@a varchar(20),@b varchar(20))
as
begin
declare @a1 int
declare @b1 int 
declare @res int
begin try
set @a1=CONVERT(int,@a)
set @b1=CONVERT(int,@b)
set @res=@a1+@b1
return @res
end try
begin catch
select ERROR_MESSAGE()
end catch
end
declare @d int
exec @d=sp_add 'c','d'
select @d