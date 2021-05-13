using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_ex12_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            double T;

            Console.WriteLine("Digite a temperatura:");
            T = double.Parse(Console.ReadLine());

            if (T < 100)
            {
                Console.WriteLine("A temperatura está muito baixa");
            }
            if (T >= 100 && T < 200)
            {
                Console.WriteLine("A temperatura está baixa");
            }

            if (T >= 200 && T < 500)
            {
                Console.WriteLine("A temperatura está normal");
            }
            if (T >= 500 )
            {
                Console.WriteLine("A temperatura está muito alta");
            }
            Console.ReadKey();





        }
    }
}
