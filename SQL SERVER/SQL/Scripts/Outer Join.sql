select * from publishers
select * from authors
-- Left outer join
select a.au_fname,p.pub_name
from authors as a
left join publishers as p
on a.city = p.city

-- Right outer join
select a.au_fname,p.pub_name
from authors as a
right join publishers as p
on a.city = p.city

-- full outer join
select a.au_fname,p.pub_name
from authors as a
full join publishers as p
on a.city = p.city