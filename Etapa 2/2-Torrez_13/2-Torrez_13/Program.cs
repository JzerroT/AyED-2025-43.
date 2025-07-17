using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Torrez_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 3;
            string[,] estudiantes = new string[N, 3];
            estudiantes[0, 0] = "Juan";       
            estudiantes[0, 1] = "20";          
            estudiantes[0, 2] = "8.5";
            estudiantes[1, 0] = "Ana";
            estudiantes[1, 1] = "22";
            estudiantes[1, 2] = "9.0";
            estudiantes[2, 0] = "Luis";
            estudiantes[2, 1] = "19";
            estudiantes[2, 2] = "7.8";

             
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Estudiante " + (i + 1) + ":");
                Console.WriteLine("Nombre: " + estudiantes[i, 0]);
                Console.WriteLine("Edad: " + estudiantes[i, 1]);
                Console.WriteLine("Calificación: " + estudiantes[i, 2]);
                


            }
            Console.ReadKey();
        }

    }
}

