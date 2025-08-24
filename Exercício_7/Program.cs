class Program
{
    static void Main()
    {
        const int alunos = 20;

        double[] prova1 = new double[alunos];
        double[] prova2 = new double[alunos];
        double[] prova3 = new double[alunos];
        double[] pontuacao = new double[alunos];
        double soma1 = 0;
        double soma2 = 0;
        double soma3 = 0;

        for (int i = 0; i < alunos; i++)
        {
            Console.Write($"Digite a nota do aluno {i + 1} na primeira prova: ");
            prova1[i] = double.Parse(Console.ReadLine());

            soma1 = soma1 + prova1[i];
        }

        for (int i = 0; i < alunos; i++)
        {
            Console.Write($"Digite a nota do aluno {i + 1} na segunda prova: ");
            prova2[i] = double.Parse(Console.ReadLine());

            soma2 = soma2 + prova2[i];
        }

        for (int i = 0; i < alunos; i++)
        {
            Console.Write($"Digite a nota do aluno {i + 1} na terceira prova: ");
            prova3[i] = double.Parse(Console.ReadLine());

            soma3 = soma3 + prova3[i];
        }

        double media1 = soma1 / alunos;
        double media2 = soma2 / alunos;
        double media3 = soma3 / alunos;

        for (int i = 0; i < alunos; i++)
        {
            pontuacao[i] = prova1[i] + prova2[i] + prova3[i];
        }

        Console.Write($"\nA média de pontos dos alunos na prova 1 é: {media1}");
        Console.Write($"\nA média de pontos dos alunos na prova 2 é: {media2}");
        Console.Write($"\nA média de pontos dos alunos na prova 3 é: {media3}\n");

        for (int i = 0; i < alunos; i++)
        {
            Console.WriteLine($"\nA soma das notas do aluno {i + 1} nas três provas é: {pontuacao[i]}.");
        }
    }
}