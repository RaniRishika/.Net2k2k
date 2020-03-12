create function getDeptnamebyId(@empid varchar(30))
returns varchar(30)
as
begin
declare @deptname varchar(30)
select @deptname=d.deptname from employee e inner join dept d on e.deptid=d.deptid where e.empid=@empid
return (@deptname)
end

