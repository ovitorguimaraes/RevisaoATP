class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite o valor do termo [{i}, {j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        } // até aqui funciona, OK

        // estudar
        (int[] acima, int[] abaixo) = pegarelementos(matriz);

        Console.Write("\nElementos acima da diagonal principal: ");
        foreach (int valor in acima)
            Console.Write($"\n{valor}");

        Console.Write("\n\nElementos abaixo da diagonal principal:");
        foreach (int valor in abaixo)
            Console.Write($"\n{valor}");
    }

    static (int[], int[]) pegarelementos(int[,] matriz)
    {
        int tamanho = 3;
        int qtd = (tamanho * (tamanho - 1)) / 2;
        int[] acima = new int[qtd];
        int[] abaixo = new int[qtd];
        int k1 = 0, k2 = 0;

        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                if (j > i)
                {
                    acima[k1++] = matriz[i, j];
                }
                else if (j < i)
                {
                    abaixo[k2++] = matriz[i, j];
                }
            }
        }

        return (acima, abaixo);
    }
}
// estudar
