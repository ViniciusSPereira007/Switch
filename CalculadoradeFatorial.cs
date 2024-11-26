using System;

namespace Exercicios_Switch_Case
{
    internal class Exercicio10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro para calcular o fatorial:");
            int numero;

           
            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Por favor, insira um número inteiro válido.");
                return;
            }

            switch (numero)
            {
                case < 0:
                    Console.WriteLine("Não é possível calcular o fatorial de um número negativo.");
                    break;

                case 0:
                    Console.WriteLine("O fatorial de 0 é 1.");
                    break;

                default:
                    int fatorial = 1;
                    for (int i = numero; i > 0; i--)
                    {
                        fatorial *= i;
                    }
                    Console.WriteLine($"O fatorial de {numero} é {fatorial}.");
                    break;
            }
        }
    }
}
