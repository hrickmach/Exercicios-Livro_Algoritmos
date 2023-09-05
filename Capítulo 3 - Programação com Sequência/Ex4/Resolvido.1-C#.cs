using System;

class Program
{
 public static void Main(string[] args)
 {
  double peso, altura, imc;

  Console.WriteLine("Peso: ");
  peso = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Altura: ");
  altura = Convert.ToDouble(Console.ReadLine());

  imc = peso / Math.Pow(altura, 2);

  Console.WriteLine($"IMC: {imc:F2}");
 }
}
