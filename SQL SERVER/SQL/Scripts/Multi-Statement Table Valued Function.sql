-- Multi-Statement Table Valued Function

create function uft_Get_Products_Details_By_Category_Name
(
@cname char(25)
)
returns @t table
(
Pid int primary key,
PName char(25) unique not null,
UnitPrice money ,
Stock int,
Category_Name char(25) not null
)
as
begin
	insert into @t select top 1000 p.Product_Id,
			rtrim(p.Product_Name)as [Product Name], 
			p.Unit_Price,p.Stock,c.Category_Name
			from TB_PRODUCT as p
			join TB_CATEGORY as c
			on p.Category_Id = c.Category_Id
			where c.Category_Name = @cname
			order by p.Product_Name
	return
end