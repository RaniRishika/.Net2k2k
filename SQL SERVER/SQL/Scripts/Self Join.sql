-- Self Join

-- Manager Name : John
-- Developer Info
use Trng
go
select e.Ename,e.Location from Emp as e
join Emp as m
on e.Mid = m.eid
where m.Ename = 'John'

select m.Ename,m.Location from emp as e
join emp as m
on m.eid = e.mid
where e.ename = 'Abdul'