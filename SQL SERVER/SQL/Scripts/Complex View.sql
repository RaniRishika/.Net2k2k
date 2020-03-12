-- Complex View

alter view VW_Product_Details
as
select p.Product_Id,
p.Product_Name,p.unit_price,
p.stock,c.Category_Name,c.description 
from TB_PRODUCT as p
join TB_CATEGORY as c
on p.Category_Id = c.Category_Id

select * from VW_Product_Details

update VW_Product_Details
set unit_price = 50000, description='oops'
where product_id = 30