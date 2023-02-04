using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o quanto pretende pagar mensalmente ");
            int pre =int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu sálario bruto ");
            int sal =int.Parse(Console.ReadLine());

            if (pre * 0.30 > sal)
            {
                Console.WriteLine("Infelizmente seu crédito não foi aprovado");
            }
            else
            {
                Console.WriteLine("Parabéns, seu crédito foi aprovado");
            }
                
        }
    }
}
