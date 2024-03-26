using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumUmCem
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Informe qual número você deseja saber os múltiplos: ");
            int num = int.Parse(Console.ReadLine());
            int cont = num;


            while (cont <= 100)
            {
                Console.WriteLine(cont);
                cont += num;
            }

            Console.ReadKey();



        }
    }
}
