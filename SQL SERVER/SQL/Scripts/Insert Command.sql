-- Insert Command

use Trng
go

insert into TB_Category(Category_Id,Category_Name)
values(1,'Mobiles')

insert into TB_Category(Category_Id,Category_Name)
(select * from T12)

select * from TB_Category

-- bulk insert operation
bulk insert TB_Category
from 'D:\Cat.txt'
with(
Datafiletype = 'Char',
FieldTerminator = ',',
Rowterminator = ';'
)