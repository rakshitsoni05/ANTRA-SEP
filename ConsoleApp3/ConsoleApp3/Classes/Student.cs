using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Classes;

public class Student : Person, IStudentService
{
    public Dictionary<Course, double> CourseGrades  = new Dictionary<Course, double>();

    public Student(string name, DateTime dateOfBirth, decimal salary) 
        : base(name, dateOfBirth, salary) {}

    public void EnrollInCourse(Course course)
    {
        if (!CourseGrades.ContainsKey(course))
        {
            CourseGrades[course] = 0; 
            course.AddStudent(this);
        }
    }

    public void SetGrade(Course course, double grade)
    {
        if (CourseGrades.ContainsKey(course))
        {
            CourseGrades[course] = grade;
        }
    }

    public double CalculateGPA()
    {
        double totalMarks= 0;
        int totalCourses = CourseGrades.Count;

        foreach (var grade in CourseGrades.Values)
        {
            totalMarks += grade;
        }

        if (totalCourses > 0)
        {
            return totalMarks / totalCourses;
        }
        else
        {
            return 0;
        }
    }
}

