using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Torrez_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool salida = false;
            Console.WriteLine("Ingrese el valor del vector n: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] valor = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                valor[i] = rand.Next(1, 100);

            }

            do
            {
                Console.WriteLine("============ Menu ============");
                Console.WriteLine("1. Imprimir en pantalla todos los elementos del vector");
                Console.WriteLine("2. Numero en busqueda");
                Console.WriteLine("3. Ordenamiento del vector");
                Console.WriteLine("4. Salir del programa");
                int opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Elementos de todos los vectores");
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("vector " + (i + 1) + ":" + valor[i]);

                        }
                        break;
                    case 2:
                        Console.WriteLine("ingres su numero:");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        bool encontrado = false;
                        for (int i = 0; i < n; i++)
                        {
                            if (numero == valor[i])
                            {
                                Console.WriteLine("su numero se encuentra en la posicion del vector" + (i + 1));
                                encontrado = true;
                                break;
                            }

                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("su numero no se encuentra");
                           
                        }
                        break;

                    case 3:
                        Console.WriteLine("Si quiere que este ordenado de forma ascendente apriete 1, y si quiere que este de forma descendente apriete 2");
                        int orden = Convert.ToInt32(Console.ReadLine());
                        if (orden == 1)
                        {
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (valor[i] < valor[j])
                                    {
                                        int aux = valor[j];
                                        valor[j] = valor[i];
                                        valor[i] = aux;
                                    }
                                }
                            }
                            Console.WriteLine("Vector ordenado de forma ascendentemente:");
                        }
                        else if (orden == 2)
                        {
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (valor[i] > valor[j])
                                    {
                                        int aux = valor[j];
                                        valor[j] = valor[i];
                                        valor[i] = aux;
                                    }
                                }
                            }
                            Console.WriteLine("Vector ordenado de forma descendentemente:");
                        }
                        else
                        {
                            Console.WriteLine("Opción inválida.");
                            break;
                        }

                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("vector " + (i + 1) + ":" + valor[i]);

                        }

                        break;
                    case 4:
                        Console.WriteLine("Saliste del juego");
                        salida = true;
                        break;
                }
            } while (!salida);
            Console.ReadKey();
        }
    }
}
