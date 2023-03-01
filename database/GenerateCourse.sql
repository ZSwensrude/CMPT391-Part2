CREATE TABLE Course (
CourseID varchar(30) primary key,
title varchar(30),
credits int,
Dept_Name varchar(30));

--Populate Course table---------------------------------------------------
declare @courseIndex int
select @courseIndex = 100

while @courseIndex >= 100 and @courseIndex <= 500
begin
	INSERT INTO Course VALUES('CMPT' + convert(varchar(5), @courseIndex), 'CS', 3, 'Computer Science')
	select @courseIndex = @courseIndex + 5
end

select @courseIndex = 100

while @courseIndex >= 100 and @courseIndex <= 500
begin
	INSERT INTO Course VALUES('BUSN' + convert(varchar(5), @courseIndex), 'busn', 3, 'Business')
	select @courseIndex = @courseIndex + 5
end

select @courseIndex = 100

while @courseIndex >= 100 and @courseIndex <= 500
begin
	INSERT INTO Course VALUES('MATH' + convert(varchar(5), @courseIndex), 'math', 3, 'Mathematics')
	select @courseIndex = @courseIndex + 5
end