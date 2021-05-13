using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_EX1_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            int cd = 0;
            Console.Write("Digite o número do curso: \n1 - Informática \n2 - Enfermagem  \n3 - Edificações" );                                                                                                                          
            string nm, mod, esc, mat;

            cd = int.Parse(Console.ReadLine());
            Console.Write("Digite o seu nome:");
            nm = Console.ReadLine();
            Console.Write("Digite o seu módulo:");
            mod = Console.ReadLine();
            Console.Write("Digite o seu escola:");
            esc = Console.ReadLine();
            Console.Write("Digite o seu matéria:");
            mat = Console.ReadLine();
            switch (cd)
            {
                case 1:
                    Console.WriteLine("Imformática");
                    break;
                case 2:
                    Console.WriteLine("Enfermagem");
                    break;
                case 3:
                    Console.WriteLine("Edificações");
                    break;
                default:
                    Console.WriteLine("Este curso não existe!");
                    break;
            }
                    Console.WriteLine("Seu nome é: {0}", nm);
                    Console.WriteLine("Seu módulo é: {0}", mod);
                    Console.WriteLine("Sua escola é: {0}", esc);
                    Console.WriteLine("Sua matéria é: {0}", mat);
            
            Console.ReadKey();






        }
    }
}
