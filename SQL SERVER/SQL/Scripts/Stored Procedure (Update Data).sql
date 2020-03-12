-- Stored Procedure to Update Data

create proc proc_Edit_Category
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
			update TB_CATEGORY
			set Category_Name=@category_Name,
			description = @description
			where Category_Id = @category_Id
	end
end