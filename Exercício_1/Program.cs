class Program
{
    static void Main()
    {
        Console.Write("Digite o número desejado: ");
        int n = int.Parse(Console.ReadLine());

        double sa = 0;

        for (double i = 0; i < n; i++)
        {
            sa = sa + i / (1 + i);
        }

        double sb = 100;

        for (double i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                sb = sb + i;
            }

            else if (i % 2 != 0)
            {
                sb = sb - i;
            }

            else if (i == n)
            {
                sb = sb + i;
            }
        }

        Console.WriteLine($"O resultado da série A é: {sa}.");

        Console.WriteLine($"O resultado da série B é: {sb}.");

    }
}