using System;

namespace program
{
    class Program
    {
        public static void Main()
        {
            float num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Число парне!");
            }
            else
            {
                Console.WriteLine("Число непарне");
            }
        }
    }
    
}