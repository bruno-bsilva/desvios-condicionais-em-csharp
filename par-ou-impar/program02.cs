using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número e eu te direi se ele é par ou impar ");
            Console.WriteLine("Digite o número ");
            int n1= int.Parse(Console.ReadLine());
            Console.Clear();    
            if (n1%2 ==0)
            {
                Console.WriteLine("O número " + n1 + " é par");          
            }
            else
            {
                Console.WriteLine("O número " + n1 + " é impar");
            }
        
        }   

    }
}
