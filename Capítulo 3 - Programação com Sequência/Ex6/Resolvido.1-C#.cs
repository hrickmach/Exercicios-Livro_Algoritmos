using System;

class Program
{
 public static void Main(string[] args)
 {
  double preco_compra, preco_venda, lucro;

  Console.WriteLine("Preço de compra: ");
  preco_compra = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Preço de venda: ");
  preco_venda = Convert.ToDouble(Console.ReadLine());

  lucro = preco_venda - preco_compra;

  Console.WriteLine($"Lucro: {lucro}");
 }
}
