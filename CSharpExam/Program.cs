using CSharpExam;

bool status = true;
List<Student> studentsList = new List<Student>();
List<Teacher> teachersList = new List<Teacher>();
List<LanguageTerm> languageTermsList = new List<LanguageTerm>();

while (status) {
    Console.Clear();
    Console.WriteLine("1.Techer menu");
    Console.WriteLine("2.Student menu");
    Console.WriteLine("3.LanguageTerm menu");
    Console.WriteLine("4.Exit");
    int homeMenuInput = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    if (homeMenuInput == 4)
    {
        status = false;
    }
    else if (homeMenuInput == 1)
    {
        //Teacher Menu
        Console.WriteLine("1.Add new techer");
        Console.WriteLine("2.Techers list");
        Console.WriteLine("3.Edit teacher");
        Console.WriteLine("4.Delete teacher");
        Console.WriteLine("5.Home");
        int teacherMenuInput = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if (teacherMenuInput == 5)
        {
        }
        else if (teacherMenuInput == 1)
        {
            //Add
            Console.WriteLine("Enter first name : ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter teacher code : ");
            string code = Console.ReadLine();
            Console.WriteLine("Enter national code : ");
            string nationalCode = Console.ReadLine();
            Teacher teacher = Teacher.AddTeacher(firstName, lastName, nationalCode, code);
            teachersList.Add(teacher);
            Console.WriteLine("New teacher added");
        }
        else if (teacherMenuInput == 2)
        {
            //List
            Teacher.ShowTeacherLists(teachersList);
            Console.WriteLine("Enter anything to go home");
            Console.ReadLine();
        }
        else if (teacherMenuInput == 3)
        {
            //Edit
            Teacher.ShowTeacherLists(teachersList);
            Console.WriteLine("Enter teacher code to edit : ");
            string teacherCode = Console.ReadLine();
            Teacher teacher = Teacher.GetTeacherByCode(teachersList, teacherCode);
            Console.WriteLine("1. " + teacher.FirstName + " " + teacher.LastName + " : { national code : " + teacher.NationalCode + ", teacher code : " + teacher.Code + " }");
            Console.WriteLine("Press Enter to edit...");
            Console.WriteLine("Enter new first name : ");
            string firstName = Console.ReadLine();
            if (firstName == "")
            {
                firstName = teacher.FirstName;
            }
            Console.WriteLine("Enter new last name : ");
            string lastName = Console.ReadLine();
            if (lastName == "")
            {
                lastName = teacher.LastName;
            }
            Console.WriteLine("Enter new national code : ");
            string nationalCode = Console.ReadLine();
            if (nationalCode == "")
            {
                nationalCode = teacher.NationalCode;
            }
            teachersList = Teacher.EditTeacher(teachersList: teachersList, teacherCode:teacherCode, firstName:firstName, lastName:lastName, nationalCode:nationalCode);
        }
        else if (teacherMenuInput == 4)
        {
            //Delete
            Teacher.ShowTeacherLists(teachersList);
            Console.WriteLine("Enter teacher code to edit : ");
            string teacherCode = Console.ReadLine();
            Teacher teacher = Teacher.GetTeacherByCode(teachersList: teachersList, teacherCode: teacherCode);
            Console.WriteLine("1. " + teacher.FirstName + " " + teacher.LastName + " : { national code : " + teacher.NationalCode + ", teacher code : " + teacher.Code + " }");
            Console.WriteLine("Press Enter to Delete...");
            teachersList = Teacher.DeleteTeacher(teachersList: teachersList, teacherCode: teacherCode);
        }
    }
    else if (homeMenuInput == 2)
    {
        //Student Menu
        Console.WriteLine("1.Add new student");
        Console.WriteLine("2.Students list");
        Console.WriteLine("3.Edit student");
        Console.WriteLine("4.Delete student");
        Console.WriteLine("5.Home");
        int studentMenuInput = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if (studentMenuInput == 5)
        {
        }
        else if (studentMenuInput == 1) 
        {
            //Add
            Student student = new Student();
            Console.WriteLine("Enter first name : ");
            student.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name : ");
            student.LastName = Console.ReadLine();
            Console.WriteLine("Enter student code : ");
            student.Code = Console.ReadLine();
            Console.WriteLine("Enter birth date : ");
            student.BirthDate = Console.ReadLine();
            Console.WriteLine("Enter grade : ");
            student.Grade = Convert.ToDouble(Console.ReadLine());
            studentsList.Add(student);
        }
        else if (studentMenuInput == 2)
        {
            //List
            Student.ShowStudentsList(studentsList);
            Console.WriteLine("Enter anything to go home");
            Console.ReadLine();
        }
        else if (studentMenuInput == 3)
        {
            //Edit
            Student.ShowStudentsList(studentsList);
            Console.WriteLine("Enter teacher code to edit : ");
            string studentCode = Console.ReadLine();
            Student student = Student.GetStudentByCode(studentsList:studentsList, studentCode:studentCode);
            Student.ShowStudentDetail(student);
            Console.WriteLine("Press Enter to edit...");            
            Console.WriteLine("Enter new first name : ");
            string firstName = Console.ReadLine();
            if (firstName == "")
            {
                firstName = student.FirstName;
            }
            Console.WriteLine("Enter new last name : ");
            string lastName = Console.ReadLine();
            if (lastName == "")
            {
                lastName = student.LastName;
            }
            Console.WriteLine("Enter new birth date : ");
            string birthDate = Console.ReadLine();
            if (birthDate == "")
            {
                birthDate = student.BirthDate;
            }
            Console.WriteLine("Enter new grade : ");
            string newGrade = Console.ReadLine();
            double grade;
            if (newGrade != "")
            {
                grade = Convert.ToDouble(newGrade);
            }
            else
            {
                grade = student.Grade; 
            }
            
            studentsList = Student.EditStudent(studentsList: studentsList, studentCode: studentCode, firstName: firstName, lastName: lastName, birthDate: birthDate, grade:grade);

        }
        else if (studentMenuInput == 4)
        {
            //Delete
            Student.ShowStudentsList(studentsList);
            Console.WriteLine("Enter student code to edit : ");
            string studentCode = Console.ReadLine();
            Student student = Student.GetStudentByCode(studentsList: studentsList, studentCode: studentCode);
            Console.WriteLine("1. " + student.FirstName + " " + student.LastName + " : { Student code : " + student.Code + ", Birth date : " + student.BirthDate + ", Grade : " + student.Grade + " }");
            Console.WriteLine("Press Enter to Delete...");
            studentsList = Student.DeleteStudent(studentsList: studentsList, studentCode: studentCode);
        }
    }
    else if (homeMenuInput == 3)
    {

        Console.WriteLine("1.Add new language term");
        Console.WriteLine("2.Language term list");
        Console.WriteLine("3.Edit language term");
        Console.WriteLine("4.Delete language term");
        Console.WriteLine("5.Home");
        int languageTermMenuInput = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if (languageTermMenuInput == 5)
        {
        }
        else if (languageTermMenuInput == 1)
        {
            Console.WriteLine("Enter name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter language term code : ");
            string code = Console.ReadLine();
            Console.WriteLine("Enter student code : ");
            string studentCode = Console.ReadLine();
            Console.WriteLine("Enter techer code : ");
            string teacherCode = Console.ReadLine();
            Console.WriteLine("Enter start date : ");
            string startDate = Console.ReadLine();
            Console.WriteLine("Enter end date : ");
            string endDate = Console.ReadLine();
            LanguageTerm languageTerm = LanguageTerm.AddLanguageTerm(name: name, code: code, studentCode: studentCode, teacherCode: teacherCode, startDate: startDate, endDate: endDate);
            languageTermsList.Add(languageTerm);
            Console.WriteLine("New language term added");
        }
        else if (languageTermMenuInput == 2)
        {
            LanguageTerm.ShowLanguageTermsList(languageTermsList);
            Console.WriteLine("Press Enter go home");
            Console.ReadLine();
        }
        else if (languageTermMenuInput == 3)
        {
            //Edit
            LanguageTerm.ShowLanguageTermsList(languageTermsList);
            Console.WriteLine("Enter teacher code to edit : ");
            string languageTermCode = Console.ReadLine();
            LanguageTerm languageTerm = LanguageTerm.GetLanguageTermByCode(languageTermsList: languageTermsList, languageTermCode: languageTermCode);
            LanguageTerm.ShowLanguageTermDetail(languageTerm);
            Console.WriteLine("Press Enter to edit...");
            Console.WriteLine("Enter new name : ");
            string name = Console.ReadLine();
            if (name == "")
            {
                name = languageTerm.Name;
            }
            Console.WriteLine("Enter new student code : ");
            string studentCode = Console.ReadLine();
            if (studentCode == "")
            {
                studentCode = languageTerm.StudentCode;
            }
            Console.WriteLine("Enter new techer code : ");
            string teacherCode = Console.ReadLine();
            if (teacherCode == "")
            {
                teacherCode = languageTerm.TeacherCode;
            }
            Console.WriteLine("Enter new start date : ");
            string startDate = Console.ReadLine();
            if (startDate == "")
            {
                startDate = languageTerm.StartDate;
            }
            Console.WriteLine("Enter new end date : ");
            string endDate = Console.ReadLine();
            if (endDate == "")
            {
                endDate = languageTerm.EndDate;
            }
            languageTermsList = LanguageTerm.EditLanguageTerm(languageTermsList: languageTermsList, languageTermCode: languageTermCode, name: name, teacherCode: teacherCode, studentCode: studentCode, startDate: startDate, endDate: endDate);
        }
        else if (languageTermMenuInput == 4)
        {
            //Delete
            LanguageTerm.ShowLanguageTermsList(languageTermsList);
            Console.WriteLine("Enter student code to edit : ");
            string languageTermCode = Console.ReadLine();
            LanguageTerm languageTerm = LanguageTerm.GetLanguageTermByCode(languageTermsList: languageTermsList, languageTermCode: languageTermCode);
            LanguageTerm.ShowLanguageTermDetail(languageTerm);
            Console.WriteLine("Press Enter to Delete...");
            languageTermsList = LanguageTerm.DeleteLanguageTerm(languageTermsList: languageTermsList, languageTermCode: languageTermCode);
        }
    }
}