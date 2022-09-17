using System;

namespace ProstieChisla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число до которого будем считать простые числа.");
            int x, result = 1;
            x = int.Parse(Console.ReadLine());
            for (int i = 2; i <= x; i++)
            {
                if (Prostoe(i))
                {
                    result = i;
                }
            }
            Console.WriteLine(result);
        }
        private static bool Prostoe(int x)
        {
            for (int i = 2; i < (int)(x / 2); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
    }
}