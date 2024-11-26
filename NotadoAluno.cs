using exercicio01;
using System;
using System.Collections.Generic;
using System;

class NotadoAluno
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite sua nota de (0 ate 10)");
        int nota = Convert.ToInt16(Console.ReadLine());

        switch (nota)
        {
            case <= 2:
                Console.WriteLine("sua nota foi um F melhorar");
                break;
            case >= 3 and <= 4:
                Console.WriteLine("Sua nota foi um E melhoar");
                break;
            case >= 5 and <= 6:
                Console.WriteLine("Sua nota foi um C  bom");
                break;
            case >= 7 and <= 8:
                Console.WriteLine("Sua nota foi um B muito bom");
                break;
            case >= 9 and 10:
                Console.WriteLine("Sua nota foi um A otimo");
                break;
        }
    }
}