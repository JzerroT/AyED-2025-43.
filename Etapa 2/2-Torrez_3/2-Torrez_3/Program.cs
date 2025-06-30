using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Torrez_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int jugadores, mayorpunt=0 ;
            Console.WriteLine("ingrese la cantidad de jugadores: ");
            jugadores = Convert.ToInt32(Console.ReadLine());
            int[] puntuacion = new int[jugadores];
            for (int i = 0; i < jugadores; i++)
            {
                Console.WriteLine("ingrese la puntuacion del jugador " + (i+1) + ":");
                puntuacion[i] = int.Parse(Console.ReadLine());
                
            }
            for (int i = 0; i < jugadores; i++)
            {
                for (int j = i + 1; j < jugadores; j++)
                {
                    if (puntuacion[i] < puntuacion[j])
                    {
                        int aux = puntuacion[j];
                        puntuacion[j] = puntuacion[i];
                        puntuacion[i] = aux;
                    }
                }
                mayorpunt = puntuacion[0];


            }

            Console.WriteLine("los puntajes ordenados de mayor a menor : ");
            for (int i = 0; i < jugadores; i++)
            {
                Console.WriteLine("puntaje del jugador " + (i+1) + ":" + puntuacion[i]);

            }
            Console.WriteLine("el mejor puntaje es del jugador " + 1 + ":" + puntuacion[0]);
            Console.WriteLine("el peor puntaje es del jugador " + jugadores + ":" + puntuacion[jugadores -1]);

            Console.ReadKey();
        }
    }
}
