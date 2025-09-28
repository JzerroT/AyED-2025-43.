using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Torrez_1
{
    class Program
    {
        static int suma(int n, int m)
        {
            int resultado = n + m;
            return resultado;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("dame un numero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dame otro numero: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int resultado = suma(n, m);
            Console.WriteLine("la suma de esos 2 numeros es: " + resultado);
            Console.ReadKey();

        }
    }
}
