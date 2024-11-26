using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
    internal class Fahrenheitparacelsius
    {
        public static void Main (string[] args)
        {
            Console.Write("Digite a temperatura em Fahrenheit: ");
            float fahrenheit = Convert.ToSingle(Console.ReadLine());
            float celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("A sua temperatura de Fahrenheit " + fahrenheit + " para Celsius " + celsius);
        }
    }
}
