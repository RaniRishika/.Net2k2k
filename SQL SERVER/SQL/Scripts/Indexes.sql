create table TB_T1  -- Heap
(
Id int not null,
Name char(25) not null,
Location varchar(50)
)

insert into TB_T1(Id,Name,Location)
values (4,'Smith','Chennai')
insert into TB_T1(Id,Name,Location)
values (1,'Adam','Delhi')
insert into TB_T1(Id,Name,Location)
values (3,'John','Mumbai')
insert into TB_T1(Id,Name,Location)
values (2,'Cathy','Kolkata')

select * from TB_T1
where id = 3

create unique clustered index
ixc_TB_T1_Id on TB_T1(Id)

create nonclustered index
ixn_TB_T1_Location on TB_T1(Location)

drop index ixn_TB_T1_Location on TB_T1

alter table TB_T1
add constraint pkc_TB_T1_Id primary key (Id)

-- Check if Indexes are used?
-- 1. Clustered Index
select * from TB_T1
where Id = 1

-- 2. Non Clustered
select Id from TB_T1
where Location like '%i%'

drop table TB_T1