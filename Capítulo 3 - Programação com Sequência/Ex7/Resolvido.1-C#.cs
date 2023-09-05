using System;

class Program
{
  public static void Main(string[] args)
  {
    const double centimetros = 2.56;
    double polegadas, conversao;

    Console.WriteLine("Insira o valor em polegadas: ");
    polegadas = Convert.ToDouble(Console.ReadLine());

    conversao = polegadas * centimetros;

    Console.WriteLine($"Resultado da conversão: {conversao:F2}cm");
  }
}
