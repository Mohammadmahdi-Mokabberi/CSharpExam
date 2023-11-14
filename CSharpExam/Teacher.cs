using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExam
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Code { get; set; }
        public string NationalCode { get; set; }
        public static Teacher AddTeacher(string firstName, string lastName, string nationalCode, string code)
        {
            Teacher teacher = new Teacher()
            {
                FirstName = firstName,
                LastName = lastName,
                NationalCode = nationalCode,
                Code = code
            };
            return teacher;
        }

        public static Teacher GetTeacherByCode(List<Teacher> teachersList, string teacherCode)
        {
            Teacher teacher = teachersList.Find(c => c.Code == teacherCode);
            return teacher;
        }
        public static List<Teacher> DeleteTeacher(List<Teacher> teachersList, string teacherCode)
        {
            Teacher teacher = GetTeacherByCode(teachersList, teacherCode);
            teachersList.Remove(teacher);
            return teachersList;
        }
        public static List<Teacher> EditTeacher(List<Teacher> teachersList, string teacherCode, string firstName, string lastName, string nationalCode)
        {
            Teacher teacher = GetTeacherByCode(teachersList, teacherCode);
            teachersList.Remove(teacher);
            teacher.FirstName = firstName;
            teacher.LastName = lastName;
            teacher.NationalCode = nationalCode;
            teachersList.Add(teacher);
            return teachersList;
        }
        public static void ShowTeacherDetail(Teacher teacher ,int counter=1)
        {
            Console.WriteLine(counter + ". " + teacher.FirstName + " " + teacher.LastName + " : { national code : " + teacher.NationalCode + ", teacher code : " + teacher.Code + " }");
        }
        public static void ShowTeacherLists(List<Teacher> teachersList)
        {
            int teacherCounter = 1;
            foreach (Teacher teacher in teachersList)
            {
                ShowTeacherDetail(counter: teacherCounter, teacher: teacher);
                teacherCounter++;
            }
        }
    }
}
