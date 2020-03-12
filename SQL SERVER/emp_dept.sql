create table Dept
(Did char(10) primary key,Dname varchar(20) unique not null)
create table Employee(
Eid int Primary key,Ename varchar(20) not null,Desig varchar(30),
Sal money ,Hiredate datetime default getdate(),
Did char(10) foreign key references Dept(Did))
insert into Dept
select 'IT','InformationTech' union
select 'BFS','BankingAndFinance'
insert into Dept values('CF','CampusForce') 
insert into Employee
select 1,'rajan','TL',12000,GETDATE(),'IT' union
select 2,'karan','PL',22000,GETDATE(),'BFS' union
select 3,'suren','TL',32000,GETDATE(),'IT' union
select 4,'peter','PL',42000,GETDATE(),'BFS' union
select 5,'mohan','TL',52000,GETDATE(),'IT' union
select 9,'mohan','TL',52000,GETDATE(),'BFS' union
select 6,'david','PL',92000,GETDATE(),'BFS' union
select 7,'peter','TL',23000,GETDATE(),'IT' union
select 8,'robert','PL',82000,GETDATE(),'BFS'
truncate table employee
