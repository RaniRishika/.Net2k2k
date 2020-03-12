select c.name as [Column Name],
ty.name as [Data Type],
c.max_length as [Size] 
from sys.tables as t
join sys.columns as c
on t.object_id = c.object_id
join sys.systypes as ty
on c.system_type_id = ty.xtype
where t.name = 'TB_CUSTOMER'