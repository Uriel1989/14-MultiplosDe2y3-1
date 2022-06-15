using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14_MultiplosDe2y3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Los multiplos de 2 son " + i);
                }
            }

            for( i=0; i<=100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Los multiplos de 3 son " + i);
                }
            }
            Console.ReadKey();
        }
    }
}
