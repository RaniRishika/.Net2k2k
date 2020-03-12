-- In-Line Table Valued Function (Get Customer's Details)

alter function uft_TB_CUSTOMER_Get_Customers_Details()
returns table
as
	return (select Customer_Id,
			rtrim(First_Name) + ' ' + Last_Name 
			as [Full Name],Gender, Location 
			from TB_CUSTOMER)
			
create function uft_TB_CUSTOMER_Get_Customer_Details
(
@cid int
)
returns table
as
	return (select Customer_Id,
			rtrim(First_Name) + ' ' + Last_Name 
			as [Full Name],Gender, Location 
			from TB_CUSTOMER
			where Customer_Id = @cid)			

alter function uft_Get_Product_Details
(
@category_name char(25)
)
returns table
as
	return (select top 1000 p.Product_Id,
			rtrim(p.Product_Name)as [Product Name], 
			p.Unit_Price,p.Stock,c.Category_Name
			from TB_PRODUCT as p
			join TB_CATEGORY as c
			on p.Category_Id = c.Category_Id
			where c.Category_Name = @category_name
			order by p.Product_Name)