using System;
namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================== MENU DE OPÇÕES ==============================");

            int opcaoSelecionada;
            double nota1, nota2, mediaAritmetica, ponderada1, ponderada2, ponderada3, peso1, peso2, peso3, mediaPonderada;

            Console.WriteLine("SELECIONE UMA DAS OPÇÕES ABAIXO:");
            Console.WriteLine("1 - Média aritmética");
            Console.WriteLine("2 - Média ponderada");
            Console.WriteLine("3 - Sair");
            opcaoSelecionada = int.Parse(Console.ReadLine());

            switch(opcaoSelecionada) {
                case 1:
                    Console.WriteLine("============================== MÉDIA ARITMÉTICA ==============================");
                    Console.WriteLine("Digite a primeira nota: ");
                    nota1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a segunda nota: ");
                    nota2 = int.Parse(Console.ReadLine());
                    mediaAritmetica = (nota1+nota2)/2;
                    break;
                case 2:
                    Console.WriteLine("============================== MÉDIA ARITMÉTICA ==============================");
                    Console.WriteLine("Digite a primeira nota: ");
                    ponderada1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o peso da primeira nota: ");
                    peso1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a segunda nota: ");
                    ponderada2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o peso da primeira nota: ");
                    peso2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a segunda nota: ");
                    ponderada3 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o peso da primeira nota: ");
                    peso3 = int.Parse(Console.ReadLine());

                    mediaPonderada = (ponderada1*peso1 + ponderada2*peso2 + ponderada3*peso3)/(peso1+peso2+peso3);
                    break;
                case 3:
                    break;
                default:
                    break;
            }
            

            

            Console.ReadKey();

        }
    }
}

