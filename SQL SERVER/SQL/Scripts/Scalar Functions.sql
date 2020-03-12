use trng
go

-- Scalar Function (get max salary from employee table)
alter function ufs_decimal_Get_Max_Salary()
returns decimal
with encryption
as
begin
	declare @max_sal decimal
	set @max_sal = (select max(salary) from Employee)
	return @max_sal
end

-- Scalar Function (get full name of a customer)
alter function ufs_varchar_Get_Full_Name
(
@cid int
)
returns varchar(50)
with encryption
as
begin
	declare @full_name varchar(50)
	set @full_name = (select rtrim(First_Name) + ' ' + rtrim(Last_Name)
					from TB_CUSTOMER
					where Customer_Id = @cid)
	return @full_name
end

-- Scalar Function (get customer id of a customer)
alter function ufs_int_Get_Customer_Id
(
@uname varchar(50)
)
returns int
with encryption
as
begin
	declare @cid int
	set @cid = (select Customer_Id
					from TB_CUSTOMER
					where [User_Name] = @uname)
	return @cid
end