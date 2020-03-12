create table TB_T12
(
Id int identity(1,1),
Name char(25)
)
insert into TB_T12(Name)values('AAA')
insert into TB_T12(Name)values('BBB')
insert into TB_T12(Name)values('CCC')
select * from TB_T12
insert into TB_T12(Name)values('DDD')

delete from TB_T12
truncate table TB_T12