using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha: \n1-sinal vermelho \n2-sinal verde");
            int n1 = int.Parse(Console.ReadLine());
            Console.Clear();

            if (n1 == 2)
            {
                Console.WriteLine("Siga");
            }
            else
            {
                Console.WriteLine("Espere");
            }
        }
    }
}
