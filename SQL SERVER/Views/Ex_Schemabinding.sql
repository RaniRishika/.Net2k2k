create view Emp_schema
with schemabinding
as
select e.empid,e.empname,v.pwd from dbo.Emp e join dbo.Validate v on e.Empid=v.Empid
