using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public abstract class Device : ISwitchable
    {
        public string Name { get; set; }
        //public Device(string name) для чого ми це з Вами додали на парі? 
        //{
        //    Name = name;
        //    IsOn = true; 
        //}
        public bool IsOn { get; protected set; }
        public abstract void TurnOn();
        public abstract void TurnOff();
        public void PrintStatus()
        {
            if (IsOn)
                Console.WriteLine($"{Name}: увімкнено");
            else Console.WriteLine($"{Name}: вимкнено");
                
        }

    }
}
//
//if (IsOn == false)
//    return 0;
//else
//    return PowerConsumption * hours / 1000;