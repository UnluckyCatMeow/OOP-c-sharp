using SmartHomeSystem;

namespace SmartHomeSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            SmartHomeController smartHomeController = new SmartHomeController(); //об'єкт

            Light livingLight = new Light { Name = "Лампа у вітальні" }; 
            AirConditioner conditioner = new AirConditioner { Name = "Кондиціонер у спальні" };
            CoffeeMachine coffee = new CoffeeMachine { Name = "Кавомашина на кухні" };
            MotionSensor motion = new MotionSensor { Name = "Датчик руху у коридорі" };

            smartHomeController.AddDevice(livingLight);
            smartHomeController.AddDevice(conditioner);
            smartHomeController.AddDevice(coffee);
            smartHomeController.AddDevice(motion);

            smartHomeController.AddEnergyDevice(livingLight);
            smartHomeController.AddEnergyDevice(conditioner);
            smartHomeController.AddEnergyDevice(coffee);

            smartHomeController.TurnAllOn();
            Console.WriteLine();
            livingLight.PrintStatus();
            conditioner.PrintStatus();
            coffee.PrintStatus();
            motion.PrintStatus();
            smartHomeController.ShowEnergyReport(5);
            smartHomeController.TurnAllOff();

        }
    }
}