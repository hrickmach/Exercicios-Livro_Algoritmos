using System;

class Program
{
 public static void Main(string[] args)
 {
  double nota1, nota2, nota3, mp;

  Console.WriteLine("Nota 1: ");
  nota1 = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Nota 2: ");
  nota2 = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Nota 3: ");
  nota3 = Convert.ToDouble(Console.ReadLine());

  mp = (nota1 + nota2 + nota3) / (2 + 3 + 5);

  if (mp >= 7)
  {
   Console.Write("Aprovado");
  }
  else if (mp >= 5)
  {
   Console.WriteLine("Recuperação");
  }
  else
  {
   Console.WriteLine("Reprovado");
  }
 }
}
