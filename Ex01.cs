using System;

namespace ex001;

class Ex01
{
    static void Main(string[] args)
    {
        int[] inteiros = new int[5];
        int cont = 0;

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Informe inteiro: ");
            inteiros[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Inteiros informados: ");
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("{0}", inteiros[i]);
            if((inteiros[i] % 2) == 0)
            {
                cont++;
            }
        }
        Console.WriteLine("{0} numeros pares.", cont);
    }
}
