DECLARE @UniversityXML XML = '
<University_upload_2023-02-14>
  <Instructors>
    <Instructor>
      <InstructorID>1</InstructorID>
      <InstructorName>John Smith</InstructorName>
      <Faculty>Engineering</Faculty>
      <Rank>Associate Professor</Rank>
      <University>University of Alberta</University>
    </Instructor>
    <Instructor>
      <InstructorID>2</InstructorID>
      <InstructorName>Jane Doe</InstructorName>
      <Faculty>Science</Faculty>
      <Rank>Professor</Rank>
      <University>University of Calgary</University>
    </Instructor>
    <Instructor>
      <InstructorID>3</InstructorID>
      <InstructorName>Michael Johnson</InstructorName>
      <Faculty>Mathematics</Faculty>
      <Rank>Associate Professor</Rank>
      <University>University of Alberta</University>
    </Instructor>
    <Instructor>
      <InstructorID>4</InstructorID>
      <InstructorName>Sarah Lee</InstructorName>
      <Faculty>Computer Science</Faculty>
      <Rank>Professor</Rank>
      <University>University of Calgary</University>
    </Instructor>
    <Instructor>
      <InstructorID>5</InstructorID>
      <InstructorName>Tom Brown</InstructorName>
      <Faculty>Science</Faculty>
      <Rank>Assistant Professor</Rank>
      <University>University of Alberta</University>
    </Instructor>
    <Instructor>
      <InstructorID>6</InstructorID>
      <InstructorName>Amy Chen</InstructorName>
      <Faculty>Mathematics</Faculty>
      <Rank>Professor</Rank>
      <University>University of Calgary</University>
    </Instructor>
    <Instructor>
      <InstructorID>7</InstructorID>
      <InstructorName>James Wilson</InstructorName>
      <Faculty>Engineering</Faculty>
      <Rank>Associate Professor</Rank>
      <University>MacEwan University</University>
    </Instructor>
    <Instructor>
      <InstructorID>8</InstructorID>
      <InstructorName>Mary Taylor</InstructorName>
      <Faculty>Physics</Faculty>
      <Rank>Professor</Rank>
      <University>MacEwan University</University>
    </Instructor>
  </Instructors>
  <Courses>
    <Course>
      <CourseID>1</CourseID>
      <Department>Computer Science</Department>
      <Faculty>Engineering</Faculty>
      <University>University of Alberta</University>
    </Course>
    <Course>
      <CourseID>2</CourseID>
      <Department>Physics</Department>
      <Faculty>Science</Faculty>
      <University>University of Calgary</University>
    </Course>
    <Course>
      <CourseID>3</CourseID>
      <Department>Mathematics</Department>
      <Faculty>Science</Faculty>
      <University>University of Alberta</University>
    </Course>
    <Course>
      <CourseID>4</CourseID>
      <Department>Chemistry</Department>
      <Faculty>Science</Faculty>
      <University>MacEwan University</University>
    </Course>
    <Course>
      <CourseID>5</CourseID>
      <Department>Biology</Department>
      <Faculty>Science</Faculty>
      <University>University of Calgary</University>
    </Course>
    <Course>
      <CourseID>6</CourseID>
      <Department>Engineering</Department>
      <Faculty>Engineering</Faculty>
      <University>University of Alberta</University>
    </Course>
    <Course>
      <CourseID>7</CourseID>
      <Department>Psychology</Department>
      <Faculty>Social Science</Faculty>
      <University>University of Alberta</University>
    </Course>
    <Course>
      <CourseID>8</CourseID>
      <Department>Mathematics</Department>
      <Faculty>Science</Faculty>
      <University>University of Calgary</University>
    </Course>
    <Course>
      <CourseID>9</CourseID>
      <Department>Computer Science</Department>
      <Faculty>Engineering</Faculty>
      <University>University of Calgary</University>
    </Course>
    <Course>
      <CourseID>10</CourseID>
      <Department>Engineering</Department>
      <Faculty>Engineering</Faculty>
      <University>MacEwan University</University>
    </Course>
  </Courses>
  <Dates>
    <Date>
      <DateID>1</DateID>
      <Semester>Fall</Semester>
      <Year>2022</Year>
    </Date>
    <Date>
      <DateID>2</DateID>
      <Semester>Spring</Semester>
      <Year>2023</Year>
    </Date>
  </Dates>
</University_upload_2023-02-14>
'

-- Insert data into Instructors table
INSERT INTO Instructors (InstructorID, InstructorName, Faculty, Rank, University)
SELECT
    Instructor.value('InstructorID[1]', 'int') AS InstructorID,
    Instructor.value('InstructorName[1]', 'varchar(50)') AS InstructorName,
    Instructor.value('Faculty[1]', 'varchar(50)') AS Faculty,
    Instructor.value('Rank[1]', 'varchar(50)') AS Rank,
    Instructor.value('University[1]', 'varchar(50)') AS University
FROM @UniversityXML.nodes('/University_upload_2023-02-14/Instructors/Instructor') AS T(Instructor)

-- Insert data into Courses table
INSERT INTO Courses (CourseID, Department, Faculty, University)
SELECT
    Course.value('CourseID[1]', 'int') AS CourseID,
    Course.value('Department[1]', 'varchar(50)') AS Department,
    Course.value('Faculty[1]', 'varchar(50)') AS Faculty,
    Course.value('University[1]', 'varchar(50)') AS University
FROM @UniversityXML.nodes('/University_upload_2023-02-14/Courses/Course') AS T(Course)

-- Insert data into Dates table
INSERT INTO Dates (DateID, Semester, Year)
SELECT
    Date.value('DateID[1]', 'int') AS DateID,
    Date.value('Semester[1]', 'varchar(50)') AS Semester,
    Date.value('Year[1]', 'int') AS Year
FROM @UniversityXML.nodes('/University_upload_2023-02-14/Dates/Date') AS T(Date)

-- Insert data into FactCourses table
INSERT INTO FactCourses (CourseID, InstructorID, DateID, TotalCourses)
SELECT
    FactCourse.value('CourseID[1]', 'int') AS CourseID,
    FactCourse.value('InstructorID[1]', 'int') AS InstructorID,
    FactCourse.value('DateID[1]', 'int') AS DateID,
    FactCourse.value('TotalCourses[1]', 'int') AS TotalCourses
FROM @UniversityXML.nodes('/University_upload_2023-02-14/FactCourses/Course') AS T(FactCourse)

/*
TRUNCATE TABLE Courses
TRUNCATE TABLE Dates
TRUNCATE TABLE Instuctors
TRUNCATE TABLE FactCourses
*/