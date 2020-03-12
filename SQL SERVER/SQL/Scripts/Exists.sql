-- Exists
USE pubs
go

SELECT au_lname, au_fname 
FROM authors 
WHERE exists(
SELECT * 
FROM publishers 
WHERE authors.city = publishers.city
)

SELECT lastname, employeeid
FROM  EMPLOYEES AS e
WHERE EXISTS 
(
SELECT * FROM ORDERS AS o
WHERE e.employeeid = o.employeeid
AND  o.orderdate = '9/5/97')
