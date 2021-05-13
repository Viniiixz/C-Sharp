using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Digite um número inteiro:");
            x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é impar");
            }
            Console.ReadKey();
        }
    }
}
