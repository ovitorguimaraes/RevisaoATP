class Program
{
    static void Main()
    {
        const int vetor = 10;

        int[] R = new int[vetor];
        int[] S = new int[vetor];
        int[] V = new int[vetor];

        for (int i = 0; i < vetor; i++)
        {
            bool repeticao;

            do
            {
                repeticao = false;

                Console.Write($"\nDigite o {i + 1}º termo de R: ");
                R[i] = int.Parse(Console.ReadLine());

                for (int j = 0; j < i; j++)
                {
                    if (R[i] == R[j])
                    {
                        Console.WriteLine("Digite um número que ainda não foi utilizado.");
                        repeticao = true;
                    }
                }

            }
            while (repeticao);

            do
            {
                repeticao = false;

                Console.Write($"Digite o {i + 1}º termo de S: ");
                S[i] = int.Parse(Console.ReadLine());

                for (int j = 0; j < i; j++)
                {
                    if (S[j] == S[i])
                    {
                        Console.WriteLine("Digite um número que ainda não foi utilizado.\n");
                        repeticao = true;
                    }
                }
            }
            while (repeticao);
            
        }
    
        for (int i = 0; i < vetor; i++)
        {
            V[i] = S[i] + R[i];
        }

        Console.Write("\nA soma dos termos dos vetores R e S é: ");
        for (int i = 0; i < vetor; i++)
        {
            Console.Write($"\n{i + 1}º resultado: {V[i]}");  
        }
    }
}