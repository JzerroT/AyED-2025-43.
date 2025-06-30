using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Torrez_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numinvit, promedio = 0 ;
            Console.WriteLine("Ingrese la cantidad de invitados: ");
            numinvit = Convert.ToInt32(Console.ReadLine());
            int[] comida = new int[numinvit];

            for (int i = 0; i < numinvit; i++)
            {
                Console.WriteLine("Ingrese la cantidad de comida del invitado "+i+":");
                comida[i] = int.Parse(Console.ReadLine());
                promedio = promedio + comida[i];

            }
            Console.WriteLine("El promedio de la cantidad de comida es: " + promedio / numinvit);

            Console.ReadKey();
        }
    }
}
