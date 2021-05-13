using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sorteio = new Random();//geração aleatória do número
            int resultado = sorteio.Next(1, 10), A; //variaveis
            Console.Write("Tente acertar o numero gerado aleatoriamente pelo programa");
            Console.WriteLine();
            Console.Write("Digite um numero que esteja entre 1 e 10:");
            A = int.Parse(Console.ReadLine());
            if (A == resultado)//caso esteja certo
            {
                Console.WriteLine("PARABENS VOCE ACERTOU O NUMERO HEHEHE");
                Console.WriteLine("resultado: " + A);
            }
            if (A != resultado && A >= 1 && A <= 10) //errado
            {
                Console.WriteLine("voce perdeu, o numero sorteado era: " + resultado);
            }
            if (A>=11 || A <= 0) //mensagem de erro
            {
                Console.Write("algo de errado nao esta certo, meu caro");
            }

            Console.ReadKey();
            
       

        }
    }
}
