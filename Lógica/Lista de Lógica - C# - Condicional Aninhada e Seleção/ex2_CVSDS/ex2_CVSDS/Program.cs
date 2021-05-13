using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            int cd = 1;
            string item1, item2, item3, item4, item5;
        
            Console.Write("Digite 1º material:");
            item1 = Console.ReadLine();
            Console.Write("Digite 2º material:");
            item2 = Console.ReadLine();
            Console.Write("Digite 3º material:");
            item3 = Console.ReadLine();
            Console.Write("Digite 4º material:");
            item4 = Console.ReadLine();
            Console.Write("Digite 5º material:");
            item5 = Console.ReadLine();
                        
            switch (cd)
            {
                case 1:
                    Console.Write("1º material: {0}", item1);
                
                    Console.Write("2º material: {0}", item2); 
                
                    Console.Write("3º material: {0}", item3);
                
                    Console.Write("4º material: {0}", item4);
                
                    Console.Write("5º material: {0}", item5);
                    break;
            }
            Console.ReadKey();






        }
    }
}
