using System;
using System.Collections.Generic;

namespace ex006;

class Ex06
{
    static void Main(string[] args)
    {
        List<string> cidades = new List<string>();
        for(int i = 0; i < 5; i++)
        {
            Console.Write("Informe cidade: ");
            string cidade = Console.ReadLine();
            cidades.Add(cidade);
        }

        cidades.RemoveAll(cidade => cidade.StartsWith("S", StringComparison.OrdinalIgnoreCase));

        foreach(string cidade in cidades)
        {
            Console.WriteLine(cidade);
        }
    }
}
