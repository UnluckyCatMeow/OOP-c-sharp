using static Gendelyck.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gendelyck
{

    public class Restaurant
    {
        Menu menu = new Menu();
        public void Run()
        {
            menu.AddFood(new MenuPosition("Салатик 'Пощада'", 150m, 350, "Їжа", "Смачний салатик, рекомендується студентам"));
            menu.AddFood(new MenuPosition("Борщ 'Потужний'", 200m, 300, "Їжа", "Українська класика"));
            menu.AddFood(new MenuPosition("Коктель 'Сльози студента'", 700m, 30, "Напої", "Безалкогольний напій для вибагливих гурманів"));
            menu.AddFood(new MenuPosition("Рафф 'Голуба лагуна'", 69m, 69, "Напої", "Для тих, кому в колоді карт випадають тільки тузи"));
            menu.AddFood(new MenuPosition("Вода 'Фортуна'", 30m, 500, "Напої", "І нехай Фортуна буде до Вас завжди 'тим' боком"));
            menu.AddFood(new MenuPosition("Тортик 'Полуничка'", 120m, 250, "Десерти", "Для гарного настрою"));
            menu.AddFood(new MenuPosition("Ніжний мусс '>60 балів'", 150m, 350, "Десерти", "Без надії сподіваюсь"));

            menu.PrintMenu();

            Order order1 = new Order(1, DateTime.Now, 1, Statuses.New);
            order1.AddItem(menu, "Ніжний мусс '>60 балів'");
            order1.PrintOrder();

            Order order2 = new Order(2, DateTime.Now, 2, Statuses.New);
            order2.AddItem(menu, "Салатик 'Пощада'");
            order2.AddItem(menu, "Рафф 'Голуба лагуна'");
            order2.PrintOrder();
        }
        //int id, DateTime date, int table, , Statuses status
    }
}
