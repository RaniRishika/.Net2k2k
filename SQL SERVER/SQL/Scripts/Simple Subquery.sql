USE pubs 
SELECT title, price, 
(SELECT AVG(price) FROM titles) AS average, price-(SELECT AVG(price) FROM titles) AS difference 
FROM titles 
WHERE type='popular_comp' 

USE pubs 
SELECT au_lname, au_fname 
FROM authors 
WHERE city = (SELECT city 
FROM publishers 
WHERE pub_name = 'Algodata Infosystems') 

USE pubs 
SELECT DISTINCT title 
FROM titles 
WHERE price > (SELECT MIN(price) 
FROM titles)

USE pubs 
SELECT au_lname, au_fname 
FROM authors 
WHERE city IN (SELECT city 
FROM publishers) 

USE pubs 
SELECT au_lname, au_fname 
FROM authors 
WHERE city = ANY (SELECT city 
FROM publishers) 