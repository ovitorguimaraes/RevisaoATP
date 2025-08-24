class Program
{
    static void Main()
    {
        int[] vetA = new int[10];
        int[] vetB = new int[10];
        int[] soma = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"\nDigite o {i + 1}º número: ");
            vetA[i] = int.Parse(Console.ReadLine());

            Console.Write($"Digite um número a ser somado ao anterior: ");
            vetB[i] = int.Parse(Console.ReadLine());

            soma[i] = vetA[i] + vetB[i];
        }

        Console.Write($"\nAqui estão as somas dos números informados: ");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"\n{i + 1}ª operação: {soma[i]}");
        }
        
    }
}