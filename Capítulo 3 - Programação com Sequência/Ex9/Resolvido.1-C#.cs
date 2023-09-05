using System;

class Program
{
  public static void Main(string[] args)
  {
    double x1, y1, z1;
    double x2, y2, z2, distancia;

    Console.WriteLine("x1: ");
    x1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("y1: ");
    y1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("z1: ");
    z1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("x2: ");
    x2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("y2: ");
    y2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("z2: ");
    z2 = Convert.ToDouble(Console.ReadLine());

    distancia = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)));

    Console.WriteLine($"Distância entre os pontos: {distancia}");
  }
}
