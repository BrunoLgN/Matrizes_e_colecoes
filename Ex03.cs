using System;
using System.Collections;
namespace ex003;

class Ex03
{
    static void Main(string[] args)
    {
        
        string[] frutas = new string[5];

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Informe fruta: ");
            frutas[i] = Console.ReadLine();
        }
        Array.Sort(frutas);
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("{0}", frutas[i]);
        }
    }
}
