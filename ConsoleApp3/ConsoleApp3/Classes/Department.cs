using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Classes;

public class Department : IDepartmentService
{
    public string Name { get; set; }
    public Instructor Head { get;  set; }
    public decimal Budget { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();

    public Department(string name, decimal budget)
    {
        Name = name;
        Budget = budget;
    }

    public void SetHead(Instructor head)
    {
        Head = head;
    }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }

    public List<Course> GetAllCourses()
    {
        return Courses;
    }
}