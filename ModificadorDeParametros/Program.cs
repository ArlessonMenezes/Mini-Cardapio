using System;
using System.Globalization;

namespace ModificadorDeParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            Cardapio c = new Cardapio();

            int qte = 0;
            char escolha = ' ';
            double pc = 17.70, cs = 15.35, pi = 12.00, bs = 6.65;


            Console.WriteLine("Item\t\t\t       Preço");
            Console.WriteLine("Prato de camarão [C].....:{0,10:c}", pc);
            Console.WriteLine("Carne de Sol [S].........:{0,10:c}", cs);
            Console.WriteLine("Pizza [P]................:{0,10:c}", pi);
            Console.WriteLine("Banana Split [B].........:{0,10:c}", bs);
        cardapio:
            Console.WriteLine();
            Console.Write("Escolha seu pedido: ");
            escolha = char.Parse(Console.ReadLine());
            if (escolha == 'c' || escolha == 'C')
            {
                Console.WriteLine("Prato de camarão, Valor {0:c}", pc);
                Console.Write("Informe a quantidade: ");
                qte = int.Parse(Console.ReadLine());
                if (qte == 0)
                {
                    Console.WriteLine("Valor do pedido {0:c}", pc);
                }
                else
                {
                    c.ValorQte(qte);
                    Console.WriteLine("valor do pedido: {0:c}", pc * qte);
                }

            }
            else if (escolha == 's' || escolha == 'S')
            {
                Console.WriteLine("Carne de Sol, Valor {0:c}", cs);
                Console.Write("Informe a quantidade: ");
                qte = int.Parse(Console.ReadLine());
                if (qte == 0)
                    Console.WriteLine("Valor do pedido {0:c}", cs);
                else
                {
                    c.ValorQte(qte);
                    Console.WriteLine("valor do pedido: {0:c}", cs * qte);
                }
            }
            else if (escolha == 'p' || escolha == 'P')
            {
                Console.WriteLine("Pizza, Valor {0:c}", pi);
                Console.Write("Informe a quantidade: ");
                qte = int.Parse(Console.ReadLine());
                if (qte == 0)
                    Console.WriteLine("Valor do pedido {0:c}", pi);
                else
                {
                    c.ValorQte(qte);
                    Console.WriteLine("valor do pedido: {0:c}", pi * qte);
                }
            }
            else
            {
                if (escolha == 'b' || escolha == 'B')
                {
                    Console.WriteLine("Banana Split, Valor {0:c}", bs);
                    Console.Write("Informe a quantidade: ");
                    qte = int.Parse(Console.ReadLine());
                    if (qte == 0)
                        Console.WriteLine("Valor do pedido {0:c}", bs);
                    else
                    {
                        Console.WriteLine("valor do pedido: {0:c}", bs * qte);
                        c.ValorQte(qte);
                    }
                }
            }
        npedido:
            Console.WriteLine();
            Console.WriteLine("Deseja fazer um novo pedido? [s/n]");
            char npedido = char.Parse(Console.ReadLine());
            if (npedido == 's' || npedido == 'S')
                goto cardapio;
            else if (npedido == 'n' || npedido == 'N')
                Console.WriteLine("volte sempre!");
            else
            {
                Console.WriteLine("Opção inválida");
                goto npedido;
            }
        }
    }
}



    

