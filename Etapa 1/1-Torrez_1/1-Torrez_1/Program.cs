using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Torrez_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña = "barro";
            string contraseña1;
            Console.WriteLine("Introduce la contraseña: ");

            contraseña1 = Console.ReadLine();
            if (contraseña1 == contraseña)
            {
                Console.WriteLine("la contraseña coincide");


            }
            else
            {
                Console.WriteLine("la contraseña no coincide");
            }
            Console.ReadKey();
        }
    }
}
