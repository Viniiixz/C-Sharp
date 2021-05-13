using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex8_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        { //8. Construa um algoritmo que apresente o nome e o salário dos funcionários, de acordo com os seguintes critérios:
          // Salários que sejam maiores ou iguais a R$ 1000,00 e menores ou(&) iguais a R$ 1500,00-
          // Funcionários pertencentes aos departamentos de produção ou engenharia.-
          //Obs: Os departamentos são reconhecidos pelas letras (P)Produção e(E) Engenharia-
          //São fornecidos o nome do funcionário(NF), o seu salário(SAL) e o departamento onde trabalha(DEP).
            double  sal;
            string nome, dep;
            Console.WriteLine("Nome o funcionário:");
            nome = Console.ReadLine();
            Console.WriteLine("Salário do funcionário:");
            sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Departamento onde trabalha [P/E]:");
            dep = Console.ReadLine();

            if (sal >= 1000 & sal <= 1500 & dep == "P" )
            {
                Console.WriteLine("Nome e o salário do funcionário: {0}, {1}, dep = produção", nome, sal);
            }
            if (sal >= 1000 & sal <= 1500 & dep == "E")
            {
                Console.WriteLine("Nome e o salário do funcionário: {0}, {1}, dep = engenharia", nome, sal);
            }
            Console.ReadKey();
        }
    }
}
