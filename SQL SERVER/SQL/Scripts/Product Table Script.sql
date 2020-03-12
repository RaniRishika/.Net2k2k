-- Product

create table TB_PRODUCT
(
Product_Id int not null,
Product_Name char(25) not null,
[Description] varchar(500),
Unit_Price money not null,
Stock int not null,
Category_Id int null
)