use pubs
go

select p.pub_id,title from titles
cross join publishers p