using System;

class Program
{
 public static void Main(string[] args)
 {
  double a, b, c, d;

  Console.WriteLine("A: ");
  a = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("B: ");
  b = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("C: ");
  c = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("D: ");
  d = Convert.ToDouble(Console.ReadLine());

  if ((a == b && c == d) || (a == c && b == d) || (a == d && b == c))
  {
   Console.WriteLine("É um quadrado");
  }
  else
  {
   Console.WriteLine("Não é um quadrado");
  }
 }
}
