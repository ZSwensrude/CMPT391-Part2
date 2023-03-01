-- Create Instructors Dimension Table
CREATE TABLE Instructors (
InstructorID INT PRIMARY KEY,
InstructorName VARCHAR(50),
Faculty VARCHAR(50),
Rank VARCHAR(50),
University VARCHAR(50)
);

-- Create Courses Dimension Table
CREATE TABLE Courses (
CourseID INT PRIMARY KEY,
Department VARCHAR(50),
Faculty VARCHAR(50),
University VARCHAR(50)
);

-- Create Date Dimension Table
CREATE TABLE Dates (
DateID INT PRIMARY KEY,
Semester VARCHAR(10),
Year INT
);

-- Create Fact Table
CREATE TABLE FactCourses (
CourseID INT,
InstructorID INT,
StudentID INT,
DateID INT,
TotalCourses INT,
FOREIGN KEY (CourseID) REFERENCES Courses (CourseID),
FOREIGN KEY (InstructorID) REFERENCES Instructors (InstructorID),
FOREIGN KEY (DateID) REFERENCES Dates (DateID)
);

-- Create clustered index on Fact table for better performance
CREATE CLUSTERED INDEX cx_FactCourses ON FactCourses (DateID, InstructorID, StudentID, CourseID);

Select * from Courses
Select * from Instructors
Select * from Dates
Select * from FactCourses