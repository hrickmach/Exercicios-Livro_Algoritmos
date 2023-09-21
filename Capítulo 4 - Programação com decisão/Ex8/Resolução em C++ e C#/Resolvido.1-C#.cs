using System;

class Program
{
 public static void Main(string[] args)
 {
  double n1, n2, n3, n4, md1;
  int faltas;

  Console.WriteLine("N1: ");
  n1 = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("N2: ");
  n2 = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("N3: ");
  n3 = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("N4: ");
  n4 = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Faltas: ");
  faltas = Convert.ToInt32(Console.ReadLine());

  md1 = (n1 + n2 + n3 + n4) / 4;

  if (md1 >= 7 && faltas <= 10)
  {
   Console.WriteLine("Aprovado");
  }
  else
  {
   Console.WriteLine("Reprovado");
  }
  Console.Write($"Média: {md1}");
 }
}
