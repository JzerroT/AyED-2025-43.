using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Torrez_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3; 
            int[,] matriz = new int[n, n]; 
            int[] diagonal = new int[n]; 
            Random rnd = new Random();
            Console.WriteLine("La matriz");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = rnd.Next(1, 101);
                    Console.WriteLine(matriz[i, j]); 
                }
            }

            Console.WriteLine("Su diagonal: ");
            for (int i = 0; i < n; i++)
            {
                diagonal[i] = matriz[i, i]; 
                Console.WriteLine(diagonal[i]);
            }

            Console.ReadKey(); 
        }
    }
}
