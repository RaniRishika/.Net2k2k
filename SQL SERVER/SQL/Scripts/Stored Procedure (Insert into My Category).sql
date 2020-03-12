alter proc proc_Add_My_Category
(
@category_name char(25),
@description varchar(500),
@category_id int output
)
as
begin
	if @category_name = null
		raiserror('Category Name is required',10,1)
	else
		insert into TB_MY_CATEGORY
		(Category_Name,Description)
		values(@Category_Name,@Description)
		
		set @category_id = scope_identity()
end