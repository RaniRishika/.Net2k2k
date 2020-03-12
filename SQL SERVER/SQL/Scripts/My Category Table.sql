create table TB_MY_CATEGORY
(
Category_Id int identity(1000,2) primary key,
Category_Name char(25) unique not null,
[Description] varchar(500) default 'Not Assigned'
)