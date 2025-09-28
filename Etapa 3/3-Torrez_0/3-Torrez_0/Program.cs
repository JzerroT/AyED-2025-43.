using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Torrez_0
{
    class Program
    {
        static string holanombre(string nombre)
        {
            return "Hola, " + nombre ;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es tu nombre?: ");
            string nombre = Console.ReadLine();
            string saludo = holanombre(nombre);
            Console.WriteLine(saludo);
            Console.ReadKey();



        }
    }
}
