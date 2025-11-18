using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gendelyck
{
    public class MenuPosition : IEat
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Volume { get; set; } //об'єм 
        public string Category { get; set; }
        public string Description { get; set; }
        public MenuPosition (string name, decimal price, int volume, string category, string description)
        {
            Name = name;
            Price = price;
            Volume = volume;
            Category = category;
            Description = description;
        }
    }
}
