using Problema2;
using System.Globalization;

Produto produto = new Produto();

Console.WriteLine("Entre com os dados do produto:");
Console.Write("Nome: ");
produto.Nome = Console.ReadLine().ToUpper();
Console.Write("Preço: ");
produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
produto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write($"Dados do produto: {produto.Nome}, {produto.Preco.ToString("F2")}, {produto.Quantidade} unidades, Total: $ ");
Console.WriteLine(produto.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine();

Console.Write("Digite o numero de produtos a ser adicionado do estoque: ");
produto.AdicionarProdutos(int.Parse(Console.ReadLine()));

Console.WriteLine();

Console.Write($"Dados atualizados: {produto.Nome}, {produto.Preco.ToString("F2")}, {produto.Quantidade} unidades, Total: $ ");
Console.WriteLine(produto.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine();

Console.Write("Digite o numero de produtos a ser removido do estoque: ");
produto.RemoverProdutos(int.Parse(Console.ReadLine()));

Console.WriteLine();

Console.Write($"Dados atualizados: {produto.Nome}, {produto.Preco.ToString("F2")}, {produto.Quantidade} unidades, Total: $ ");
Console.WriteLine(produto.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));