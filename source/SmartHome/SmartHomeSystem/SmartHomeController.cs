using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class SmartHomeController
    {
        List<ISwitchable> switchablesDevices = new List<ISwitchable>();
        List<IEnergyConsumer> energyDevices = new List<IEnergyConsumer>();

        public void AddDevice(ISwitchable device)
        {
            switchablesDevices.Add(device);

        }
        public void AddEnergyDevice(IEnergyConsumer device)
        {
            energyDevices.Add(device);
        }
        public void TurnAllOn()
        {
            foreach (var device in switchablesDevices)
            {
                device?.TurnOn();
            }
        }
        public void TurnAllOff()
        {
            foreach (var device in switchablesDevices)
            {
                device?.TurnOff(); //собі : ? щоб нічого не поломалось, якщо в методі буде null
            }
        }
        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine($"Звіт про споживання енергії за {hours} год:");
            double total = 0; //цю строку підглянула в чата

            foreach (var device in energyDevices)
            {
                double usage = device.GetEnergyUsage(hours);
                Console.WriteLine($"{device.DeviceName}: {device.GetEnergyUsage(hours):F2} кВт·год (потужність: {device.PowerConsumption} Вт)");
                total += usage;
            }
            Console.WriteLine($"Загальне споживання: {total:F2} кВт·год\n" +
                   $"Вартість (~4 грн/кВт·год): {total * 4:F2} грн");

        }
    }
}
