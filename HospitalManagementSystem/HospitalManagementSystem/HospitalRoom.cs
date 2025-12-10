using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalRoom
    {
        public int RoomNumber { get; set; } //– номер палати
        public int Capacity { get; set; }// місткість палати(макс.кількість пацієнтів)
        public List<Patient> Patients { get; set; }// список пацієнтів у палаті

        public HospitalRoom(int roomNumber, int capacity)
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
            Patients = new List<Patient>(); //перевірить чи правильно, тут треба  створює порожній список пацієнтів

        }
        public void AddPatient(Patient patient)
        {
            if (Patients.Count < Capacity) //собі: Count - це властивість списку (List<T>), яка показує, скільки елементів зараз є у списку.
            {
                Patients.Add(patient);
                Console.WriteLine($"Палата №{RoomNumber} переповнена! Неможливо додати пацієнта");
            }
            else
            {
                Console.WriteLine($"Пацієнт {patient.Name} доданий у палату №{RoomNumber}");
            }
        }
    }
}