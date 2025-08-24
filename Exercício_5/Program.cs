class Program
{
    static void Main()
    {
        int[,] matriz1 = new int[3, 3];
        int[,] matriz2 = new int[3, 3];
        int[,] soma = new int[3, 3];
        int[,] diferenca = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite o valor de [{i},{j}] para a 1º matriz: ");
                matriz1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite o valor de [{i},{j}] para a 2º matriz: ");
                matriz2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                soma[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        Console.Write($"\nAqui está a soma dos termos matrizes:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"\nPosição [{i},{j}] da matriz 1 + [{i},{j}] da matriz 2: {soma[i, j]}");
            }

        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                diferenca[i, j] = matriz1[i, j] - matriz2[i, j];
            }
        }

        Console.Write("\nAqui está a diferença dois termos das matrizes: ");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"\nPosição [{i}, {j}] da matriz 1 - [{i}, {j}] da matriz 2: {diferenca[i, j]}");
            }
        }
        
    }
}
        

        