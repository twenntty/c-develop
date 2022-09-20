using System;

namespace lb
{
    class lb
    {
        public static void Main()
        {
            int nn = 0;
            int nk = 0;
            int k = 0;
            double result = 0;

            bool isNNok = false;
            bool isNKok = false;

            do
            {
                Console.Write("Введіть значення NN. NN = ");
                string strNN = Console.ReadLine();
                isNNok = int.TryParse(strNN, out nn);
                if (!isNNok && nn <= 0)
                {
                    Console.WriteLine("Помилка введення.");
                }
            } while (!isNNok);

            Console.Write("Введіть значення NK. NK = ");
            string strNK = Console.ReadLine();
            isNKok = int.TryParse(strNK, out nk);
            if (!isNKok && nk < nn)
            {
                Console.WriteLine("Помилка введення");
                Console.ReadLine();
                return;
            }

            for (k = nn; k< nk; k++)
            {
                result += Math.Pow(k, 2) + Math.Pow(-1, k) * k - 1 / Math.Pow(k, 2) + 1;
            }
            Console.Write("Результат = {0}", result);
        }
    }
}