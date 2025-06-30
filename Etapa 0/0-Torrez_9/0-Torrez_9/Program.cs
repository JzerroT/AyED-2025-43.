using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Torrez_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int radio;
            float pi = 3.1415f;
            Console.WriteLine("ingresa la medida del radio de una esfera: ");
            radio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("el volumen de la esfera es " + ((4 / 3) * pi * radio * radio * radio));
            Console.WriteLine("la superficie de la esfera es " + (4 * pi * radio * radio));
            Console.ReadKey();
        }
    }
}
