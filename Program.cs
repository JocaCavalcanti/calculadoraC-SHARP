using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo a calculadora pelo CMD!");

            int num1 = ObterNumero("Digite o primeiro número:");
            int num2 = ObterNumero("Digite o segundo número:");

            Console.WriteLine("Qual operação você deseja fazer?");
            Console.WriteLine("Caso seja Soma, aperte 'a'");
            Console.WriteLine("Para subtração, aperte 's'");
            Console.WriteLine("Para multiplicação, aperte 'm'");
            Console.WriteLine("Para divisão, aperte 'd'");

            string resposta = Console.ReadLine() ?? "";

            int resultado = CalcularOperacao(resposta, num1, num2);

            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Obrigado por usar o programa de calculadora!");

            Console.ReadKey();
        }

        static int ObterNumero(string mensagem)
        {
            while (true)
            {
                Console.WriteLine(mensagem);
                if (int.TryParse(Console.ReadLine(), out int numero))
                    return numero;
                else
                    Console.WriteLine("Insira um número válido.");
            }
        }

        static int CalcularOperacao(string operacao, int num1, int num2)
        {
            switch (operacao)
            {
                case "a":
                    return num1 + num2;
                case "s":
                    return num1 - num2;
                case "m":
                    return num1 * num2;
                case "d":
                    if (num2 != 0)
                        return num1 / num2;
                    else
                    {
                        Console.WriteLine("Não é possível dividir por zero.");
                        throw new DivideByZeroException("Divisão por zero.");
                    }
                default:
                    Console.WriteLine("Operação inválida. selecione uma operação válida.");
                    throw new InvalidOperationException("Operação inválida.");
            }
        }
    }
}
