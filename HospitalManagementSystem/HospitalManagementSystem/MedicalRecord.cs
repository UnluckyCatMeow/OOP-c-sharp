using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class MedicalRecord
    {
        public Patient Patient { get; set; } //– пацієнт
        public Doctor Doctor { get; set; }// – лікар
        public DateTime Date { get; set; }//– дата прийому
        public string Description { get; set; } //– опис діагнозу/призначення

        public MedicalRecord(Patient patient, Doctor doctor, DateTime date, string description)
        {
            Patient = patient;
            Doctor = doctor;
            Date = date;
            Description = description;
        }

    }
}
