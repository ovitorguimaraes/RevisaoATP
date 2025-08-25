class Program
{
    static void Main()
    {
        Console.Write("Digite um número de quatro algarismos, vamos verificar se ele é palíndromo: ");
        int num = int.Parse(Console.ReadLine());

        if (palindromo(num))
        {
            Console.Write($"O número {num} é um palindromo.");
        }

        else
        {
            Console.Write($"O número {num} não é um palindromo.");
        }
    }

    static bool palindromo(int num)
    {
        if (num < 1000 || num > 9999)
        {
            Console.Write("O numéro é invalido");
            return false;
        }

        int n1 = num / 1000;
        int n2 = (num / 100) % 10;
        int n3 = (num / 10) % 10;
        int n4 = num % 10;

        return (n1 == n4 && n2 == n4);
    }
        
}