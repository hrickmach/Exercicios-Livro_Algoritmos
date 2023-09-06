using System;

class Program
{
 public static void Main(string[] args)
 {
  double peso, altura, imc;

  Console.WriteLine("Peso: ");
  peso = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Altura: ");
  altura = Convert.ToDouble(Console.ReadLine());

  imc = peso / Math.Pow(altura, 2);

  if (imc < 18.5)
  {
   Console.WriteLine("Abaixo do peso");
   Console.WriteLine($"IMC: {imc:F2}");
  }
  else if (imc >= 25 && imc < 30)
  {
   Console.WriteLine("Peso normal");
   Console.WriteLine($"IMC: {imc:F2}");
  }
  else if (imc >= 30 && imc < 35)
  {
   Console.WriteLine("Sobrepeso");
   Console.WriteLine($"IMC: {imc:F2}");
  }
  else if (imc >= 35 && imc < 40)
  {
   Console.WriteLine("Obesidade grau 2");
   Console.WriteLine($"IMC: {imc:F2}");
  }
  else
  {
   Console.WriteLine("Obesidade grau 3");
   Console.WriteLine($"IMC: {imc:F2}");
  }
 }
}