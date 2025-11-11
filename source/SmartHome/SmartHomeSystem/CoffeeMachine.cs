using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class CoffeeMachine : Device, IEnergyConsumer
    {
        public int PowerConsumption => 1000;
        public string DeviceName => Name; //не до кінця розумію нащо воно тут
        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} почала готувати каву.");
        }
        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} завершила роботу.");
        }
        public double GetEnergyUsage(int hours)
        {
            if (IsOn == false)
                return 0;
            else
                return PowerConsumption * hours / 1000.0;
        }
    }
}
