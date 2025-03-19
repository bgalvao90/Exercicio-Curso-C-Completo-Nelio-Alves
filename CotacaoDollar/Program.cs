using CotacaoDollar;
using System.Globalization;



Console.Write("Qual é a cotação do Dollar? ");
double CotacaoDollar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();

Console.Write("Quantos Dolares você vai comprar? ");
double Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();

double conversao = ConversorDeMoeda.CotacaoDollar(CotacaoDollar, Valor );
Console.WriteLine($"Valor a ser pago em reais = R$ {(conversao).ToString("F2", CultureInfo.InvariantCulture)}");