using System;

namespace exercicio01
{
    internal class ConversordeTemperatura
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite 'F' para converter de Fahrenheit para Celsius ou 'C' para converter de Celsius para Fahrenheit:");
            char operador = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Para adicionar uma nova linha após a tecla ser pressionada. 

            switch (char.ToUpper(operador))
            {
                case 'F': // Fahrenheit para Celsius
                    Console.Write("\nDigite a temperatura em Fahrenheit: ");
                    float fahrenheit = float.Parse(Console.ReadLine());
                    float celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"A temperatura em Celsius é: {celsius:F2}°C");
                    break;

                case 'C': // Celsius para Fahrenheit
                    Console.Write("\nDigite a temperatura em Celsius: ");
                    celsius = float.Parse(Console.ReadLine());
                    fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit:F2}°F");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha 'F' ou 'C'.");
                    break;
            }
        }
    }
}
