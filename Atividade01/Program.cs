using Atividade01;


NomeIdade Pessoa1 = new NomeIdade();
NomeIdade Pessoa2 = new NomeIdade();

Console.WriteLine("Dados da primeira pessoa");
Pessoa1.Nome = Console.ReadLine();
Pessoa1.Idade = int.Parse(Console.ReadLine());
Console.WriteLine("Dados da segunda pessoa");
Pessoa2.Nome = Console.ReadLine();
Pessoa2.Idade = int.Parse(Console.ReadLine());

if (Pessoa1.Idade > Pessoa2.Idade)
{
    Console.WriteLine("Pessoa mais velha: " + Pessoa1.Nome);
}
else
{
    Console.WriteLine("Pessoa mais velha: " + Pessoa2.Nome);
}