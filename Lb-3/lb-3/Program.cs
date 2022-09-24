using System;

namespace program
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Введіть число х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть число у: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if(y > 0 && x < 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}