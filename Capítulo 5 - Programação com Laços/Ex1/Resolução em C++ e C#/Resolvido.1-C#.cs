using System;

class Program
{
 public static void Main(string[] args)
 {
  int i = 1;
  double r;

  while (i <= 150)
  {
   r = Math.Sqrt(i);
   Console.WriteLine($"Raiz quadrada de {i} é: {r}");
   i++;
  }
 }
}
