using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; } //ім'я лікаря
        public string Specialization { get; set; } //спеціалізація(наприклад, терапевт, хірург)
        public Doctor(int id, string name, string specialization)
        {
            Id = id;
            Name = name;
            Specialization = specialization;
        }

    }
}
