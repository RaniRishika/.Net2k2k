-- Update Stored Procedure
Create procedure UpdateEmployee
@ID int,
@FirstName nvarchar(50),
@LastName nvarchar(50),
@Gender nvarchar(50),
@Salary int,
@DepartmentId int
as
Begin
     Update Employees Set
     FirstName = @FirstName, LastName = @LastName, Gender = @Gender,
     Salary = @Salary, DepartmentId = @DepartmentId
     where ID = @ID
End
GO