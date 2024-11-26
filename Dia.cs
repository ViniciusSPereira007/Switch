using System;

class Dia
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um número de 1 a 7: ");
        int numero = Convert.ToInt32(Console.ReadLine());


        if (numero < 8 )
        {
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Número inválido Por favor digite um número entre 1 e 7");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida Por favor digite um número");
        }
    }
}
