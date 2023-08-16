namespace ex004;

class Ex04
{
    static void Main(string[] args)
    {
        string[] pais = new string[5];

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Informe nome do país: ");
            pais[i] = Console.ReadLine();
        }
        Console.WriteLine("Países ordenados na ordem alfabetica inversa: ");
        Array.Sort(pais, (a, b) => b.CompareTo(a));

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("{0}", pais[i]);
        }
    }
}
