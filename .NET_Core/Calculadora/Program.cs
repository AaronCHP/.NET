using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, potencia;string operador, opcao, sair;

            Console.WriteLine("Calculadora Simples\n");

            // Instruções
            Console.WriteLine("Intruções\n");
            Console.WriteLine("--- Para que a calculadora funcione sem problemas evite digitar 2 números na mesma linha" + " (Exemplo: 12 1)");
            Console.WriteLine("--- Para sair da aplicação:\n" + "\t1) Selecione 'n' em 'Deseja continuar a conta com esse valor?'"
                + "\n\t2) Selecione 's' em 'Deseja sair da aplicação?'");
            Console.WriteLine("Utilize ',' para utlizar números decimais");
            Console.WriteLine("--- Escolha um destes operadores para realizar os cálculos:\n\n\t '+' soma\t '-' subtração\t " +
                    "'*' multiplicação\t '/' divisão inteira\t '%' resto\t '^' Potência\n");

            Console.WriteLine("Inicializando...\n");

            // Início da calculadora
            Console.Write("Digite um valor: ");
            num1 = double.Parse(Console.ReadLine());

            // Loop para continuar os cálculos
            while(num1 >= 0)
            {
                Console.Write("Operação: ");
                operador = Console.ReadLine();
                Console.Write("Digite outro valor: ");
                num2 = double.Parse(Console.ReadLine());

                // Operações
                if (operador == "+")
                {
                    num1 = num1 + num2;
                    Console.WriteLine("Resultado = " + num1);
                } else if (operador == "-")
                {
                    num1 = num1 - num2;
                    Console.WriteLine("Resultado = " + num1);
                } else if (operador == "*")
                {
                    num1 = num1 * num2;
                    Console.WriteLine("Resultado = " + num1);
                } else if (operador == "/")
                {
                    num1 = num1 / num2;
                    Console.WriteLine("Resultado = " + num1);
                } else if (operador == "%")
                {
                    num1 = num1 % num2;
                    Console.WriteLine(num1);
                } else if (operador == "^")
                {
                    potencia = num1;
                    if (num2 > 0) {
                        for(int i = 1; i < num2; i++)
                        {
                            num1 = num1 * potencia;
                        }
                        Console.WriteLine("Resultado = " + num1);
                    } else if (num2 == 0)
                    {
                        num1 = 1;
                        Console.WriteLine("Resultado = " + num1);
                    } else if (num2 < 0)
                    {
                        num1 = num1 / num2;
                        Console.WriteLine("Resultado = " + num1);
                    }
                }

                // Opção de resetar a calculadora ou continuar com o mesmo valor
                Console.WriteLine("\nDeseja continuar a conta com esse valor (" + num1 + ") ? Digite 's' para sim e 'n' para não");
                Console.Write("Continuar? ");
                opcao = Console.ReadLine();
                if (opcao == "s")
                {
                    Console.WriteLine();
                    continue;
                } else if (opcao == "n")
                {
                    Console.WriteLine("\nDeseja sair da aplicação? Digite 's' para sim e 'n' para não");
                    Console.Write("Sair? ");
                    sair = Console.ReadLine();
                    if (sair == "s")
                    {
                        break;
                    } else if (sair == "n")
                    {
                        Console.WriteLine();
                        num1 = 0;
                    }
                }
            }
            Console.WriteLine("\nPrograma finalizado");
        }
    }
}
