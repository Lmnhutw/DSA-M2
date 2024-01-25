using System;
using System.Collections.Specialized;
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

    public static void DisplayInfo(Student[] students)
    {
        foreach (var Student in students)
        {
            Console.WriteLine($"Name: {Student.Name} - Age: {Student.Age} - Class: {Student.ClassName}");
        }
    }
    public void Delete()
    {
        Name = string.Empty;
        Age = 0;
        ClassName = string.Empty;
        Console.WriteLine("Dữ liệu của sinh viên đã bị xóa");

    }

    public static void SearchingName(Student[] students, string name)
    {
        int Count = 0;
        foreach (var Student in students)
        {
            if (Student.Name == name)
            {
                Count++;
                Console.WriteLine($"Tìm thấy sinh viên {name}");
                break;
            }
            else
            {
                Console.WriteLine($"Không tìm thấy sinh viên {name}");
            }
        }
    }

    public static Student FindOldestStudent(Student[] students)
    {
        Student oldestStudent = students[0];
        foreach (var Student in students)
        {
            if (Student.Age > oldestStudent.Age)
            {
                oldestStudent = Student;
            }
        }
        Console.WriteLine($"Sinh vien {oldestStudent.Name} có số tuổi lớn nhất là {oldestStudent.Age}");
        return oldestStudent;
    }

    public static Student FindYoungestStudent(Student[] students)
    {
        Student youngestStudent = students[0];
        foreach (var Student in students)
        {
            if (Student.Age < youngestStudent.Age)
            {
                youngestStudent = Student;
            }
        }
        Console.WriteLine($"Sinh vien {youngestStudent.Name} có số tuổi nhỏ nhất là {youngestStudent.Age}");
        return youngestStudent;
    }

    public static void SwapStudent(Student[] students, int index1,  int index2)
    {
        Student temp = students[index1];
        students[index1] = students[index2];
        students[index2] = temp;

        Console.WriteLine($"Danh sách sinh viên sau khi đổi là: ");
        Student.DisplayInfo(students);
    }


    class Program
    {
        static void Main(string[] args)
        {

            Student std1 = new Student("Nguyễn Văn A", 10, "5D4");
            Student std2 = new Student("Nguyễn Văn B", 9, "4C3");
            Student std3 = new Student("Nguyễn Văn C", 8, "3B2");
            Student std4 = new Student("Nguyễn Văn D", 7, "2A1");

            Student[] students = new Student[]
            {
                std1,
                std2,
                std3,
                std4
            };


            Student.DisplayInfo(students);
            Student.SearchingName(students, "Nguyễn Văn A");
            Student.FindOldestStudent(students);
            Student.FindYoungestStudent(students);
            Student.SwapStudent(students, 0, 3);

            // foreach (var Student in Student)
            // {
            //     Student.Delete();
            // }    
        }
    }
}