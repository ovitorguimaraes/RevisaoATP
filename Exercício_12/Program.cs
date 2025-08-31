class Program
{
    static void Main()
    {
        int[,] matriz = new int[2, 5];
        int[,] matrizfinal = new int[2, 5];

        int k;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Digite o valor da posição [{i}, {j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Digite o valor da escalar: ");
        k = int.Parse(Console.ReadLine());

        matrizfinal = OperacaoMatriz(matriz, k);

        Console.Write("O valor dos termos da matriz somados ao número escalar é: \n");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{matrizfinal[i, j]}\n");
            }
        }
    }


    static int[,] OperacaoMatriz(int[,] matriz, int k)
    {
        int[,] calculo = new int[2, 5];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                calculo[i, j] = matriz[i,j] + k;
            }
        }

        return calculo;
    }
}