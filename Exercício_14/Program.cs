class Program
{
    static void Main()
    {
        Console.Clear();

        const int tamanho = 3;

        string[] produto = new string[tamanho];

        int[] quantidade = new int[tamanho];

        double[] preco = new double[tamanho];

        List<string> ProdutoEstoque = new List<string>();

        List<int> QuantidadeEstoque = new List<int>();

        List<double> ValorEstoque = new List<double>();

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"\nDigite o nome do produto {i + 1}: ");
            produto[i] = Console.ReadLine();

            Console.Write($"Digite a quantidade do produto {produto[i]}: ");
            quantidade[i] = int.Parse(Console.ReadLine());

            Console.Write($"Digite o valor do produto {produto[i]}: ");
            preco[i] = double.Parse(Console.ReadLine());

            int jaexiste = ProdutoEstoque.IndexOf(produto[i]);

            if (jaexiste >= 0)
            {
                QuantidadeEstoque[jaexiste] += quantidade[i];
                ValorEstoque[jaexiste] += preco[i] * quantidade[i];
            }

            else
            {
                ProdutoEstoque.Add(produto[i]);
                QuantidadeEstoque.Add(quantidade[i]);
                ValorEstoque.Add(preco[i] * quantidade[i]);
            }
        }

        Console.Clear();

        Console.WriteLine("\n\nINVENTÁRIO DO ESTOQUE:\n");

        for (int i = 0; i < ProdutoEstoque.Count; i++)
        {
            Console.WriteLine($"Produto: {ProdutoEstoque[i]}");
            Console.WriteLine($"Quantidade: {QuantidadeEstoque[i]}");
            Console.WriteLine($"Valor total de {ProdutoEstoque[i]} em estoque: R${ValorEstoque[i]}\n");
        }
        
    }
}