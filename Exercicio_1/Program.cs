using System;
namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora";
            Console.WriteLine("============================== CALCULADORA DE REAJUSTE ==============================");

            double salarioInicial, salarioReajustado, reajuste;
            string percentual;

            Console.WriteLine("Digite o seu salário: ");
            salarioInicial = double.Parse(Console.ReadLine());

            if(salarioInicial <= 280 ){
                reajuste = 0.2 * salarioInicial;
                percentual = "20%";
                salarioReajustado = salarioInicial + reajuste;

                Console.WriteLine("============================== SOBRE O SEU REAJUSTE ==============================");
                Console.WriteLine($"O salário antes do reajuste: {salarioInicial}");
                Console.WriteLine($"O percentual de aumento aplicado: {percentual}");
                Console.WriteLine($"O valor do aumento: {reajuste}");
                Console.WriteLine($"O novo salário, após o aumento: {salarioReajustado}");
            } else if (salarioInicial >= 280 && salarioInicial <= 700 ){
                reajuste = 0.15 * salarioInicial;
                percentual = "15%";
                salarioReajustado = salarioInicial + reajuste;

                Console.WriteLine("============================== SOBRE O SEU REAJUSTE ==============================");
                Console.WriteLine($"O salário antes do reajuste: {salarioInicial}");
                Console.WriteLine($"O percentual de aumento aplicado: {percentual}");
                Console.WriteLine($"O valor do aumento: {reajuste}");
                Console.WriteLine($"O novo salário, após o aumento: {salarioReajustado}");
            } else if (salarioInicial >= 700 && salarioInicial <= 1500 ) {
                reajuste = 0.1 * salarioInicial;
                percentual = "10%";
                salarioReajustado = salarioInicial + reajuste;

                Console.WriteLine("============================== SOBRE O SEU REAJUSTE ==============================");
                Console.WriteLine($"O salário antes do reajuste: {salarioInicial}");
                Console.WriteLine($"O percentual de aumento aplicado: {percentual}");
                Console.WriteLine($"O valor do aumento: {reajuste}");
                Console.WriteLine($"O novo salário, após o aumento: {salarioReajustado}");
            } else if (salarioInicial >= 1500) {
                reajuste = 0.05 * salarioInicial;
                percentual = "5%";
                salarioReajustado = salarioInicial + reajuste;

                Console.WriteLine("============================== SOBRE O SEU REAJUSTE ==============================");
                Console.WriteLine($"O salário antes do reajuste: {salarioInicial}");
                Console.WriteLine($"O percentual de aumento aplicado: {percentual}");
                Console.WriteLine($"O valor do aumento: {reajuste}");
                Console.WriteLine($"O novo salário, após o aumento: {salarioReajustado}");
                
            } else {
                Console.WriteLine("Salário não consta na lista de reajuste!");
            }

            Console.ReadKey();

        }
    }
}
