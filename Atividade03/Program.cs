﻿using System.Globalization;
using System;
using Atividade03;
namespace Problema2
{
    class Program
    {
        

        static void Main(string[] args)
        {
          


            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.Clear();

            Console.WriteLine($"Circunferência {circ.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();

            Console.WriteLine($"Volume {volume.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();

            Console.WriteLine($"Valor de PI: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");



        }


        
    }
}