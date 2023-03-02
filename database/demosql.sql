/****** Script for SelectTopNRows command from SSMS  ******/
select * from Course
select * from Date
select * from Instructor
select * from Fact

DELETE FROM Instructor WHERE IID = 77
DELETE FROM Course WHERE CID = 245
DELETE FROM Date WHERE DID = 101
DELETE FROM Fact WHERE IID = 1 AND CID = 1 AND DID = 1 AND no_of_course = 1