using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o quanto sua empresa faturou este mês");
            int ganho= int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quanto sua empresa gastou este mês");
            int gasto = int.Parse(Console.ReadLine());

            if (ganho > gasto) 
            {
                Console.WriteLine("Sua empresa Lucrou $" + (ganho-gasto) + " este mês" );
            }
            else if (gasto > ganho)
            {
                Console.WriteLine("Sua empresa ficou com um prejuizo de $" + (ganho - gasto) + " este mês");
            }
            else
            {
                Console.WriteLine("Sua empresa ficou no 0x0 este mês");
            }
        
        }

    }
}
