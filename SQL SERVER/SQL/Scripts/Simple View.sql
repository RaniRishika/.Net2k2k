-- Simple View
use Trng
go

alter view VW_Customer_Details
with encryption,schemabinding
as
select Customer_Id,First_Name,Last_Name,
Location,Zipcode
from dbo.TB_CUSTOMER

select * from VW_Customer_Details

update VW_Customer_Details
set Location = 'Bangalore'
where Customer_Id = 1

select * From TB_Customer
