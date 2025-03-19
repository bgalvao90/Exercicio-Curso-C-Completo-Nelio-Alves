using AtividadeTriangulo;
using System.Globalization;



Triangulo x = new Triangulo();
Triangulo y = new Triangulo();

Console.WriteLine("Entre com as medidas do triângulo X:");

x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Console.WriteLine("Entre com as medidas do triângulo Y:");

y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.Area();

double areaY = y.Area();


Console.WriteLine("Area do triangulo X : " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Area do triangulo Y : " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
{
    Console.WriteLine("Maior área: X");
}
else
{
    Console.WriteLine("Maior área: Y");
}