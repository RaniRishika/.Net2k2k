-- Multi Line Command to Create a Database
create database Trng
on primary
(
Name='Trng_Data',
FileName = 'E:\Training\Data\Trng_Data.mdf',
size = 10,
FileGrowth= 5,
maxsize=100
)
log on
(
Name='Trng_Log',
FileName = 'E:\Training\Log\Trng_Log.ldf',
size = 3,
FileGrowth= 35%,
maxsize=40
)

-- delete the database
drop database trng
