using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números quaisquer e eu dividirei o maior pelo menor");
            Console.WriteLine("Digite o primeiro valor");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            int n2= int.Parse(Console.ReadLine());
            Console.Clear();
            if (n1 > n2)
            {
                Console.WriteLine("O valor final é " + n1 / n2);
            }
             else
            {
                Console.WriteLine("O valor final é " + n2 / n1);
            }
        }

    }
}
