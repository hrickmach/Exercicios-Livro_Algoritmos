using System;

class Program
{
  public static void Main(string[] args)
  {
    double a, b;
    int opcao;

    Console.WriteLine("A: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("B: ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Opção escolhida: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
      case 1:
        Console.Write(a + b);
        break;
      case 2:
        Console.Write(a - b);
        break;
      case 3:
        Console.Write(a * b);
        break;
      case 4:
        Console.Write(a / b);
        break;
      default:
        Console.Write("Opção Inválida");
        break;
    }
  }
}
