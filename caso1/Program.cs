using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caso1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int personas;
            float costo;
            Console.WriteLine("Ingrese la cantidad de personas: ");
            personas = int.Parse(Console.ReadLine());   
            if (personas > 300)
            {
                costo = personas * 75;
            }
            else
            {
                if (personas > 200)
                {
                    costo = personas * 85;
                }
                else
                {
                    costo = personas * 95;
                }
            }
            Console.WriteLine("El total a pagar es de: S/" + costo.ToString("0.00"));

            Console.ReadKey();
        }
    }
}
