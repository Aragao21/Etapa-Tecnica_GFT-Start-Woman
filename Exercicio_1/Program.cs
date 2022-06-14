using System;
 
namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora";
            Console.WriteLine("============================== CALCULADORA ==============================");

            double valor1 = 0, valor2 = 0, resultado, numero;
            string operador, valorDigitado;
            bool isNumeroInteiro;

            Console.WriteLine("Digite 0 1º valor: ");
            valorDigitado = Console.ReadLine();

            //verifica se é um número
            isNumeroInteiro = double.TryParse(valorDigitado, out numero);

            //faz a validação
            if (isNumeroInteiro)
            {
                valor1 = Math.Round(double.Parse(valorDigitado), 4);
            }
            else {
                Console.WriteLine("Digite um número válido!");
            }

            Console.WriteLine("Digite a operação(' / | + | * | - | %(MOD)'): ");
            operador = Console.ReadLine();

            Console.WriteLine("Digite o 2º valor: ");
            valorDigitado = Console.ReadLine();

            //verifica se é um número
            isNumeroInteiro = double.TryParse(valorDigitado, out numero);

            //faz a validação
            if (isNumeroInteiro)
            {
                valor2 = Math.Round(double.Parse(valorDigitado), 4);
            }
            else {
                Console.WriteLine("Digite um número válido!");
            }

            switch (operador)
            {
                case "+":
                    resultado = Math.Round(valor1 + valor2, 4);
                    Console.WriteLine($"{valor1} {'+'} {valor2} = {resultado}");
                    break;
                case "-":
                    resultado = Math.Round(valor1 - valor2, 4);
                    Console.WriteLine($"{valor1} {'-'} {valor2} = {resultado}");
                    break;
                case "*":
                    resultado = Math.Round(valor1 * valor2, 4);
                    Console.WriteLine($"{valor1} {'*'} {valor2} = {resultado}");
                    break;
                case "/":
                    resultado = Math.Round(valor1 / valor2, 4);
                    Console.WriteLine($"{valor1} {'/'} {valor2} = {resultado}");
                    break;
                case "%":
                    resultado = Math.Round(valor1 % valor2, 4);
                    Console.WriteLine($"{valor1} {'%'} {valor2} = {resultado}");
                    break;
                default:
                    Console.WriteLine("Digite uma operação válida");
                    break;
            }
            Console.ReadKey();

        }
    }
}
