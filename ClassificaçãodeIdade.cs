using System;

class ClassificaçãodeIdade
{
    public static void Main(string[] args)
    {
        Console.Write("Digite a sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        switch (idade)
        {
            case <= 12:
                Console.WriteLine("Criança (0-12 anos)");
                break;
            case >= 13 and <= 17:
                Console.WriteLine("Adolescente (13-17 anos)");
                break;
            case >= 18 and <= 59:
                Console.WriteLine("Adulto (18-59 anos)");
                break;
            default:
                Console.WriteLine("Idoso (60 anos ou mais)");
                break;
        }
    }
}
