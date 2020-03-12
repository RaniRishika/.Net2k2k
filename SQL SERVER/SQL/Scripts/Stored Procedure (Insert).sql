-- Stored Procedure which Inserts Data

create proc proc_Add_Category
(
@category_id int,
@category_Name char(25),
@description varchar(500)
)
as
begin
	if @category_id <= 0
		raiserror('Customer id cant be less than 1',10,1)
	else
	begin
		if @category_Name = null
			raiserror('Customer name is required',10,1)
		else
			insert into TB_CATEGORY
			(Category_Id,Category_Name,description)
			values(@category_Id,@category_Name,@description)
	end
end