using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Torrez_2
{
    class Program
    {
        static double suma(double n, double m)
        {
            double resultado = n + m;
            return resultado;
        }

        static double resta(double n, double m)
        {
            double resultado = n - m;
            return resultado;
        }

        static double multiplicacion(double n, double m)
        {
            double resultado = n * m;
            return resultado;
        }

        static double division(double n, double m)
        {
            if (m == 0)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                return 0;
            }
            double resultado = n / m;
            return resultado;
        }

        static double calculadora(double n, double m, int opcion)
        {
            switch (opcion)
            {
                case 1:
                    return suma(n, m);
                case 2:
                    return resta(n, m);
                case 3:
                    return multiplicacion(n, m);
                case 4:
                    return division(n, m);
                default:
                    Console.WriteLine("Opción inválida.");
                    return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Dame un número: ");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("Dame otro número: ");
            double m = double.Parse(Console.ReadLine());

            Console.WriteLine("¿Qué operación querés hacer?");
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicación");
            Console.WriteLine("4 - División");
            Console.Write("Opción: ");
            int opcion = int.Parse(Console.ReadLine());

            double resultado = calculadora(n, m, opcion);
            Console.WriteLine("Resultado: " + resultado);
            Console.ReadKey();
        }
    }
}

