using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA4_EX15_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Fazer um programa com menu que mostre os produtos disponíveis para venda e os preços de cada item em uma lanchonete. Exemplo: Hambúrguer, Fritas, Refrigerante e Milk-Shake. O usuário poderá escolher quantos itens quiser de cada opção. Deverá existir uma opção para finalizar a compra onde o usuário fará o pagamento. O programa deve calcular o troco, agradecer a compra e voltar para o menu inicial. Criar também um menu para sair do programa. \n===========================================================================================\n");
            //-----------------------------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkGray;

            char escolha_usuario = '0';
            int qt_ham = 0, qt_fritas = 0, qt_milkshake = 0, qt_refrigerante = 0;
            double conta = 0;
        inicio_pedido:          
            Console.Write("Bem vindo à Lanchonete CarlosDogão!\n\nEscolha seu pedido:\n[1] |R$7,50| Hambúrger\n[2] |R$3,00| Fritas\n[3] |R$2,00| Refrigerante\n[4] |R$6,00| Milkshake\n\n[F] Finalizar compra \n");
            Console.Write("Sua escolha:");
            for (;;)
            {
            inicio:
                try
                {
                    escolha_usuario = char.Parse(Console.ReadLine());
                }
                catch
                {
                    goto inicio;

                }
                if (escolha_usuario == '1')
                {
                    Console.WriteLine("REGISTRADO - 1x Hambuguer");
                    conta = conta + 7.5;
                    qt_ham = qt_ham + 1;

                }
                else if (escolha_usuario == '2')
                {
                    Console.WriteLine("REGISTRADO - 1x Fritas");
                    conta = conta + 3;
                    qt_fritas = qt_fritas + 1;
                }
                else if (escolha_usuario == '3')
                {
                    Console.WriteLine("REGISTRADO - 1x Refrigerante");
                    conta = conta + 2;
                    qt_refrigerante = qt_refrigerante + 1;
                }
                else if (escolha_usuario == '4')
                {
                    Console.WriteLine("REGISTRADO - 1x Milkshake");
                    conta = conta + 6;
                    qt_milkshake = qt_milkshake + 1;
                }
                else if (escolha_usuario == 'F' || escolha_usuario == 'f')
                {
                    Console.WriteLine("Compra finalizada.");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada inválida.");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
            }
        conta:
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Foi pedido:\n[{0}x] Hambúrger(s)\n[{1}x] Fritas\n[{2}x] Refrigerante(s)\n[{3}x] Milkshake(s)\n", qt_ham, qt_fritas, qt_refrigerante, qt_milkshake);
            Console.WriteLine("Valor total do pedido: R${0}", conta);
            Console.Write("Entre com o dinheiro que será entregue: ");
            double qt_dinheiro = 0;
            try
            {
                qt_dinheiro = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Entrada de caractere inválida. Pressione qualquer tecla para voltar ao início.");
                Console.ReadKey();
                Console.Clear();
                goto conta;
            }
            if (qt_dinheiro < conta)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Valor insuficiente para pagar a conta. Pressione qualquer tecla...");
                Console.ReadKey();
                Console.Clear();
                goto conta;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Troco: R${0}", qt_dinheiro - conta);
                Console.WriteLine("Obrigado pelo seu pedido!");
                Console.WriteLine("\nDeseja realizar outro pedido? [S/N]");
            quest:
                char escolha_novo_pedido;
                try
                {
                    escolha_novo_pedido = char.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Entrada de dados inválida. Responda a pergunta novamente: ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    goto quest;
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                if (escolha_novo_pedido == 'S' || escolha_novo_pedido == 's')
                {
                    goto inicio_pedido;
                }

            }
                Console.ReadKey();
        }
    }
}
