using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex16_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {//Um posto está vendendo combustíveis com a seguinte tabela de descontos:
         // Álcool: até 20 litros = desconto de 3 % por litro; acima de 20 litros = desconto de 5 % por litro.
         //Gasolina: até 20 litros = desconto de 4 % por litro; acima de 20 litros = desconto de 6 % por litro.
         //O programa deverá ler o número de litros vendidos, o tipo de combustível 
         //(codificado da seguinte forma: A - álcool, G - gasolina), calcular e mostrar o valor a ser pago pelo cliente. 
         //Considere o preço do litro da gasolina = R$ 4,15 e o preço do litro do álcool = R$ 2,80.

            double litro, total, desc;
            string c;

            Console.Write("Digite o tipo de combústivel [A=álcool|G=gasolina]:");
            c = Console.ReadLine();
            Console.Write("Digite a quantidade de combustivel:");
            litro = double.Parse(Console.ReadLine());

            if (c == "a" && litro <= 20)
            {
                total = (litro * 2.80);
                desc = (total * 3 / 100);
                total = total - desc;
                Console.WriteLine("O total de alcool a ser pago é:{0}", total);
            }
            else if (c == "a" && litro > 20)
            {
                total = (litro * 2.80);
                desc = (total * 5 / 100);
                total = total - desc;
                Console.WriteLine("O total de alcool a ser pago é:{0}", total);
            }
            if (c == "g" && litro <= 20)
            {
                total = (litro * 4.15);
                desc = (total * 4 / 100);
                total = total - desc;
                Console.WriteLine("O total de gasolina a ser pago é:{0}", total);
            }
            else if (c == "g" && litro > 20)
            {
                total = (litro * 4.15);
                desc = (total * 6 / 100);
                total = total - desc;
                Console.WriteLine("O total de gasolina a ser pago é:{0}", total);
            }

            Console.ReadKey();



        }
    }
}
