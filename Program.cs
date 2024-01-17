using System;
using System.Security.AccessControl;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string ClassName { get; set; }

    public Student(string name, int age, string classname)
    {
        Name = name;
        Age = age;
        ClassName = classname;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name} - Age: {Age} - Class: {ClassName}");
    }
    public void Delete()
    {
        Name = string.Empty;
        Age = 0;
        ClassName = string.Empty;
        Console.WriteLine("Dữ liệu của sinh viên đã bị xóa");
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Nguyễn Văn A", 6, "1A3");
            student.DisplayInfo();

            student.ClassName = "1A7";
            student.DisplayInfo();
            student.Delete();

        }
    }
}