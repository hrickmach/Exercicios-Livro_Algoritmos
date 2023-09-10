using System;

class Program
{
 public static void Main(string[] args)
 {
  double preco, desconto, valor_desconto, preco_final;

  Console.WriteLine("Insira o preço: ");
  preco = Convert.ToDouble(Console.ReadLine());

  Console.WriteLine("Insira o desconto: ");
  desconto = Convert.ToDouble(Console.ReadLine());

  valor_desconto = preco * desconto / 100;
  preco_final = preco - valor_desconto;

  Console.WriteLine($"Preço final: {preco_final:F2}");
  Console.WriteLine($"Valor do desconto: {valor_desconto:F2}");
 }
}
