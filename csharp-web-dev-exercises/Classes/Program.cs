// TODO: Instantiate your objects and test your exercise solutions with print statements here.


using Classes;

Student aStudent = new Student("Dudeman", 1, 4.0);

Console.WriteLine(aStudent.Name);
Console.WriteLine(aStudent.StudentId);
Console.WriteLine(aStudent.NumberOfCredits);
Console.WriteLine(aStudent.Gpa);


Teacher aTeacher = new Teacher();
aTeacher.FirstName = "Billy";
aTeacher.LastName = "Bob";
aTeacher.YearsTeaching = 10;
aTeacher.Subject = "Programming";

Course aCourse = new Course();

aCourse.CourseTitle = "Program Awesomely";
aCourse.Teacher = aTeacher;

aCourse.StudentsList.Add(aStudent);


Console.WriteLine($"Course: {aCourse.CourseTitle} is taught by {aCourse.Teacher.FirstName} {aCourse.Teacher.LastName} and has {aStudent.Name} enrolled.");
