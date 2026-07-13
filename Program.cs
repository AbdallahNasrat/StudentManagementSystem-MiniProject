using System.Linq.Expressions;

namespace CSharp_Fundamentals____Student_Management_System_Mini_Project_
{
    public class Program
    {
     
        static void Main(string[] args)
        {
            StudentManager  manager = new StudentManager();
            School eelu = new School();
            char run = 't';

            while (run == 't' || run =='T')
            {
                Console.WriteLine("1. Add Student\r\n" +
                    "2. View Students\r\n" +
                    "3. Update Student\r\n" +
                    "4. Delete Student\r\n" +
                    "5. Search Student\r\n" +
                    "0. Exit");

                Console.Write("please enter value : ");
                int value = int.Parse(Console.ReadLine());
                switch (value) {
                    case 0:
                        Console.WriteLine("The program has been closed.");
                        break;
                        case 1:
                        Console.Write("Please enter a Student Id  : ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Please enter a Student Name : ");
                        string studentName = Console.ReadLine();
                        Console.Write("Please enter a Student Age : ");
                        int studentAge = int.Parse(Console.ReadLine());
                        Console.Write("Please enter a Student Grade : ");
                        int studentGrade = int.Parse(Console.ReadLine());

                        Student newStudent = new Student() {
                            Id = id,
                            Name = studentName,
                            Age = studentAge,
                            Grade = studentGrade
                        };

                         manager.AddStudent(eelu, newStudent);                        
                        break;
                }
                Console.WriteLine("Enter t/T to continue , or enter f/F to stop .");
                run = char.Parse(Console.ReadLine());
            }

            Console.WriteLine($"count of students :   {eelu.Students.Count}");
        }
    }
}
