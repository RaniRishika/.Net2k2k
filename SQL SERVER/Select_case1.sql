create table Gender(name varchar(30),gender varchar(10))
insert into Gender(name,gender)
select 'latha','f' union
select 'mahesh','m' union
select 'peter','m' union
select 'devi','f'

select name,gender,case Gender
when 'm' then 'Male'
when 'f' then 'Female'
else 'others' 
end 'gender info' from Gender  