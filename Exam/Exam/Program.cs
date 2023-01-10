using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Planshet planshet1 = new Planshet() { colorCollection = "Червоний", year = 2022, price = 80, baterry = 3200 };
            Planshet planshet2 = new Planshet() { colorCollection = "Фіолетовий", year = 2021, price = 1000, baterry = 3400 };
            Planshet planshet3 = new Planshet() { colorCollection = "Білий", year = 2023, price = 50, baterry = 4000 };
            Planshet planshet4 = new Planshet() { colorCollection = "Чорний", year = 2019, price = 100, baterry = 2800 };
            Planshet planshet5 = new Planshet() { colorCollection = "Сірий", year = 2020, price = 500, baterry = 3000 };

            Planshets myPlanshets = new Planshets(planshet1, planshet2, planshet3, planshet4, planshet5);

            int Years = 0;
            int batter = 0;
            int cost = 0;
            string colour = "";

            Console.WriteLine("Якщо Вас не цікавить характеристика натисніть Enter");

            Console.Write("Введіть рік випуску планшета: ");

            string stringYears = Console.ReadLine();
            if (string.IsNullOrEmpty(stringYears)) Years = 0;
            else int.TryParse(stringYears, out Years);

            Console.Write("Введіть ємність батареї: ");

            string stringBattery = Console.ReadLine();
            if (string.IsNullOrEmpty(stringBattery)) batter = 0;
            else int.TryParse(stringBattery, out batter);

            Console.Write("Введіть ціну планшета: ");

            string stringPrice = Console.ReadLine();
            if (string.IsNullOrEmpty(stringPrice)) cost = 0;
            else int.TryParse(stringPrice, out cost);

            Console.Write("Введіть колір планшета: ");

            string stringColour = Console.ReadLine();
            if (string.IsNullOrEmpty(stringColour)) colour = "";
            else colour = stringColour;

            Planshet resultPlanshet;
            Console.WriteLine($"Шукаю планшет за Вашими характеристиками...");
            if(myPlanshets.TryFindPlanshet(out resultPlanshet, year: Years, battery: batter, price: cost, colorCollection: colour))
            {
                Console.WriteLine($"Планшет знайдено");
                resultPlanshet.PrintValues();
            }
            else
            {
                Console.WriteLine("За такими характеристиками нічого не знайдено :(");
            }

            Console.ReadKey();

        }
    } 
}