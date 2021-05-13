using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex7_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        //Construa um algoritmo que, recebendo os valores de vendas do mês de determinado vendedor (VM) ok
        //e o nome do mesmo (NOME), apresente o nome,
        // quando o valor da venda estiver entre R$ 10000,00 e R$ 50000,00 (inclusive).
        {
            double VM;
            string NOME;
            Console.WriteLine(" digite o valor das vendas no mes:");
            VM = double.Parse(Console.ReadLine());
            Console.WriteLine("digite seu nome:");
            if (VM >= 10000 & VM <= 50000)
            {
                Console.WriteLine("nome: {0}", NOME);
            }

                      }    
        }
    }

