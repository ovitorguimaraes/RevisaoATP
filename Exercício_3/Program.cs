class Program
{
    static void Main()
    {
        const int total = 15;
        double[] altura = new double[total];
        char[] sexo = new char[total];


        for (int i = 0; i < total; i++)
        {
            Console.Write($"\nUSUÁRIO {i + 1}\nDigite o seu sexo (M ou F): ");
            sexo[i] = char.Parse(Console.ReadLine());

            Console.Write("Digite a altura em metros (Ex: 1.8): ");
            altura[i] = double.Parse(Console.ReadLine());
        }

        double maioraltura = altura[0], menoraltura = altura[0];

        for (int i = 1; i < total; i++)
        {
            if (altura[i] > maioraltura)
            {
                maioraltura = altura[i];
            }

            else if (altura[i] < menoraltura)
            {
                menoraltura = altura[i];
            }
        }

        double somaAF = 0;
        double contadorF = 0;
        double contadorM = 0;

        for (int i = 0; i < total; i++)
        {
            if (sexo[i] == 'F')
            {
                contadorF++;
                somaAF = somaAF + altura[i];
            }

            else if (sexo[i] == 'M')
            {
                contadorM++;
            }
        }

        double mediaAF = somaAF / contadorF;

        Console.Write($"\nA maior altura do grupo é: {maioraltura}m.\nA menor altura do grupo é: {menoraltura}m.\nA média de altura entre as mulheres é: {mediaAF}.\nE {contadorM} pessoas são do sexo masculino.");
    }
}