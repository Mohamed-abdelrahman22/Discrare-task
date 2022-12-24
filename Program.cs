using System;
namespace ThePerfectNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The First Number : ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Second Number : ");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("The Perfect Numbers within the given range : ");
            for (int y = first; y <= second; y++)
            {
             int x = 1;
             int z = 0;
             while (x < y)
             {
              if (y % x == 0)
              z = z + x;
              x++;
             }
              if (z == y)
              Console.WriteLine(" {0} ", y);
            }

        }
    }
}
