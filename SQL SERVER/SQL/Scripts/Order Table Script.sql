-- Order

create table TB_Order
(
Order_Id int not null,
OrderDate date not null,
Quantity smallint not null,
Total money not null,
Deliver_Date date null,
Customer_Id int not null,
Product_Id int not null
)