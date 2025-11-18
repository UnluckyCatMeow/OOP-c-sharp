using Gendelyck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gendelyck
{

    public class Menu
    {
        public List<MenuPosition> Food { get; set; } = new List<MenuPosition>();
        public void AddFood(MenuPosition eat)
        {
            Food.Add(eat);
            Console.WriteLine($"Додано страву: {eat.Name}");
        }
        public void PrintMenu()
        {
            Console.WriteLine("\nТримайте повне меню: ");
            foreach (MenuPosition eat in Food)
            {
                Console.WriteLine($"{eat.Name}, {eat.Price}, {eat.Volume}, {eat.Category}, {eat.Description}");
            }
        }
    }
}