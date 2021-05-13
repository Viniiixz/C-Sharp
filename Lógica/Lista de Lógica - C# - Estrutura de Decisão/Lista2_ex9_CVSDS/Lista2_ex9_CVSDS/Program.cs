using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex9_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        //Construa um algoritmo que calcule o novo salário (SAL_NOVO) de um funcionário       
        //Considere que o funcionário deverá receber um reajuste de 15% caso seu salário (SAL) seja menor que 500. 
        //Se o salário for maior ou igual a 500, mas menor ou igual a 1000, o reajuste deve ser de 10%. 
        //Caso o salário seja maior que 1000, o reajuste deve ser de 5%.
        {
            double sal;
             

            Console.Write("novo salário do funcionário:");
            sal = double.Parse(Console.ReadLine());

            if (sal < 500)
            {
                Console.WriteLine("Novo salário: {0}", sal * 1.15);
            }
            if (sal >= 500 & sal <= 1000)
            {
                Console.WriteLine("Novo salário: {0}", sal * 1.10);
            }
            if (sal < 1000)
            {
                Console.WriteLine("Novo salário: {0}", sal * 0.50);
            }
            Console.ReadKey();

        }
    }
}
