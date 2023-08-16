namespace ex008;

class Ex08
{
    static void Main(string[] args)
    {
        string[] paises = new string[5];
        int cont = 0;
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Informe nome do pais: ");
            paises[i] = Console.ReadLine();
        }

        foreach(string pais in paises)
        {
            if(pais.Length > 10)
            {
                cont++;
            }
        }
        Console.WriteLine("Paises com mais de 10 letras: {0}", cont);
    }
}
