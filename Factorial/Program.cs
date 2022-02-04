using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        public static Int32 Factorial(int Numero)
        {

            if (Numero == 1)
            {
                return 1;
               
            }

            return Numero * Factorial(Numero - 1);           

        }
        static void Main(string[] args)
        {
            int Numero;
            Console.WriteLine("Introduzca un numero: ");
            Numero = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("El factorial es: " + Factorial(Numero));
            Console.ReadKey();

        }
    }
}
