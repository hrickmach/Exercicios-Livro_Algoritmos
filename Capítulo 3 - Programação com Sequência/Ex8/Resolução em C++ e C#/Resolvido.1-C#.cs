using System;

class Program
{
  public static void Main(string[] args)
  {
    double n1, n2, media_geometrica;

    Console.WriteLine("N1: ");
    n1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("N2: ");
    n2 = Convert.ToDouble(Console.ReadLine());

    media_geometrica = Math.Sqrt((n1 * n2));

    Console.WriteLine($"Média geométrica: {media_geometrica}");
  }
}
