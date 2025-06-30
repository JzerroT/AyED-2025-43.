using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Torrez_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese numero de fila: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese numero de columna: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[n, m];
            Console.WriteLine("matriz"  );
            for (int i=0; i < n ;i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(+matriz[i,j]+"  ");
                }
            }

            Console.ReadKey();
        }
    }
}
