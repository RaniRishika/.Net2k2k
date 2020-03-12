-- cast (exp as DT)
select cast(year('2014-10-9 16:20:12')as char(4))+'A'

-- Convert(DT, exp, [s])
select convert(char(4),year('2014-10-9 16:20:12'))

select convert(char(12), getdate(),100)