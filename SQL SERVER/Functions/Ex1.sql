-- create scalar function
create function fn_Add(@a int,@b int)
returns int
as 
begin
declare @res int
set @res=@a+@b
return @res
end
-- call a functions
select dbo.fn_Add(2,3)