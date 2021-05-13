using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        { //Ler um número inteiro menor que 1000 e imprima a quantidade de centenas, dezenas e unidades do mesmo.

            float centena, dezena, unidade, numero;
            Console.Write("Digite um número inteiro até 1000:");
            numero = float.Parse(Console.ReadLine());
            centena = numero / 100;
            dezena = (((centena) *100)/10 * 1);
            unidade = ((centena * 100 + dezena * 10) - numero);
            Console.WriteLine("As casas decimais do número são: \ncentenas: {0} \ndezenas: {1} \nunidade {2}", centena, dezena, unidade);
            Console.ReadKey();
           
            
           
           
        }
    }
}
