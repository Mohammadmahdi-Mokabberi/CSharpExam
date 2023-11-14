using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExam
{
    public class LanguageTerm
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string StudentCode { get; set; }
        public string TeacherCode { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public static LanguageTerm AddLanguageTerm(string name, string code, string studentCode, string teacherCode, string startDate, string endDate)
        {
            LanguageTerm student = new LanguageTerm()
            {
                Name = name,
                StudentCode = studentCode,
                Code = code,
                TeacherCode = teacherCode,
                StartDate = startDate,
                EndDate = endDate
            };
            return student;
        }

        public static LanguageTerm GetLanguageTermByCode(List<LanguageTerm> languageTermsList, string languageTermCode)
        {
            LanguageTerm languageTerm = languageTermsList.Find(c => c.Code == languageTermCode);
            return languageTerm;
        }
        public static List<LanguageTerm> DeleteLanguageTerm(List<LanguageTerm> languageTermsList, string languageTermCode)
        {
            LanguageTerm languageTerm = GetLanguageTermByCode(languageTermsList, languageTermCode);
            languageTermsList.Remove(languageTerm);
            return languageTermsList;
        }
        public static List<LanguageTerm> EditLanguageTerm(List<LanguageTerm> languageTermsList, string name, string languageTermCode, string studentCode, string teacherCode, string startDate, string endDate)
        {
            LanguageTerm languageTerm = GetLanguageTermByCode(languageTermsList, languageTermCode);
            languageTermsList.Remove(languageTerm);
            languageTerm.Name = name;
            languageTerm.StartDate = startDate;
            languageTerm.EndDate = endDate;
            languageTerm.StudentCode = studentCode;
            languageTerm.TeacherCode = teacherCode;
            languageTermsList.Add(languageTerm);
            return languageTermsList;
        }
        public static void ShowLanguageTermDetail(LanguageTerm languageTerm, int counter = 1)
        {
            Console.WriteLine(counter + ". " + languageTerm.Name + " : { Period : " + languageTerm.StartDate + " - " + languageTerm.EndDate + ", Term code : " + languageTerm.Code + ", Student code : " + languageTerm.StudentCode + ", Teacher code : " + languageTerm.TeacherCode + " }");
        }
        public static void ShowLanguageTermsList(List<LanguageTerm> languageTermsList)
        {
            int languageTermCounter = 1;
            foreach (LanguageTerm languageTerm in languageTermsList)
            {
                ShowLanguageTermDetail(counter: languageTermCounter, languageTerm: languageTerm);
                languageTermCounter++;
            }
        }
    }
}
