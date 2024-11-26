using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class CategoriadeFilme
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção e descubra a faixa etária permitida");
            Console.WriteLine("1- G");
            Console.WriteLine("2- PG");
            Console.WriteLine("3- PG-13");
            Console.WriteLine("4- R");
            int faixaetaria = Convert.ToInt16(Console.ReadLine());
            switch (faixaetaria)
            {
                case 1:
                    Console.WriteLine("Faixa Etária LIVRE");
                    break;
                case 2:
                    Console.WriteLine("Faixa Etária para MAIOR DE 10 ANOS");
                    break;
                case 3:
                    Console.WriteLine("Faixa Etária para MAIOR DE 13 ANOS");
                    break;
                case 4:
                    Console.WriteLine("Faixa Etária para MAIOR DE 18 ANOS");
                    break;
            }


        }
    }
}