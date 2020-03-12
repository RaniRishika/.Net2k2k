-- Insert Stored Procedure
Create procedure InsertEmployee
@FirstName nvarchar(50),
@LastName nvarchar(50),
@Gender nvarchar(50),
@Salary int,
@DepartmentId int
as
Begin
     Insert into Employees(FirstName, LastName, Gender, Salary, DepartmentId)
     values (@FirstName, @LastName, @Gender, @Salary, @DepartmentId)
End
GO