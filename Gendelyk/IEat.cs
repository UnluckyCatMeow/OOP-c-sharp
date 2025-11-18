using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gendelyck
{
    public interface IEat
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Volume { get; set; } //об'єм 
        public string Category { get; set; }
        public string Description { get; set; }
    }
}
