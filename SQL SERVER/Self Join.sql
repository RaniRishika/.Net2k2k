-- display employee detials who are working on same dept as empid='E0001'

select e2.* from Employee e1,Employee e2 where e1.deptid=e2.deptid and e1.Empid='e0001'