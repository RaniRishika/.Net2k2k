Create procedure GetEmployeesByDepartment
@DepartmentId int,
@DepartmentName nvarchar(50) out
as
Begin
     Select @DepartmentName = Name
     from Departments where ID = @DepartmentId

     Select * from Employees
     where DepartmentId = @DepartmentId

End