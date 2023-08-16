using System;

namespace ex002;

class Ex02
{
    static void Main(string[] args)
    {
        string[] nome = new string[5];
        int cont = 0;

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Informe nome do animal: ");
            nome[i] = Console.ReadLine();
        }
        Console.WriteLine("Exibindo matriz: ");
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine(nome[i]);
            if (nome[i].StartsWith("C", StringComparison.OrdinalIgnoreCase))
            {
                cont++;
            }
        }
        Console.WriteLine("Numero de animais que comecam com a letra C: {0}", cont);
    }
}
