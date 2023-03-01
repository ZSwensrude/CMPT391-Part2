Create table Date (
DID int primary key , 
year int,
semester varchar(30));

declare @yearIndex int
declare @yearID int
set @yearID = 1
set @yearIndex = 1990
while @yearIndex <= 2022
begin
	insert into Date values(@yearID, @yearIndex, 'Fall')
	select @yearID = @yearID + 1
	
	insert into Date values(@yearID, @yearIndex, 'Winter') 
	select @yearID = @yearID + 1
	
	insert into Date values(@yearID, @yearIndex, 'Spring/Summer');
	select @yearID = @yearID + 1
	select @yearIndex = @yearIndex + 1
	
end

