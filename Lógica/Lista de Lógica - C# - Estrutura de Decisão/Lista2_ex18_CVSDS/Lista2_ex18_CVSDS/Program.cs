using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex18_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            double AN, ID;

            Console.Write("Digite seu ano de nascimento:");
            AN = double.Parse(Console.ReadLine());

            ID = 2018 - AN;
            if (ID >= 16 && ID < 18)
            {
                Console.WriteLine("Sua idade é: {0}", ID);
                Console.WriteLine("Já pode votar");
            }
            if (ID >= 18)
            {
                Console.WriteLine("Sua idade é: {0}", ID);
                Console.WriteLine("Já pode tirar a carteira de habilitação");
            }
            Console.ReadKey();
        }
    }
}
