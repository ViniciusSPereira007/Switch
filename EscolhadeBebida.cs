using System;


namespace exercicio01
{
    internal class EscolhadeBebida
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma bebida (entre 1 a 4)");
            Console.WriteLine("Opção 1: Cafê");
            Console.WriteLine("Opção 2: Chá");
            Console.WriteLine("Opção 3: Suco");
            Console.WriteLine("Opção 4: Refrigerante");
            int opcao = Convert.ToInt16(Console.ReadLine());

            switch (opcao) 
            { 
                case 1:
                    Console.WriteLine("Cafê");
                    Console.WriteLine("Caputino");
                    Console.WriteLine("Cafê com leite");
                    break;
                    case 2: 
                    Console.WriteLine("Chá");
                    break;
                    case 3:
                    Console.WriteLine("Suco");
                    break;
                    case 4:
                    Console.WriteLine("Refrigerante");
                    break;
            }

        }
    }
}
