using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    public class Student
    {
        public List<string> students = new List<string>();
        public void AddStudents()
        {
            students.Add("Даша");
            students.Add("Денис");
            students.Add("Демид");
            students.Add("Андрій");
            students.Add("Паша");
            students.Add("Данило");
        }
        public static Predicate<string> predicate = name => name.StartsWith("Д");


    }
}
