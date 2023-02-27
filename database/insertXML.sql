DECLARE @UniversityXML XML = '
<?xml version="1.0" encoding="UTF-8"?>
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
  </Instructors>
  <Students>
    <Student>
      <StudentID>1</StudentID>
      <StudentName>Bob Smith</StudentName>
      <Major>Computer Science</Major>
      <Gender>Male</Gender>
    </Student>
    <Student>
      <StudentID>2</StudentID>
      <StudentName>Alice Johnson</StudentName>
      <Major>Physics</Major>
      <Gender>Female</Gender>
    </Student>
  </Students>
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
  <FactCourses>
    <Course>
      <CourseID>1</CourseID>
      <InstructorID>1</InstructorID>
      <StudentID>1</StudentID>
      <DateID>1</DateID>
      <TotalCourses>3</TotalCourses>
    </Course>
    <Course>
      <CourseID>2</CourseID>
      <InstructorID>2</InstructorID>
      <StudentID>2</StudentID>
      <DateID>2</DateID>
      <TotalCourses>5</TotalCourses>
    </Course>
  </FactCourses>
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

-- Insert data into Students table
INSERT INTO Students (StudentID, StudentName, Major, Gender)
SELECT
    Student.value('StudentID[1]', 'int') AS StudentID,
    Student.value('StudentName[1]', 'varchar(50)') AS StudentName,
    Student.value('Major[1]', 'varchar(50)') AS Major,
    Student.value('Gender[1]', 'varchar(50)') AS Gender
FROM @UniversityXML.nodes('/University_upload_2023-02-14/Students/Student') AS T(Student)

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
INSERT INTO FactCourses (CourseID, InstructorID, StudentID, DateID, TotalCourses)
SELECT
    FactCourse.value('CourseID[1]', 'int') AS CourseID,
    FactCourse.value('InstructorID[1]', 'int') AS InstructorID,
    FactCourse.value('StudentID[1]', 'int') AS StudentID,
    FactCourse.value('DateID[1]', 'int') AS DateID,
    FactCourse.value('TotalCourses[1]', 'int') AS TotalCourses
FROM @UniversityXML.nodes('/University_upload_2023-02-14/FactCourses/Course') AS T(FactCourse)
