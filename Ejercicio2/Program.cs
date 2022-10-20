using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            num = 0;

            while (num <= 100)
            {
                if (num/2 != (int)(num/2))
                {
                    Console.WriteLine("El siguiente número no es divisible por 2: " + num);
                }
                num++;
            }
            Console.ReadKey();
        }
    }
}
