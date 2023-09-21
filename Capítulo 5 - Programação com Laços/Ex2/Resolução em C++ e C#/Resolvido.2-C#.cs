using System;

class Program
{
 public static void Main(string[] args)
 {
  int i = 1;
  int r = 1;
  int n;

  Console.Write("Insira o valor do número natural entre 1 a 15: ");
  n = Convert.ToInt32(Console.ReadLine());

  while (i <= n)
  {
   if (n > 0)
   {
    r = r * i;
   }
   else
   {
    Console.WriteLine("Número não-natural");
   }
   i++;
  }
  Console.WriteLine(r);
 }
}