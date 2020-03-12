-- While loop
declare @i int,@n char(2)
set  @i = 1
while @i < 10
begin
	print 'i: ' + cast(@i as char(2))
	set @i = @i + 1
end