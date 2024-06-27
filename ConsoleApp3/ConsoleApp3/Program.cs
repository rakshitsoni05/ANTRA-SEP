// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

using ConsoleApp3;
using ConsoleApp3.Classes;

ReverseAndPrint rp = new ReverseAndPrint();
int[] nums = rp.GenerateNumbers(10);
rp.PrintNumbers(nums);
rp.Reverse(nums);
rp.PrintNumbers(nums);

Fibonacci fibonacci = new Fibonacci();
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Fibonacci({i}) = {fibonacci.FibonacciSeries(i)}");
}

Console.WriteLine("---------------------------------------------------");

Student student = new Student("Rakshit", new DateTime(2000, 8, 7), 0);
Instructor instructor = new Instructor("Mrs. Anjila", new DateTime(1995, 1, 1), 80000, new DateTime(2015, 1, 1));
Department department = new Department("Computer Science", 1000000);
Course course1 = new Course("SQL");
Course course2 = new Course("C#");
department.AddCourse(course1);
department.AddCourse(course2);
instructor.AssignDepartment(department);
student.EnrollInCourse(course1);
student.EnrollInCourse(course2);
student.SetGrade(course1, 95.0);
student.SetGrade(course2, 96.5);
List<Course> NoOfCourses = department.GetAllCourses();
Console.WriteLine($"Student : {student.Name}, Age: {student.CalculateAge()}, GPA: {student.CalculateGPA()}");
Console.WriteLine($"Instructor : {instructor.Name}, Age: {instructor.CalculateAge()}, Salary: {instructor.CalculateSalary()}");
Console.WriteLine($"Department : {department.Name}, Head : {department.Head.Name} ");
Console.WriteLine("List of courses in Department: ");
for (int i = 0; i < NoOfCourses.Count; i++)
{
    Console.WriteLine(NoOfCourses[i].Name);
}
