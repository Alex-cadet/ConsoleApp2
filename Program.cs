using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rew = " ";
            string res = " ";
            Random rnd = new Random();
            int[] Arr = new int[10];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = rnd.Next(30);
                rew = rew + Arr[i].ToString() + " ";
            }
            Console.WriteLine("Заданная строка: {0}", rew);
            for (int j = 0; j < Arr.Length; j++)
                if (Arr[j] % 2 == 0)
                    res = res + Arr[j].ToString() + " ";
            Console.WriteLine("Чётные символы: {0}", res);
        }
    }
}
