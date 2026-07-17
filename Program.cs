using System.Linq.Expressions;

namespace CSharp_Fundamentals____Student_Management_System_Mini_Project_
{
    public class Program
    {
     
        static void Main(string[] args)
        {
            StudentManager  manager = new StudentManager();
            School eelu = new School() {Name = "Eelu",Id =1 };
            char run = 't';

            while (run == 't' || run =='T')
            {
                Console.WriteLine("1. Add Student\r\n" +
                    "2. View Students\r\n" +
                    "3. Update Student\r\n" +
                    "4. Delete Student\r\n" +
                    "5. Search Student\r\n" +
                    "6. Is the student ID available?\r\n" +
                    "7. Number of Students?\r\n" +
                    "0. Exit");

                Console.Write("please enter value : ");
                int value = int.Parse(Console.ReadLine());
                switch (value) {
                    case 0:
                        Console.WriteLine("The program has been closed.");
                        break;
                    case 1:
                        {
                            try
                            {
                                Console.Write("Please enter a Student Id  : ");
                                int id = int.Parse(Console.ReadLine());
                                while (id <= 0)
                                {
                                    Console.WriteLine("Please enter a  valid Student Id");
                                    id = int.Parse(Console.ReadLine());
                                }

                                Console.Write("Please enter a Student Name : ");
                                string studentName = Console.ReadLine();
                                while (string.IsNullOrEmpty(studentName))
                                {
                                    Console.WriteLine("Please enter a  valid Student Name");
                                    studentName = Console.ReadLine();
                                }

                                Console.Write("Please enter a Student Age : ");
                                int studentAge = int.Parse(Console.ReadLine());
                                while (studentAge <= 0)
                                {
                                    Console.Write("Please enter a  valid Student Age : ");
                                    studentAge = int.Parse(Console.ReadLine());
                                }

                                Console.Write("Please enter a Student Grade : ");
                                int studentGrade = int.Parse(Console.ReadLine());
                                while (studentGrade <= 0)
                                {
                                    Console.Write("Please enter a valid Student Grade : ");
                                    studentGrade = int.Parse(Console.ReadLine());
                                }

                                bool isAdded = manager.AddStudent(eelu, id, studentName, studentAge, studentGrade);
                                if (isAdded) {
                                    Console.WriteLine("The Student has been added");
                                }else
                                    Console.WriteLine("The Student has not been added");
                            }
                            catch (Exception ex) {
                                Console.WriteLine(ex.Message);
                            }                           
                            break;
                        }
                    case 2:
                        {
                            var students = manager.GetAllStudents(eelu);
                            if (students != null && students.Count != 0)
                            {
                                Console.WriteLine($"{eelu.Name} Students : ");
                                foreach (var student in students)
                                {
                                    Console.WriteLine($"Id: {student.Id}  - Name: {student.Name}  - Age: {student.Age}  - Grade: {student.Grade} \n");
                                }
                            }
                            else {
                                Console.WriteLine("there are no students here. ");
                            }
                            break;
                        }
                    case 3:
                        {
                            try
                            {
                                Console.WriteLine("Enter a Student Id you need to Change his data");
                                int studentId = int.Parse(Console.ReadLine());
                                while (studentId <= 0)
                                {
                                    Console.WriteLine("Enter a valid Student Id you need to Change his data");
                                    studentId = int.Parse(Console.ReadLine());
                                }

                                Console.Write("Please enter a new Student Name : ");
                                string studentName = Console.ReadLine();
                                while (string.IsNullOrEmpty(studentName))
                                {
                                    Console.WriteLine("Please enter a  valid Student Name");
                                    studentName = Console.ReadLine();
                                }

                                Console.Write("Please enter a new Student Age : ");
                                int studentAge = int.Parse(Console.ReadLine());
                                while (studentAge <= 0)
                                {
                                    Console.Write("Please enter a  valid Student Age : ");
                                    studentAge = int.Parse(Console.ReadLine());
                                }

                                Console.Write("Please enter a new Student Grade : ");
                                int studentGrade = int.Parse(Console.ReadLine());
                                while (studentGrade <= 0)
                                {
                                    Console.Write("Please enter a valid Student Grade : ");
                                    studentGrade = int.Parse(Console.ReadLine());
                                }

                                bool isEdited = manager.UpdateStudent(eelu, studentId, studentName, studentAge, studentGrade);
                                if (isEdited)
                                {
                                    Console.WriteLine("The student's data has been successfully updated. ");
                                }
                                else {
                                    Console.WriteLine("The student's data has not been successfully updated.");
                                }
                            }
                            catch (Exception ex) {
                                Console.WriteLine(ex.Message);
                            } 
                                

                            break;
                        }
                    case 4: {
                            Console.Write("Enter the student number you want to delete : ");
                            try {
                                int id = int.Parse(Console.ReadLine());
                                bool success = manager.DeleteStudent(eelu, id);
                                if(success == true)
                                    Console.WriteLine("The Student has been removed");
                                else
                                    Console.WriteLine();
                                
                            }
                            catch(Exception e) {
                                Console.WriteLine(e.Message);
                            }

                            break;
                            }
                    case 5: {
                            try {
                                Console.WriteLine("enter student id that you need to find ");
                                int id = int.Parse(Console.ReadLine());
                                while (id <= 0)
                                {
                                    Console.WriteLine("enter valid student id that you need to find ");
                                    id = int.Parse(Console.ReadLine());
                                }

                                var student = manager.SearchById(eelu, id);
                                if (student == null)
                                    Console.WriteLine("there is no student with this id");
                                else {
                                    Console.WriteLine($"Id: {student.Id}  - Name: {student.Name}  - Age: {student.Age}  - Grade: {student.Grade} \n");
                                }
                            }
                            catch(Exception ex) {
                            }
                            break;
                        }
                    case 6: {
                            try
                            {
                                Console.WriteLine("enter student id that you need to find ");
                                int id = int.Parse(Console.ReadLine());
                                while (id <= 0)
                                {
                                    Console.WriteLine("enter valid student id that you need to find ");
                                    id = int.Parse(Console.ReadLine());
                                }

                                bool isExist = manager.IsExistStudentById(eelu, id);
                                if (isExist)
                                    Console.WriteLine($"the student with id : {id} is exist");
                                else
                                    Console.WriteLine($"the student with id : {id} is not exist");
                            }
                            catch (Exception ex) {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        }
                    case 7: {
                            try
                            {
                                Console.WriteLine($"count of students : {manager.CountOfStudents(eelu)}");
                            }
                            catch (Exception ex) {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        }

                        }

                if (value == 0)
                    break;

                Console.WriteLine("Enter t/T to continue , or enter f/F to stop .");
                run = char.Parse(Console.ReadLine());
            }          
        }
    }
}
