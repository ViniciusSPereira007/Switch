using System;

namespace ConsoleApp2
{
    internal class CalculadoradeImpostos
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do seu salário");
            float salario = Convert.ToSingle(Console.ReadLine());

           
            int faixa;

            if (salario >= 3001)
            {
                faixa = 3; 
            }
            else if (salario >= 1501)
            {
                faixa = 2; 
            }
            else
            {
                faixa = 1;
            }

          
            switch (faixa)
            {
                case 3:
                    Console.WriteLine("Você precisa pagar " + (salario * 0.15) + " de impostos.");
                    break;
                case 2:
                    Console.WriteLine("Você precisa pagar " + (salario * 0.1) + " de impostos.");
                    break;
                case 1:
                    Console.WriteLine("Você precisa pagar " + (salario * 0.05) + " de impostos.");
                    break;
                default:
                    Console.WriteLine("Erro.");
                    break;
            }
        }
    }
}