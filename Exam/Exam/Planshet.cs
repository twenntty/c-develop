using System;
namespace Exam
{
    struct Planshet
    {
        public string colorCollection;
        public int year;
        public float price;
        public int baterry;

        public void PrintValues()
        {
            Console.WriteLine($"Колір = {colorCollection}, Рік = {year}, Ціна = {price} $, Батарея = {baterry} mAh");
        }
    }
}

