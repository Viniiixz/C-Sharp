using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex11_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            string CL;
           
            Console.WriteLine("Digite o código do livro[A/B/C]:");
            CL = Console.ReadLine();
          
            if (CL == "a")
            {
                Console.WriteLine("Categoria ficção");
            }
            if (CL == "b")
            {
                Console.WriteLine("Categoria não-ficção");
            }
            if (CL == "c")
            {
                Console.WriteLine("Categoria inválido");
            }
            Console.ReadKey();


        }
    }
}
