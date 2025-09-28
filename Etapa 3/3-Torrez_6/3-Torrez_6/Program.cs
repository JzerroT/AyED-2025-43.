using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Torrez_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== MINI BALATRO (versión simplificada) ===\n");
            
            string[] mano = GenerarManoAleatoria();
            
            string tipo = TipoDeMano(mano);
            
            int basePts = PuntajeBase(mano);
            
            double mult = Multiplicador(tipo);
            
            double total = basePts * mult;
            
            bool jokerX2 = true;
            bool jokerMas10 = true;
            total = AplicarJokers(total, jokerX2, jokerMas10);
            
            MostrarResumen(mano, tipo, basePts, mult, total);
        }

        static string[] GenerarManoAleatoria()
        {
            string[] rangos = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
            string[] palos = { "H", "D", "C", "S" };
            string[] mano = new string[5];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                string carta = rangos[rnd.Next(rangos.Length)] + palos[rnd.Next(palos.Length)];
                mano[i] = carta;
            }
            return mano;
        }

        static string TipoDeMano(string[] mano)
        {
            
            int[] conteos = new int[13]; 
            string[] rangos = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };

            for (int i = 0; i < mano.Length; i++)
            {
                string rango = mano[i].Substring(0, 1);
                for (int j = 0; j < rangos.Length; j++)
                {
                    if (rango == rangos[j])
                    {
                        conteos[j]++;
                        break;
                    }
                }
            }

            int pares = 0;
            int trio = 0;
            int cuatro = 0;

            foreach (int c in conteos)
            {
                if (c == 2) pares++;
                else if (c == 3) trio++;
                else if (c == 4) cuatro++;
            }

            if (cuatro == 1) return "Poker";
            if (trio == 1 && pares == 1) return "Full";
            if (trio == 1) return "Trio";
            if (pares == 1) return "Par";
            return "Nada";
        }

        static int PuntajeBase(string[] mano)
        {
            int total = 0;
            for (int i = 0; i < mano.Length; i++)
            {
                string rango = mano[i].Substring(0, 1);
                switch (rango)
                {
                    case "A": total += 14; break;
                    case "K": total += 13; break;
                    case "Q": total += 12; break;
                    case "J": total += 11; break;
                    case "T": total += 10; break;
                    case "9": total += 9; break;
                    case "8": total += 8; break;
                    case "7": total += 7; break;
                    case "6": total += 6; break;
                    case "5": total += 5; break;
                    case "4": total += 4; break;
                    case "3": total += 3; break;
                    case "2": total += 2; break;
                }
            }
            return total;
        }

        static double Multiplicador(string tipo)
        {
            switch (tipo)
            {
                case "Nada": return 1.0;
                case "Par": return 1.5;
                case "Trio": return 2.5;
                case "Full": return 3.5;
                case "Poker": return 4.0;
                default: return 1.0;
            }
        }

        static double AplicarJokers(double puntaje, bool x2, bool mas10)
        {
            if (x2) puntaje *= 2;
            if (mas10) puntaje += 10;
            return puntaje;
        }

        static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
        {
            Console.Write("Mano: ");
            for (int i = 0; i < mano.Length; i++)
            {
                Console.Write("[" + mano[i] + "] ");
            }
            Console.WriteLine();
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Puntaje base: " + basePts);
            Console.WriteLine("Multiplicador: x" + mult);
            Console.WriteLine("Total (con Jokers): " + total);
            Console.ReadKey();
        }
        
    }
}

