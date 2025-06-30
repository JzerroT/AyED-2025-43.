using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Torrez_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el tamaño de las matrices:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matriz1 = new int[n, n];
            int[,] matriz2= new int[n, n];
            int[,] sumamatriz= new int[n,n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int J= 0; J < n; J++)
                {
                    matriz1[i, J] = rand.Next(1, 100);
                    matriz2[i, J] = rand.Next(1, 100);
                    sumamatriz[i, J] = matriz1[i, J] + matriz2[i, J];
                }
            }
            Console.WriteLine("Matriz 1:");
            Console.WriteLine(Matriz1);
            Console.ReadKey();
        }
    }
}
