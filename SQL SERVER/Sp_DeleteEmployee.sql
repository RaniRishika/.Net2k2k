-- Delete Stored Procedure
Create procedure DeleteEmployee
@ID int
as
Begin
     Delete from Employees where ID = @ID
End
GO