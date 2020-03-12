--Multistatement function
--create a function which returns empno,empname,hiredate of given deptid
create function getEmpbyDeptid(@deptid varchar(30))
returns @t1 table(empid varchar(30),empname varchar(30),hiredate datetime)
as
begin
insert into @t1(empid,empname,hiredate)
select empid,empname,hiredate from Employee where Deptid=@deptid
return
end
select * from dbo.getEmpbyDeptid('D0001')