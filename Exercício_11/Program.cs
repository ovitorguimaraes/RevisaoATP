class Program
{
    static void Main()
    {

        while (true)
        {
            Console.Write("CALCULADORA DE ARÉA\n\nMENU\n1. Quadrado\n2. Retângulo\n3. Trapézio\n4. Círculo\n5. Sair\nEscolha a opção desejada: ");
            int opcao = int.Parse(Console.ReadLine());

            string continuar;
            
            switch (opcao)
            {

                case 1:
                    Console.Write("\n\nQual a medida dos lados do quadrado?\n");
                    double lados = double.Parse(Console.ReadLine());

                    double areaquadrado = CalcularAreaDoQuadrado(lados);

                    Console.Write($"A aréa do quadrado é: {areaquadrado}m2.");

                    Console.Write("\n\nDeseja calcular outra aréa? (SIM / NAO) ");
                    continuar = Console.ReadLine().ToUpper();

                    if (continuar == "NAO")
                    {
                        Console.Write("Saindo...");
                        return;
                    }

                    else
                    {
                        break;
                    }

                case 2:
                    Console.Write("\n\nQual a altura do retângulo?\n");
                    double alturaretangulo = double.Parse(Console.ReadLine());

                    Console.Write("\nQual a largura do retângulo?\n");
                    double larguraretangulo = double.Parse(Console.ReadLine());

                    double arearetangulo = CalcularAreaDoRetangulo(alturaretangulo, larguraretangulo);

                    Console.Write($"A aréa do retângulo é: {arearetangulo}m2.");

                    Console.Write("\n\nDeseja calcular outra aréa? (SIM / NAO) ");
                    continuar = Console.ReadLine().ToUpper();

                    if (continuar == "NAO")
                    {
                        Console.Write("Saindo...");
                        return;
                    }

                    else
                    {
                        break;
                    }

                case 3:
                    Console.Write("\n\nQual a altura do trapézio?\n");
                    double alturatrapezio = double.Parse(Console.ReadLine());

                    Console.Write("\nQual a medida do lado menor?\n");
                    double ladomenor = double.Parse(Console.ReadLine());

                    Console.Write("\nQual a medida do lado maior?\n");
                    double ladomaior = double.Parse(Console.ReadLine());

                    double areatrapezio = CalcularAreaDoTrapezio(alturatrapezio, ladomaior, ladomenor);

                    Console.Write($"A aréa do trapézio é: {areatrapezio}m2.");

                    Console.Write("\n\nDeseja calcular outra aréa? (SIM / NAO) ");
                    continuar = Console.ReadLine().ToUpper();

                    if (continuar == "NAO")
                    {
                        Console.Write("Saindo...");
                        return;
                    }

                    else
                    {
                        break;
                    }

                case 4:
                    Console.Write("\n\nQual a medida do raio do círculo?\n");
                    double raio = double.Parse(Console.ReadLine());

                    double areacirculo = CalcularAreaDoCirculo(raio);

                    Console.Write($"A aréa do círculo é: {areacirculo}m2.");

                    Console.Write("\n\nDeseja calcular outra aréa? (SIM / NAO) ");
                    continuar = Console.ReadLine().ToUpper();

                    if (continuar == "NAO")
                    {
                        Console.Write("Saindo...");
                        return;
                    }

                    else
                    {
                        break;
                    }

                case 5:
                    return;

                default:
                    Console.Write("Opção inválida, digite novamente.");
                    break;
            }
        }
    }

    static double CalcularAreaDoQuadrado(double lado)
    {
        double area = lado * lado;
        return area;
    }

    static double CalcularAreaDoRetangulo(double alturaretangulo, double larguraretangulo)
    {
        double area = alturaretangulo * larguraretangulo;
        return area;
    }

    static double CalcularAreaDoTrapezio(double alturatrapezio, double ladomaior, double ladomenor)
    {
        double area = (ladomaior + ladomenor) * alturatrapezio / 2;
        return area;
    }

    static double CalcularAreaDoCirculo(double raio)
    {
        double area = (raio * raio) * Math.PI;
        return area;
    }

}