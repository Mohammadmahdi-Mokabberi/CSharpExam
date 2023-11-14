using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpExam
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Code { get; set; }
        public string BirthDate { get; set; }
        public double Grade { get; set; }

        public static Student AddStudent(string firstName, string lastName, string birthDate, string code, double grade)
        {
            Student student = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                Code = code,
                BirthDate = birthDate,
                Grade = grade
            };
            return student;
        }

        public static Student GetStudentByCode(List<Student> studentsList, string studentCode)
        {
            Student student = studentsList.Find(c => c.Code == studentCode);
            return student;
        }
        public static List<Student> DeleteStudent(List<Student> studentsList, string studentCode)
        {
            Student student = GetStudentByCode(studentsList, studentCode);
            studentsList.Remove(student);
            return studentsList;
        }
        public static List<Student> EditStudent(List<Student> studentsList, string studentCode, string firstName, string lastName, string birthDate, double grade)
        {
            Student student = GetStudentByCode(studentsList, studentCode);
            studentsList.Remove(student);
            student.FirstName = firstName;
            student.LastName = lastName;
            student.BirthDate = birthDate;
            student.Grade = grade;
            studentsList.Add(student);
            return studentsList;
        }
        public static void ShowStudentDetail(Student student, int counter = 1)
        {
            Console.WriteLine(counter + ". " + student.FirstName + " " + student.LastName + " : { Student code : " + student.Code + ", Birth date : " + student.BirthDate + ", Grade : " + student.Grade + " }");
        }
        public static void ShowStudentsList(List<Student> studentsList)
        {
            int studentCounter = 1;
            foreach (Student student in studentsList)
            {
                ShowStudentDetail(counter:studentCounter, student:student);
                studentCounter++;
            }
        }
    }
}
