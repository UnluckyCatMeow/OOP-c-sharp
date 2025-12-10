using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Patient
    {
        public int Id { get; set; } //– унікальний ідентифікатор пацієнта
        public string Name { get; set; }// – ім'я пацієнта
        public int Age { get; set; }//– вік пацієнта
       public Patient(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
