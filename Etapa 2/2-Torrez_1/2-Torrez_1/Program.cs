using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Torrez_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int vueltas, mejorvuelt = 0 , tiempototal = 0 ;
            Console.WriteLine("Ingresa la cantidad de las vueltas: ");
            vueltas = Convert.ToInt32(Console.ReadLine());
            int[] tiempo = new int[vueltas];
            for (int i = 0 ; i < vueltas ; i++ )
            {
                Console.WriteLine("El tiempo en segundos de la " + i + " vuelta es de: ");
                tiempo[i] = int.Parse(Console.ReadLine());
                tiempototal = tiempototal + tiempo[i];
            }
            for (int i = 0; i < vueltas; i++)
            {
                for (int j = i + 1; j < vueltas; j++ )
                {
                    if ( tiempo[i] > tiempo[j])
                    {
                    int aux = tiempo[j];
                    tiempo[j] = tiempo[i];
                    tiempo[i] = aux;
                    }
                }
                mejorvuelt = tiempo[0];

            }
            Console.WriteLine("El tiempo total de las vueltas es de : " + tiempototal);
            Console.WriteLine("El promedio del tiempo total es de : " + tiempototal / vueltas);
            Console.WriteLine("la mejor vuelta fue : " + mejorvuelt);
            Console.ReadKey();
        }
    }
}
