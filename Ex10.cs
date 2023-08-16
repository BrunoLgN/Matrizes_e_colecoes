using System;

namespace ex010;

class Ex10
{
    static void Main(string[] args)
    {
        string[] frutas = new string[5];

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Informe fruta: ");
            frutas[i] = Console.ReadLine();
        }

        Console.WriteLine("Primeira fruta: {0}", frutas[0]);
        Console.WriteLine("Ultima fruta: {0}", frutas[4]);
    }
}
