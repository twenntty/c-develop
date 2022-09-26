using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementsN = 2;
            int elementsM = 2;

            int rezultn = 0;
            int rezultm = 0;

            int[,] arr = new int[elementsN, elementsM];

            for(int i = 0; i < elementsN; i++)
            {
                for(int j = 0; j < elementsM; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Масив: \t");

            for (int i = 0; i < elementsN; i++)
            {
                for (int j = 0; j < elementsM; j++)
                {
                    Console.Write($"{ arr[i, j]} \t");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < elementsN; i++)
            {
                for (int j = 0; j < elementsM; j++)
                { 
                    if (i % 2 != 0)
                    {
                        rezultn += arr[i, j];
                    }
                }
            }

            for (int i = 0; i < elementsM; i++)
            {
                for (int j = 0; j < elementsN; j++)
                {
                    if (i % 2 != 0)
                    {
                        rezultm += arr[j, i];
                    }
                }
            }

            Console.Write("Сума елементів непарних строк: ");
            Console.Write(rezultn);
            Console.WriteLine();
            Console.Write("Сума елементів парних колонок: ");
            Console.Write(rezultm);

            Console.ReadLine();
        }
    }
}