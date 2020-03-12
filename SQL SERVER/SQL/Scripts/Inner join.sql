-- inner join

use pubs
go

select t.title,a.au_fname,p.pub_name 
from titles as t
join publishers as p
on p.pub_id = t.pub_id
join titleauthor as ta
on t.title_id = ta.title_id
join authors as a
on ta.au_id = a.au_id
where a.city = 'Oakland'