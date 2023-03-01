/*Roll up*/
SELECT Faculty, University, COUNT(*) AS TotalCourses
FROM FactCourses
INNER JOIN Courses ON FactCourses.CourseID = Courses.CourseID
GROUP BY Faculty, University WITH ROLLUP


/* Drill down*/
SELECT Faculty, University, Department, COUNT(*) AS TotalCourses
FROM FactCourses
INNER JOIN Courses ON FactCourses.CourseID = Courses.CourseID
GROUP BY GROUPING SETS ((Faculty, University, Department), (Faculty, University))

/* how many courses offered period */
/*how many offered in 2020*/
/*this year winter by computer science department*/