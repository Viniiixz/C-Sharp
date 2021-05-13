using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 1, n2 = 2, n3 = 3, n4 = 4, n5 = 5, n6 = 6, n7 = 7, n8 = 8, n9 = 9, n10 = 10;
            int tabuada = 2;
            Console.Write("Digite um valor de 2 a 10 para calcular a tabuada:");
            tabuada = int.Parse(Console.ReadLine());
             switch (tabuada)
            {
                case 2:
                    Console.WriteLine("2x1={0}", 2 * n1);
                    Console.WriteLine("2x2={0}", 2 * n2);
                    Console.WriteLine("2x3={0}", 2 * n3);
                    Console.WriteLine("2x4={0}", 2 * n4);
                    Console.WriteLine("2x5={0}", 2 * n5);
                    Console.WriteLine("2x6={0}", 2 * n6);
                    Console.WriteLine("2x7={0}", 2 * n7);
                    Console.WriteLine("2x8={0}", 2 * n8);
                    Console.WriteLine("2x9={0}", 2 * n9);
                    Console.WriteLine("2x10={0}", 2 * n10);
                    break;

                case 3:
                    Console.WriteLine("3x1={0}", 3 * n1);
                    Console.WriteLine("3x2={0}", 3 * n2);
                    Console.WriteLine("3x3={0}", 3 * n3);
                    Console.WriteLine("3x4={0}", 3 * n4);
                    Console.WriteLine("3x5={0}", 3 * n5);
                    Console.WriteLine("3x6={0}", 3 * n6);
                    Console.WriteLine("3x7={0}", 3 * n7);
                    Console.WriteLine("3x8={0}", 3 * n8);
                    Console.WriteLine("3x9={0}", 3 * n9);
                    Console.WriteLine("3x10={0}", 3 * n10);
                    break;

                case 4:
                    Console.WriteLine("4x1={0}", 4 * n1);
                    Console.WriteLine("4x2={0}", 4 * n2);
                    Console.WriteLine("4x3={0}", 4 * n3);
                    Console.WriteLine("4x4={0}", 4 * n4);
                    Console.WriteLine("4x5={0}", 4 * n5);
                    Console.WriteLine("4x6={0}", 4 * n6);
                    Console.WriteLine("4x7={0}", 4 * n7);
                    Console.WriteLine("4x8={0}", 4 * n8);
                    Console.WriteLine("4x9={0}", 4 * n9);
                    Console.WriteLine("4x10={0}", 4 * n10);
                    break;

                case 5:
                    Console.WriteLine("5x1={0}", 5 * n1);
                    Console.WriteLine("5x2={0}", 5 * n2);
                    Console.WriteLine("5x3={0}", 5 * n3);
                    Console.WriteLine("5x4={0}", 5 * n4);
                    Console.WriteLine("5x5={0}", 5 * n5);
                    Console.WriteLine("5x6={0}", 5 * n6);
                    Console.WriteLine("5x7={0}", 5 * n7);
                    Console.WriteLine("5x8={0}", 5 * n8);
                    Console.WriteLine("5x9={0}", 5 * n9);
                    Console.WriteLine("5x10={0}", 5 * n10);
                    break;

                case 6:
                    Console.WriteLine("6x1={0}", 6 * n1);
                    Console.WriteLine("6x2={0}", 6 * n2);
                    Console.WriteLine("6x3={0}", 6 * n3);
                    Console.WriteLine("6x4={0}", 6 * n4);
                    Console.WriteLine("6x5={0}", 6 * n5);
                    Console.WriteLine("6x6={0}", 6 * n6);
                    Console.WriteLine("6x7={0}", 6 * n7);
                    Console.WriteLine("6x8={0}", 6 * n8);
                    Console.WriteLine("6x9={0}", 6 * n9);
                    Console.WriteLine("6x10={0}", 6 * n10);
                    break;

                case 7:
                    Console.WriteLine("7x1={0}", 7 * n1);
                    Console.WriteLine("7x2={0}", 7 * n2);
                    Console.WriteLine("7x3={0}", 7 * n3);
                    Console.WriteLine("7x4={0}", 7 * n4);
                    Console.WriteLine("7x5={0}", 7 * n5);
                    Console.WriteLine("7x6={0}", 7 * n6);
                    Console.WriteLine("7x7={0}", 7 * n7);
                    Console.WriteLine("7x8={0}", 7 * n8);
                    Console.WriteLine("7x9={0}", 7 * n9);
                    Console.WriteLine("7x10={0}", 7 * n10);
                    break;

                case 8:
                    Console.WriteLine("8x1={0}", 8 * n1);
                    Console.WriteLine("8x2={0}", 8 * n2);
                    Console.WriteLine("8x3={0}", 8 * n3);
                    Console.WriteLine("8x4={0}", 8 * n4);
                    Console.WriteLine("8x5={0}", 8 * n5);
                    Console.WriteLine("8x6={0}", 8 * n6);
                    Console.WriteLine("8x7={0}", 8 * n7);
                    Console.WriteLine("8x8={0}", 8 * n8);
                    Console.WriteLine("8x9={0}", 8 * n9);
                    Console.WriteLine("8x10={0}", 8 * n10);
                    break;

                case 9:
                    Console.WriteLine("9x1={0}", 9 * n1);
                    Console.WriteLine("9x2={0}", 9 * n2);
                    Console.WriteLine("9x3={0}", 9 * n3);
                    Console.WriteLine("9x4={0}", 9 * n4);
                    Console.WriteLine("9x5={0}", 9 * n5);
                    Console.WriteLine("9x6={0}", 9 * n6);
                    Console.WriteLine("9x7={0}", 9 * n7);
                    Console.WriteLine("9x8={0}", 9 * n8);
                    Console.WriteLine("9x9={0}", 9 * n9);
                    Console.WriteLine("9x10={0}", 9 * n10);
                    break;

                case 10:
                    Console.WriteLine("10x1={0}", 10 * n1);
                    Console.WriteLine("10x2={0}", 10 * n2);
                    Console.WriteLine("10x3={0}", 10 * n3);
                    Console.WriteLine("10x4={0}", 10 * n4);
                    Console.WriteLine("10x5={0}", 10 * n5);
                    Console.WriteLine("10x6={0}", 10 * n6);
                    Console.WriteLine("10x7={0}", 10 * n7);
                    Console.WriteLine("10x8={0}", 10 * n8);
                    Console.WriteLine("10x9={0}", 10 * n9);
                    Console.WriteLine("2x10={0}", 10 * n10);
                    break;

            }

            Console.ReadKey();
        }
    }
}
