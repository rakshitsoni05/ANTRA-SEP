using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Classes;

public class Course : ICourseService
{
    public string Name { get; set; }
    public List<Student> EnrolledStudents  = new List<Student>();

    public Course(string name)
    {
        Name = name;
    }

    public void AddStudent(Student student)
    {
        if (!EnrolledStudents.Contains(student))
        {
            EnrolledStudents.Add(student);
        }
    }
}
