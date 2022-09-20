using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {
            double i = 0;
            int q = 0;
            int t = 0;
            bool isUok;
            bool isRok;
            string strU;
            string strR;

            do
            {
                Console.Write("Enter Q. q = ");
                strU = Console.ReadLine();
                isUok = int.TryParse(strU, out q);
                if (isUok) break;
                Console.WriteLine("Input Q error");
            } while (!isUok);

            q = int.Parse(strU);
            do
            {
                Console.Write("Enter t. T = ");
                strR = Console.ReadLine();
                isRok = int.TryParse(strR, out t);
                if (isRok) break;
                Console.WriteLine("Input T error");

            } while (!isRok);

            q = int.Parse(strR);


            i = (double)q / t;
            Console.WriteLine("I value is: " + i);

        }
    }
}