using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gendelyck
{
    public class Order
    {
        private List<MenuPosition> Eat = new List<MenuPosition>();
        private decimal _totalPrice = 0m;

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Table { get; set; }
        public Statuses Status { get; set; }
      

        public Order(int id, DateTime date, int table, Statuses status)
        {
            Id = id;
            Date = date;
            Table = table;
            Status = status;
        }
        public void AddItem(Menu menu, string name = "")
        {
            MenuPosition found = menu.Food.FirstOrDefault(f => f.Name == name);    //
            if (found != null)
            {
                Eat.Add(found);
            }
        }
        public void PrintOrder()
        {
            Console.WriteLine($"\nЗамовлення №{Id}"+
                $"\nСтворено: {Date}"+
                $"\nДля столика: {Table}"+
                $"\nСтатус: {Status}");
            foreach (var item in Eat)
            {
                Console.WriteLine($"{item.Name} - {item.Volume} гр. - {item.Price} ₴");
                _totalPrice += item.Price;
            }
            Console.WriteLine($"Всього:{_totalPrice}");

        }
    }
}
