-- Create a new Login
create login Umesh
with Password = 'umesh@123', 
Default_DataBase =Trng

-- Create a database user
create user Dev for login Umesh
go

grant select on TB_CUSTOMER to Dev