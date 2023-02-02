using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de vitórias da sua equipe ");
            int vit = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de derrotas da sua equipe ");
            int der = int.Parse(Console.ReadLine());
            Console.Clear();

            if (vit> der)
            {
                Console.WriteLine("Pronto para a Libertadores");
            }
            else if (vit < der)
            {
                Console.WriteLine("Arêrê seu time vai jogar a série B");
            }
            else
            {
                Console.WriteLine("Pelo menos não vai cair");
            }
        }

    }
}
