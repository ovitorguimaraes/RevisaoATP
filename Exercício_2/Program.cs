class Program
{
    static void Main()
    {
        Console.Write("Digite o número desejado: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 2)
        {
            Console.WriteLine("Digite um número maior que 2.");
            return;
        }

            int fibonacci1 = 1, fibonacci2 = 1, fibonacci3 = 0;
            Console.Write($"Aqui estão os números da Série de Fibonacci até {n}: {fibonacci1}, {fibonacci2}, ");

            for (int i = 3; i <= n; i++)
            {
                fibonacci3 = fibonacci1 + fibonacci2;
                Console.Write($"{fibonacci3}, ");

                fibonacci1 = fibonacci2;
                fibonacci2 = fibonacci3;
            }

    }
}