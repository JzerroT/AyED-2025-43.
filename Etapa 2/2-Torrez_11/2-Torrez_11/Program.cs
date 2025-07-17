using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Torrez_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = {{ 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 }};
            int n = 3;
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++) 
                {
                    Console.WriteLine(matriz[i, j]);
                   
                }

            }
           
            for (int i = 0; i < n; i++)
            {
                for (int j = 0+1; j < n; j++)
                {
                    int aux = matriz[i, j];
                    matriz[i, j] = matriz[j, i];
                    matriz[j, i] = aux;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int aux = matriz[i, j];
                    matriz[i, j] = matriz[i, n - 1 - j];
                    matriz[i, n - 1 - j] = aux;
                }
            }

            Console.WriteLine("La matriz rotada es asi:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(matriz[i, j]);
                   
                }
        
            }
            Console.ReadKey();
        }
    }
}
        