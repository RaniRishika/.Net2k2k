use trng
go
-- Case Block
select Eid,Ename, case Mid
when 0 then 'Manager'
when 1 then 'Developer'
when 2 then 'Developer'
end as [Role] from Employee

-- If Else Block
if suser_sname() = 'sa'
begin
	raiserror('Only sa login can call this block',16,1)	
end
else
begin
	select * from Employee
end