use trng
go

-- stored procedure (read all data)
alter proc proc_Get_All_Customers
as
begin
	select Customer_Id,First_Name,Gender
	from TB_CUSTOMER
end

-- stored procedure (read all data by condition)
create proc proc_Get_Customers_Details_By_Id
(
@customer_id int
) 
as
begin
	select Customer_Id,First_Name,Gender
	from TB_CUSTOMER
	where Customer_Id = @customer_Id
end