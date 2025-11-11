using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class Light : Device, IEnergyConsumer
    {
        public int PowerConsumption => 60; //була ідея написати PowerConsumption = 60 але так не можна
        public string DeviceName => Name; //(цю строку підказав джіпіті). собі: це типу public string DeviceName
                                                                                //{
                                                                                //    get { return Name; }
                                                                                //}
        public override void TurnOn()
        {
            IsOn = true;
                Console.WriteLine($"{Name} засвітилася.");
        }

        public override void TurnOff()
        {
            IsOn = false;
                Console.WriteLine($"{Name} вимкнена.");
        }
        public double GetEnergyUsage(int hours) //собі : override тут не потрібен, бо цей метод не в базовому класі, а в інтерфейсі
        {
            if (IsOn == false) //можна зробити (!IsOn)
                return 0;
            else
                return PowerConsumption * hours / 1000.0;
        }


    }
}
