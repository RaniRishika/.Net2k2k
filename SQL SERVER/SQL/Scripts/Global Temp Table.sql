create table ##Temp
(
Id int not null,
Name char(25) not null
)

insert into #Temp
values(1, 'ABC')
insert into #Temp
values(2, 'XYZ')

select * from #Temp