using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float precio, total;

            Console.WriteLine("Ingrese el valor del producto");
            precio = float.Parse(Console.ReadLine());

            total = CalcularIVA(precio);
            Console.WriteLine("El valor final del producto más el IVA es: $" + total.ToString());
            Console.ReadKey();
        }

        static float CalcularIVA(float n1)
        {
            float result = n1 * float.Parse("1,21");
            return result;
        }
    }
}
