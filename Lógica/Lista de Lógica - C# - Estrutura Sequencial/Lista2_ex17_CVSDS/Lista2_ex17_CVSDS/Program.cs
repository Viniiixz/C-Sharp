using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex17_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            double PR;
            string CO;

            Console.Write("Preço do produto R$:");
            PR = double.Parse(Console.ReadLine());
            Console.Write("Digite o seu código de origem:");
            CO = Console.ReadLine();
             
        if (CO == "1")
            {
                Console.WriteLine("Sua procedência é: Sul ");
                Console.WriteLine("O preço é R$:{0}", PR);
            }

            if (CO == "2")
            {
                Console.WriteLine("Sua procedência é: Suldeste ");
                Console.WriteLine("O preço é R$:{0}", PR);
            }

            if (CO == "3")
            {
                Console.WriteLine("Sua procedência é: Centro-Oeste" );
                Console.WriteLine("O preço é R$:{0}", PR);
            }

            if (CO == "4")
            {
                Console.WriteLine("Sua procedência é: Norte" );
                Console.WriteLine("O preço é R$:{0}", PR);
            }

            if (CO == "5")
            {
                Console.WriteLine("Sua procedência é: Nordeste ");
                Console.WriteLine("O preço é R$:{0}", PR);
            }
            Console.ReadKey();
        }
    }
}
