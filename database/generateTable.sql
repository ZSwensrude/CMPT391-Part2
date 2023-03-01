-- Create Instructors Dimension Table
CREATE TABLE Instructors (
InstructorID INT PRIMARY KEY,
InstructorName VARCHAR(50),
Title VARCHAR(50),
Department VARCHAR(50),
Gender VARCHAR(50), 
);

-- Create Courses Dimension Table
CREATE TABLE Courses (
CourseID INT PRIMARY KEY,
Title VARCHAR(50), 
Department VARCHAR(50),
NoOfCredits INT,
);

-- Create Date Dimension Table
CREATE TABLE Dates (
DateID INT PRIMARY KEY,
Year INT, 
Term VARCHAR(10),
);

-- Create Fact Table
CREATE TABLE FactCourses (
CourseID INT,
InstructorID INT,
DateID INT,
NoOfCourse INT,
FOREIGN KEY (CourseID) REFERENCES Courses (CourseID),
FOREIGN KEY (InstructorID) REFERENCES Instructors (InstructorID),
FOREIGN KEY (DateID) REFERENCES Dates (DateID)
);

-- Create clustered index on Fact table for better performance
CREATE CLUSTERED INDEX cx_FactCourses ON FactCourses (DateID, InstructorID, CourseID);

Select * from Courses
Select * from Instructors
Select * from Dates
Select * from FactCourses