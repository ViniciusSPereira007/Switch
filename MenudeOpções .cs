using System;

class MenudeOpções
{
    public static void Main(string[] args)
    {
int opcao;
        do
        {

            
            Console.WriteLine("Menu de Opções:");
            Console.WriteLine("1 - Exibir \"Olá, Mundo!\"");
            Console.WriteLine("2 - Exibir \"Bem-vindo ao C#\"");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = Convert.ToInt16(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Olá, Mundo!");
                    break;
                case 2:
                    Console.WriteLine("Bem-vindo ao C#!");
                  
                    
                        break;
                case 3:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.WriteLine();
        } while (opcao == 3);
        }
        }





