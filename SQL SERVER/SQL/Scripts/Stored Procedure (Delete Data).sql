-- Stored Procedure to Delete Data

create proc proc_Delete_Category
(
@category_id
)
as
begin
	if @category_id <= 0
		raiserror('Category id cant be less than 1',10,1)
	else
		delete from TB_CATEGORY
		where Category_Id = @category_id
end