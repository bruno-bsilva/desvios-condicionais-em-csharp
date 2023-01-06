using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números diferentes de 0 e eu te direi o produto entre eles");
            Console.WriteLine("Digite o primeiro número");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 != 0 && n2 != 0)
            
                
                    Console.WriteLine("O produto entre " + n1 + " e " + n2 + " é " + (n1 * n2));
                
            else
            {
                Console.WriteLine("Os valores devem ser diferentes de zero");
            }
        
        }

    }
}
