create table TB_SAMPLE_TABLE
(
Id int not null,
Name char(25) not null,
Gender char(1) not null
)

insert into TB_SAMPLE_TABLE
values(1, 'Adam','M')
insert into TB_SAMPLE_TABLE
values(2, 'Tom','M')
insert into TB_SAMPLE_TABLE
values(3, 'John','A')

select * from TB_SAMPLE_TABLE