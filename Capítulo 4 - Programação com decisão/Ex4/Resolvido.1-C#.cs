using System;

class Program
{
 public static void Main(string[] args)
 {
  double n, conversao;
  string menu;
  int opcao;

  Console.WriteLine("N: ");
  n = Convert.ToDouble(Console.ReadLine());
  menu = "Deseja converter para 1 - Celsius ou 2 - Fahrenheit?";
  Console.WriteLine(menu);
  Console.WriteLine("Opção escolhida: ");
  opcao = Convert.ToInt32(Console.ReadLine());

  if (opcao == 1)
  {
   conversao = (n - 32) * (5.0 / 9.0);
   Console.WriteLine(conversao);
  }
  else if (opcao == 2)
  {
   conversao = n * (9.0 / 5.0) + 32;
   Console.WriteLine(conversao);
  }
  else
  {
   Console.WriteLine("Opção Inválida");
  }
 }
}