namespace ex005;

class Ex05
{
    static void Main(string[] args)
    {
        int[] matriz = new int[5];
        int soma = 0;

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Informe um inteiro: ");
            matriz[i] = int.Parse(Console.ReadLine());
        }
        for(int i = 0; i < 5; i++)
        {
            soma += matriz[i];
        }
        Console.WriteLine("Soma de todos os numeros da matriz: {0}", soma);
    }
}
