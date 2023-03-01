CREATE TABLE Course (
CID int primary key,
title varchar(10),
credits int,
Dept_Name varchar(30));

--Populate Course table---------------------------------------------------
declare @courseIndex int
select @courseIndex = 100
declare @courseID int
select @courseID = 1

while @courseIndex >= 100 and @courseIndex <= 500
begin
	INSERT INTO Course VALUES(@courseID, 'CMPT' + convert(varchar(5), @courseIndex), 3, 'Computer Science')
	select @courseIndex = @courseIndex + 5
	select @courseID = @courseID + 1
end

select @courseIndex = 100

while @courseIndex >= 100 and @courseIndex <= 500
begin
	INSERT INTO Course VALUES(@courseID, 'BUSN' + convert(varchar(5), @courseIndex), 3, 'Business')
	select @courseIndex = @courseIndex + 5
	select @courseID = @courseID + 1
end

select @courseIndex = 100

while @courseIndex >= 100 and @courseIndex <= 500
begin
	INSERT INTO Course VALUES(@courseID, 'MATH' + convert(varchar(5), @courseIndex), 3, 'Mathematics')
	select @courseIndex = @courseIndex + 5
	select @courseID = @courseID + 1
end
