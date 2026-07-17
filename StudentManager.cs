using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals____Student_Management_System_Mini_Project_
{
    public class StudentManager
    {
        public bool AddStudent(School school, int id, string name, int age, int grade)
        {

            try
            {
                var student = new Student()
                {
                    Id = id,
                    Name = name,
                    Age = age,
                    Grade = grade
                };
                school.Students.Add(student);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DeleteStudent(School school, int id)
        {
            try
            {
                Student student = null;
                foreach (Student s in school.Students)
                {
                    if (s.Id == id)
                    {
                        student = s;
                    }
                }
                if (student != null)
                {
                    school.Students.Remove(student);                   
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
         public bool UpdateStudent(School school ,int id,string newName,int newage,int newgrade) {
            try {
                if (school is null) {
                    return false;
                }
                foreach (var student in school.Students) {
                    if (student.Id == id) {
                        student.Name = newName;
                        student.Age = newage;
                        student.Grade = newgrade;
                        return true;
                    }
                }
            }
            catch {
                return false;
            }
            return false;


        }
        public List<Student> GetAllStudents(School school)
        {
            if (school.Students.Count != 0 && school !=null)
            {

                return school.Students;
            }
            else
            {
                return [];
            }

        }
        public int CountOfStudents(School school) {
            return school.Students.Count;
        }
        public bool IsExistStudentById(School school, int id) {
            try {
                if (school is null) {
                    return false;
                }
                foreach (Student student in school.Students) {
                    if (student.Id == id) {
                        return true;
                    }
                }
            }
            catch { return false; }
            return false;

        }

        public Student SearchById(School school , int id) {
            try {
                if (school is null) {
                    return null;
                }
                else {
                    foreach (Student student in school.Students) {
                        if (student.Id == id)
                        {
                            return student;
                        }                       
                    }
                    
                }
                return null;
            }
            catch {
                return null;
                
            }
        }

        }
    }

