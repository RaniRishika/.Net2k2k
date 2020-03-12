create table First(Id int,Name varchar(10))
create table Second(Id int,Name varchar(10))
insert into First values(1,'ram')
insert into First values(2,'karan')
insert into First values(3,'robert')
insert into First values(5,'jeson')

insert into Second values(1,'ram')
insert into Second values(2,'karan')
insert into Second values(4,'david')

select id,name from First union select id,name from second
select id,name from First union all select id,name from second
select id,name from First intersect select id,name from second
select id,name from First except select id,name from second
