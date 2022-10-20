using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            float precio, iva, total;

            Console.WriteLine("Ingrese el valor del producto");
            precio = float.Parse(Console.ReadLine());

            iva = precio * float.Parse("0,21");
            Console.WriteLine("El valor del IVA del producto ingresado es: " + iva.ToString());

            total = precio + iva;
            Console.WriteLine("El valor final del producto más el IVA es: $" + total.ToString());
            Console.ReadKey();
        }
    }
}
