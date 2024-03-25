using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Por favor, insira um valor em metros: ");
        double metros = double.Parse(Console.ReadLine());

        double quilometros = metros / 1000;
        double decimetros = metros * 10;
        double centimetros = metros * 100;
        double milimetros = metros * 1000;

        Console.WriteLine($"Valor em quilômetros: {quilometros} km");
        Console.WriteLine($"Valor em decímetros: {decimetros} dm");
        Console.WriteLine($"Valor em centímetros: {centimetros} cm");
        Console.WriteLine($"Valor em milímetros: {milimetros} mm");
    }
}