-- Delete Stored Procedure
Create procedure SearchEmployeeById
@ID int
as
Begin
     Select * from Employees where ID = @ID
End
GO