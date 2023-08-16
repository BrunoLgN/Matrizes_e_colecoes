using System;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] numeros = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Informe o valor: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int[] novonumeros = Array.FindAll(numeros, numero => numero % 2 == 0);

            Console.WriteLine("\nMatriz após a remoção dos números ímpares:");

            foreach (int numero in novonumeros)
            {
                Console.WriteLine(numero);
            }

            

        }
    }
}
