class Program
{
    static void Main()
    {

        List<double> canal = new List<double>();
        List<double> pessoas = new List<double>();

        Console.Clear();

        Console.Write("PESQUISA DE AUDIÊNCIA");

        while (true)
        {
            Console.WriteLine("\nVocê deseja participar? (SIM / NAO)");
            string participar = Console.ReadLine().ToUpper();

            if (participar == "NAO")
            {
                Console.WriteLine("\nObrigado! Encerrando...");
                return;
            }

            else if (participar == "SIM")
            {
                break;
            }

            else
            {
                Console.WriteLine("\nResposta invalida, responda SIM ou NAO.");
            }

        }

        while (true)
        {
            Console.Write("\nDIGITE O CANAL SINTONIZADO EM SUA TV:\n(CANAL 0 PARA SAIR)\n");
            double numerocanal = double.Parse(Console.ReadLine());

            if (numerocanal == 0)
            {
                break;
            }

            canal.Add(numerocanal);

            Console.WriteLine("\nQUANTAS PESSOAS ESTÃO ASSISTINDO O CANAL SINTONIZADO?");
            double quantidadepessoas = double.Parse(Console.ReadLine());
            pessoas.Add(quantidadepessoas);

        }

        double[] audiencia = new double[canal.Count];
        double totalpessoas = 0;

        for (int i = 0; i < pessoas.Count; i++)
        {
            totalpessoas += pessoas[i];
        }

        for (int i = 0; i < canal.Count; i++)
        {
            audiencia[i] = pessoas[i] / totalpessoas * 100;
        }

        for (int i = 0; i < canal.Count; i++)
        {
            Console.WriteLine($"A audiência do canal {canal[i]} é: {audiencia[i]:F2}%.\n");
        }
        
    }      
    
}
