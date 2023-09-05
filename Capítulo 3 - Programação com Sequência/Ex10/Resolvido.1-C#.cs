using System;

class Program
{
  public static void Main(string[] args)
  {
    double custo, margem, preco_venda;

    Console.WriteLine("Custo: ");
    custo = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Margem: ");
    margem = Convert.ToDouble(Console.ReadLine());

    preco_venda = custo * (1 + margem / 100);

    Console.WriteLine($"Preço de venda: {preco_venda:F2}");
  }
}
