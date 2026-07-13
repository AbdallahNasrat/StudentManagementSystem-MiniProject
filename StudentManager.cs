using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals____Student_Management_System_Mini_Project_
{
    public class StudentManager
    {
        public bool AddStudent( School school , Student student ) {

            try
            {
                school.Students.Add(student);
                Console.WriteLine("The Student has been added");
                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool DeleteStudent(School school,int id) {
            try
            {
                var student = school.Students.FirstOrDefault(s => s.Id == id);
                school.Students.Remove(student);
                Console.WriteLine("The Student has been removed");
                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
       // public bool UpdateStudent(Student student) { }
       // public List<Student> GetAllStudents() { }
        //public Student GetStudent(int id) { }

    }
}
