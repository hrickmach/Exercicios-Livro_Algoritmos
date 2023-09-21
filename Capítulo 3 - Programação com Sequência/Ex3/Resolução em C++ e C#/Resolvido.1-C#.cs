using System;

class Program
{
 public static void Main(string[] args)
 {
  double hora, segundos;

  Console.WriteLine("Hora: ");
  hora = Convert.ToDouble(Console.ReadLine());

  segundos = hora * 3600;

  Console.WriteLine($"Conversão da hora informada para segundos: {segundos:F2}");
 }
}