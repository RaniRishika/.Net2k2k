CREATE VIEW [DBO].vw_ViewProducts

AS

 SELECT 
    ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued
 FROM Products
GO
select * from vw_ViewProducts
INSERT INTO [DBO].vw_ViewProducts(ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued)
VALUES('Test View',1,2,'100 per bag',25.45,89,57,15,0)
delete from vw_ViewProducts where ProductId=78
update vw_ViewProducts set ProductName='Top VIew' where ProductId=77
sp_helptext vw_ViewProducts
create view vw_name
with encryption
as
select * from products
sp_helptext vw_name
 
