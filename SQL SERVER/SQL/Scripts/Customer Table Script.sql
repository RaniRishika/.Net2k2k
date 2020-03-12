use Trng
go

create table TB_CUSTOMER
(
Customer_Id int not null,
First_Name char(25) not null,
Last_Name char(25),
Gender char(1) not null,
Location char(25),
Zipcode int,
[User_Name] varchar(50) not null,
[Password] varchar(50) not null,
)