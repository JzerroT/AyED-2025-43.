using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Torrez_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int examen, tp,aprobadotp = 0 ,promediotp=0, sumaexam=0 ;
            Console.WriteLine("ingrese la cantidad de trabajos practicos: ");
            tp = Convert.ToInt32(Console.ReadLine());
            int[] cantidadtp = new int[tp];
            for (int i=0 ; i < tp; i++ )
            {
                Console.WriteLine("ingrese la nota del tp "+i+":");
                cantidadtp[i] = int.Parse(Console.ReadLine());
                if (cantidadtp[i] >= 6)
                {
                    aprobadotp = aprobadotp + 1;
                    promediotp = (aprobadotp / tp) * 100;
                }

            }
            Console.WriteLine("ingrese la cantidad de examenes: ");
            examen = Convert.ToInt32(Console.ReadLine());
            int[] cantidadexam = new int[examen];
            for (int i = 0; i < tp; i++)
            {
                Console.WriteLine("ingrese la nota del examen " + i + ":");
                cantidadexam[i] = int.Parse(Console.ReadLine());
                sumaexam = sumaexam + cantidadexam[i];
            }
            Console.WriteLine("el pporcentaje total de los trabajos practicos es: " + promediotp +"%");
            Console.WriteLine("el promedio total de los examenes es: "+ sumaexam/examen);

           
            Console.ReadKey();
        }
        
    }
}
