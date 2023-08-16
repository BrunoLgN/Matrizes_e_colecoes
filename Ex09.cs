namespace ex009;

class Ex09
{
    static void Main(string[] args)
    {
        string[] cores = new string[5];
        int cont = 0;

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Informe cor: ");
            cores[i] = Console.ReadLine();
        }

        foreach(string cor in cores)
        {
            if(cor == "vermelho" || cor == "amarelo" || cor == "verde")
            {
                cont++;
            }
        }
        Console.WriteLine("Numero de cores primarias: {0}", cont);
    }
}
