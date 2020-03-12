create function getemployee(@deptid varchar(30))
returns table
as
return select * from Employee where Deptid=@deptid

select * from dbo.getemployee('D0001')
