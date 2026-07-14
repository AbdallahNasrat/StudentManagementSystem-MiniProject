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
                school.CountOfStudents++;
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
                    school.CountOfStudents--;
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
            if (school.Students.Count != 0)
            {
                var list = new List<Student>();
                foreach (Student s in school.Students)
                {
                    list.Add(s);
                    //Console.WriteLine($"Student From {school.Name} :");
                    //Console.WriteLine($"Id: {s.Id}  - Name: {s.Name}  - Age: {s.Age}  - Grade: {s.Grade} \n");
                }
                return list;

            }
            else
            {
                return [];
            }

            //}
            //public Student GetStudent(int id) { }

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
                        else
                            return null;
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

