using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Torrez_15
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Jugador 1";
            int salud = 100;
            int hambre = 50;
            int energia = 70;
            int dia = 1;
            bool siguevivo = true;
            bool salida = false;
            Random rand = new Random();

            do
            {
                Console.Clear();
                Console.WriteLine("============ SOBREVIVE A LA ISLA POR 7 DÍAS ============");
                Console.WriteLine("Día " + dia + " - ¿Qué querés hacer?");
                Console.WriteLine("1. Buscar comida");
                Console.WriteLine("2. Dormir");
                Console.WriteLine("3. Explorar la isla");
                Console.WriteLine("4. Ver estado del personaje");
                Console.WriteLine("5. Salir del juego");

                int opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Pudiste encontrar comida pero tu energía bajó. Hambre +20, Energía -15");
                        hambre += 20;
                        energia -= 15;
                        int prob1 = rand.Next(1, 101);
                        if (prob1 <= 30)
                        {
                            Console.WriteLine("Comiste algo en mal estado. Salud -15");
                            salud -= 15;
                        }
                        dia++;
                        break;

                    case 2:
                        Console.WriteLine("Tu energía subió +30, pero estás hambriento. Hambre -10");
                        energia += 30;
                        hambre -= 10;
                        dia++;
                        break;

                    case 3:
                        Console.WriteLine("Tu energía bajó -20 y tu hambre bajó -15");
                        energia -= 20;
                        hambre -= 15;
                        int prob2 = rand.Next(1, 101);
                        if (prob2 <= 50)
                        {
                            Console.WriteLine("¡Encontraste una planta curativa! Salud +10");
                            salud += 10;
                        }
                        dia++;
                        break;

                    case 4:
                        Console.WriteLine("Estado del " + nombre);
                        Console.WriteLine("Salud = " + salud);
                        Console.WriteLine("Hambre = " + hambre);
                        Console.WriteLine("Energía = " + energia);
                        break;

                    case 5:
                        Console.WriteLine("Saliste del juego.");
                        salida = true;
                        break;
                }

                if (salud <= 0 || hambre <= 0 || energia <= 0)
                {
                    Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over.");
                    siguevivo = false;
                    salida = true;
                }

                if (dia > 7 && siguevivo)
                {
                    Console.WriteLine("Sobreviviste 7 días en la isla ¡Ganaste!");
                    salida = true;
                }

                if (!salida)
                {
                    Console.WriteLine("Presiona una tecla para continuar");
                    Console.ReadKey();
                }

            } while (!salida);
        }
    }
}

