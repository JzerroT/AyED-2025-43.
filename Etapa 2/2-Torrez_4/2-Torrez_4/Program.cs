using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Torrez_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int productvent, mayorprecio = 0, menorprecio = 0;
            Console.WriteLine("ingrese la cantidad de productos vendidos: ");
            productvent = Convert.ToInt32(Console.ReadLine());
            int[] precio = new int[productvent];
            for (int i = 0; i < productvent; i++)
            {
                Console.WriteLine("ingrese el precio del producto " + (i + 1) + ":");
                precio[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < productvent; i++)
            {
                for (int j = i + 1; j < productvent; j++)
                {
                    if (precio[i] < precio[j])
                    {
                        int aux = precio[j];
                        precio[j] = precio[i];
                        precio[i] = aux;
                    }
                }
                mayorprecio = precio[0];
                menorprecio = precio[productvent - 1];

            }

            Console.WriteLine("los precios ordenados de mayor a menor : ");
            for (int i = 0; i < productvent; i++)
            {
                Console.WriteLine("precio del producto " + (i + 1) + ":" + precio[i]);

            }
            Console.WriteLine("el precio mas alto es del producto " + 1 + ":" + mayorprecio);
            Console.WriteLine("el precio mas barato es del producto " + productvent + ":" + menorprecio);

            Console.ReadKey();
        }
    }
}

        
