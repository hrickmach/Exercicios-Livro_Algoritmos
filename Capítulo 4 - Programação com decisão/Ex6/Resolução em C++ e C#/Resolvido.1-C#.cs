using System;

class Program
{
 public static void Main(string[] args)
 {
  double n, raiz;

  Console.WriteLine("N: ");
  n = Convert.ToDouble(Console.ReadLine());

  raiz = Math.Sqrt(n);

  if (raiz * raiz == n)
  {
   Console.Write("É um quadrado perfeito");
  }
  else
  {
   Console.Write("Não é um quadrado perfeito");
  }
 }
}
