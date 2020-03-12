Create table Product
(PID int primary key,
PName varchar(20)not null,
Price money,
Stock int)
insert into Product(PID,PName,Price,Stock)
select 1,'Mouse',400,100 union
select 2,'Keyboard',500,50