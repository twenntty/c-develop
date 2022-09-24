using System;

namespace Program
{
    class program
    {
        static void Main(string[] args)
        {
            int raz = 6;
            float par = 2;
            int[] arr = new int[raz];

            for (int i = 0; i < raz; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Елементи з парних індексів: \t");

            for (int j = 0; j < raz; j++)
            {
                if (j % par == 0)
                {
                    Console.WriteLine(arr[j]);
                }
            }

            Console.WriteLine("Елементи з непарних індексів: \t");

            for (int k = 0; k < raz; k++)
            {
                if (k % par != 0)
                {
                    Console.WriteLine(arr[k]);
                }
            }

            Console.ReadLine();

        }
    }
}