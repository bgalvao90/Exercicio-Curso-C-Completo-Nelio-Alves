using AtividadeFixacao;
using System.Globalization;


Funcionario func = new Funcionario();

Console.Write("Nome: ");
func.Nome = Console.ReadLine();

Console.Write("Salario Bruto: ");
func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Imposto: ");
func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Clear();

Console.WriteLine($"Funcionario: {func}");

Console.WriteLine();

Console.Write("Digite a porcentagem para aumentar o salário: ");
func.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.Clear();

Console.WriteLine($"Dados atualizados: {func}");
