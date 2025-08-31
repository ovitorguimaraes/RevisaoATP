class Program
{
    static void Main()
    {
        Console.Clear();

        const int tamanho = 50;
        string[] nome = new string[tamanho];
        double[] nota = new double[tamanho];
        double somanota = 0;

        Console.WriteLine("SISTEMA DE NOTAS");

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"\nAluno {i + 1}, digite seu nome: ");
            nome[i] = Console.ReadLine();

            Console.Write($"\n{nome[i]}, digite sua nota: ");
            nota[i] = double.Parse(Console.ReadLine());

            somanota += nota[i];
        }

        double media = CalcularMedia(somanota, tamanho);
        double[] maioremenornota = MaiorMenorNota(nota, tamanho);

        Console.Clear();

        Console.Write("\nAQUI ESTÃO OS RESULTADOS: ");
        Console.Write($"\nA menor nota é {maioremenornota[0]}.\n");

        Console.Write($"A média dos alunos é {media}.\n");

        Console.Write($"A maior nota é {maioremenornota[1]}.\n");
    }


    static double CalcularMedia(double somanota, int tamanho)
    {
        double media = somanota / tamanho;
        return media;
    }

    static double[] MaiorMenorNota(double[] nota, int tamanho)
    {
        double menornota = nota[0];
        double maiornota = nota[0];

        for (int i = 1; i < tamanho; i++)
        {
            if (nota[i] < nota[i - 1])
            {
                menornota = nota[i];
            }

            else if (nota[i] > nota[i - 1])
            {
                maiornota = nota[i];
            }
        }

        return new double[] { menornota, maiornota };
    }
  
}