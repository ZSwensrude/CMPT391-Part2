-- Query 1: Count the total number of courses taught by each instructor
CREATE PROCEDURE dbo.CountCoursesByInstructor
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        SELECT Instructors.InstructorName, COUNT(*) AS TotalCourses
        FROM Instructors
        INNER JOIN FactCourses ON Instructors.InstructorID = FactCourses.InstructorID
        GROUP BY Instructors.InstructorName
        ORDER BY TotalCourses DESC;

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        PRINT ERROR_MESSAGE()
    END CATCH
END

-- Query 2: Count the total number of courses taken by students in each major
CREATE PROCEDURE dbo.CountCoursesByStudentMajor
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        SELECT Students.Major, COUNT(*) AS TotalCourses
        FROM Students
        INNER JOIN FactCourses ON Students.StudentID = FactCourses.StudentID
        GROUP BY Students.Major
        ORDER BY TotalCourses DESC;

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        PRINT ERROR_MESSAGE()
    END CATCH
END

-- Query 3: Count the total number of courses offered by each department
CREATE PROCEDURE dbo.CountCoursesByDepartment
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        SELECT Courses.Department, COUNT(*) AS TotalCourses
        FROM Courses
        INNER JOIN FactCourses ON Courses.CourseID = FactCourses.CourseID
        GROUP BY Courses.Department
        ORDER BY TotalCourses DESC;

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        PRINT ERROR_MESSAGE()
    END CATCH
END

-- Query 4: Count the total number of courses offered in each semester and year
CREATE PROCEDURE dbo.CountCoursesBySemYear
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        SELECT Dates.Semester, Dates.Year, COUNT(*) AS TotalCourses
        FROM Dates
        INNER JOIN FactCourses ON Dates.DateID = FactCourses.DateID
        GROUP BY Dates.Semester, Dates.Year
        ORDER BY Dates.Year DESC, Dates.Semester DESC;

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        PRINT ERROR_MESSAGE()
    END CATCH
END

-- Query 5: Count the total number of courses taught by each faculty member, grouped by department
CREATE PROCEDURE dbo.CountCoursesByTaught
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        SELECT Instructors.InstructorName, Courses.Department, COUNT(*) AS TotalCourses
        FROM Instructors
        INNER JOIN FactCourses ON Instructors.InstructorID = FactCourses.InstructorID
        INNER JOIN Courses ON FactCourses.CourseID = Courses.CourseID
        GROUP BY Instructors.InstructorName, Courses.Department
        ORDER BY Instructors.InstructorName ASC, TotalCourses DESC;

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        PRINT ERROR_MESSAGE()
    END CATCH
END


