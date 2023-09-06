using System;

class Program
{
 public static void Main(string[] args)
 {
  char letra;

  Console.WriteLine("Letra: ");
  letra = Convert.ToChar(Console.ReadLine());

  if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
  {
   Console.Write("É uma vogal");
  }
  else
  {
   Console.Write("É uma consoante");
  }
 }
}
