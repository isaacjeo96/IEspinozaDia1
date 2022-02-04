using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        public int Suma(int Numero1, int Numero2)
        {
            int Resultado = Numero1 + Numero2;
            return Resultado;
        }

        public int Resta(int Numero1, int Numero2)
        {
           int Resultado = Numero1 - Numero2;
            return Resultado;
        }

        public int Multiplicacion(int Numero1, int Numero2)
        {
           int Resultado = Numero1 * Numero2;
            return Resultado;
        }

        public int Division(int Numero1, int Numero2)
        {
           int Resultado = Numero1 / Numero2;
            return Resultado;
        }
        static void Main(string[] args)
        {
            Program operacion = new Program();

            Console.WriteLine("El resultado de la suma es:" + operacion.Suma(5,8));
            Console.WriteLine("El resultado de la resta es:" + operacion.Resta(10,5));
            Console.WriteLine("El resultado de la multiplicacion es:" + operacion.Multiplicacion(12,2));
            Console.WriteLine("El resultado de la division es:" + operacion.Division(100,2));
            
            
            Console.ReadLine(); 
        }
    }
}
