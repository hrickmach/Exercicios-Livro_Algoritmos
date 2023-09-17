using System;

class Program
{
 public static void Main(string[] args)
 {
  int n = 1;

  while (n > 0)
  {
   Console.WriteLine("Digite um número inteiro: ");
   n = Convert.ToInt32(Console.ReadLine());
  }
  Console.WriteLine("Valor inválido");
 }
}