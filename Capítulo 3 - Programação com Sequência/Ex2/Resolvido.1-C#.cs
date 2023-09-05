using System;

class Program
{
 public static void Main(string[] args)
 {
  double nota1, nota2, peso1, peso2, mp;

  Console.WriteLine("Nota 1: ");
  nota1 = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Nota 2: ");
  nota2 = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Peso 1: ");
  peso1 = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Peso 2: ");
  peso2 = Convert.ToDouble(Console.ReadLine());

  mp = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

  Console.WriteLine($"Média Ponderada: {mp:F2}");
 }
}
