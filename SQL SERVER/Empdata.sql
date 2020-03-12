
create table Employee(Empid varchar(10) primary key,EmpName varchar(30),
Email varchar(30),MobileNo varchar(30),HireDate date,DeptId varchar(30))
insert into Employee(Empid,Empname,Email,MobileNo,Hiredate,deptid)
select 'E0002', 'Peter','peter@gmail.com','9098789789','04/09/2012','D0002' union
select 'E0003', 'Rajan','rajan@gmail.com','7098789789','04/09/2012','D0003' union
select 'E0004', 'Robert','robert@gmail.com','8098789789','04/09/2012','D0004' union
select 'E0005', 'Rakesh','rakesh@gmail.com','9198789789','04/09/2012','D0003' union
select 'E0006', 'Suresh','suresh@gmail.com','9298789789','04/09/2012','D0002' union
select 'E0007', 'Suren','suren@gmail.com','9398789789','04/09/2012','D0001' union
select 'E0008', 'Mark','mark@gmail.com','9498789789','04/09/2012','D0002' union
select 'E0009', 'jeson','jeson@gmail.com','9598789789','04/09/2012','D0003' union
select 'E0010', 'jesica','jesica@gmail.com','9698789789','04/09/2012','D0004' 