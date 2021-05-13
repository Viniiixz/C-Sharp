using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {  //Calcule a área e o perímetro de qualquer triângulo ao informar o comprimento dos 3 lados. Realizar um teste com os valores para verificar se os lados formam mesmo um triângulo.
            //Deverá informar ainda se é um triângulo isósceles, equilátero ou escaleno. OBS: Para se formar um triângulo segue a regra para os lados a, b e c: (a <=b+c) && (b<=a+c) && (c<=a+b).
            //A fórmula geral da área de qualquer triângulo é: √𝑝(𝑝−𝑎)(𝑝−𝑏)(𝑝−𝑐) onde 𝑝=𝑎+𝑏+𝑐/2.
            double X, Y, Z, g, ar, arg;
            Console.Write("Digite o comprimento do primeiro lado: ");
            X = double.Parse(Console.ReadLine());
            Console.Write("Digite o comprimento do segundo lado: ");
            Y = double.Parse(Console.ReadLine());
            Console.Write("Digite o comprimento do terceiro lado: ");
            Z = double.Parse(Console.ReadLine());
            Console.Clear();
            g = (X + Y + Z) / 2;
            arg = g * (g - X) * (g - Y) * (g - Z);
            ar = Math.Sqrt(arg);
            if (X <= Y + Z && Y <= X + Z && Z <= X + Y)
            {
                if (X == Y && Y == Z)
                {
                    Console.WriteLine("Esse Triângulo é: Equilátero");
                    Console.WriteLine("Perimetro do triângulo: {0}", g);
                    Console.WriteLine("Área do triângulo: {0}", ar);
                }
                else if (X == Y && Y != Z || Z == Y && Z != X)
                {
                    Console.WriteLine("Esse Triângulo é: Isósceles");
                    Console.WriteLine("Perimetro do triângulo: {0}", g);
                    Console.WriteLine("Área do triângulo: {0}", ar);
                }
                else if (X != Y && X != Z && Z != Y)
                {
                    Console.WriteLine("Esse Triângulo é: Escaleno");
                    Console.WriteLine("Perimetro do triângulo: {0}", g);
                    Console.WriteLine("Área do triângulo: {0}", ar);
                }
                else
                {
                    Console.WriteLine("Não é um triângulo");
                }
                Console.ReadKey();
            }
        }
    }
}
