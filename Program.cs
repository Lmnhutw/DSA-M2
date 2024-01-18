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
            Student[] students = new Student[4];
            students[0]  = new Student("Nguyễn Văn A", 10, "5D4");
            students[1]  = new Student ("Nguyễn Văn B", 9, "4C3");
            students[2]  = new Student("Nguyễn Văn D", 8, "3B2");
            students[3]  = new Student("Nguyễn Văn D", 7, "2A1");
            
            
        foreach (var Student in students )
        {
            Student.DisplayInfo();
        }
        // foreach (var Student in students)
        // {
        //     Student.Delete();
        // }
            

            
        }
    }
}