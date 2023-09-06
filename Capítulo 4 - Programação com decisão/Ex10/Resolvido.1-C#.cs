using System;

class Program
{
 public static void Main(string[] args)
 {
  int ano, v1, v2, v3;

  Console.WriteLine("Ano: ");
  ano = Convert.ToInt32(Console.ReadLine());

  v1 = ano % 4;
  v2 = ano % 100;
  v3 = ano % 400;

  if ((v1 == 0 && v2 != 0) || (v3 == 0))
  {
   Console.Write("É bissexto");
  }
  else
  {
   Console.Write("Não é bissexto");
  }
 }
}
