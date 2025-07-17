using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Torrez_10
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 101; i++)
            {
                string palabra = "";
                if (i % 3 == 0) palabra += "fizz";
                if (i % 5 == 0) palabra += "buzz";
                if (palabra == "")
                    Console.WriteLine(i);
                else
                    Console.WriteLine(palabra);
            }
            Console.ReadKey();
        }
    }
}
