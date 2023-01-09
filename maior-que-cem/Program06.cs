using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor qualquer e eu te direi se ele é maior ou menor que 100");
            Console.WriteLine("Digite o valor");
            int n1 = int.Parse(Console.ReadLine());

            if (n1>10*10)
            {
                Console.WriteLine("O valor " + n1 + " é maior que 100");
            }
            else if (n1<10*10)
            {
                Console.WriteLine("O valor " + n1 + " é menor que 100");
            }
            else
            {
                Console.WriteLine("O valor " + n1 + " é igual a 100");
            }
        }
    }
}
