using Atividade02;
using System.Globalization;


SalarioFunc Funcionario1 = new SalarioFunc();
SalarioFunc Funcionario2 = new SalarioFunc();

Console.WriteLine("Dados do primeiro funcionário");
Funcionario1.Nome = Console.ReadLine();
Funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionário");
Funcionario2.Nome = Console.ReadLine();
Funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double mediaSalario = (Funcionario1.Salario + Funcionario2.Salario) / 2;
Console.WriteLine("Salario médio: " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));