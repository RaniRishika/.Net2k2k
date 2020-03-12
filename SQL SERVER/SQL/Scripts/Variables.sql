-- Variables

use pubs 
go
-- Simple declare, assign and print
declare @id varchar(11)
set @id = '172-32-1176'
print @id

-- Simple declare, assign value from table column
-- and the print it back
declare @fname varchar(20)
set @fname = (select au_fname from authors
			  where au_id = '172-32-1176')
print @fname

-- Simple declares, assign value from table columns
-- and the print it back
declare @fname varchar(20),@lname varchar(40)
select @fname = au_fname,@lname = au_lname from authors
where au_id = '172-32-1176'
print @fname + ' ' + @lname 			  