using System;

class Program
{
 public static void Main(string[] args)
 {
  double preco_produto, desconto_produto, cupom, desconto_total, preco_final;

  Console.WriteLine("Preço do produto: ");
  preco_produto = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Desconto do produto: ");
  desconto_produto = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Cupom: ");
  cupom = Convert.ToDouble(Console.ReadLine());

  desconto_total = (preco_produto * desconto_produto / 100) + cupom;
  preco_final = preco_produto - desconto_total;

  Console.WriteLine($"Desconto total: {desconto_total:F2}");
  Console.WriteLine($"Preço final: {preco_final:F2}");
 }
}