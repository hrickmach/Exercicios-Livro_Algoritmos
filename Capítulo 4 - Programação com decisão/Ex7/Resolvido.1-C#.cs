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
   Console.WriteLine("É uma vogal");
  }
  else
  {
   Console.WriteLine("É uma consoante");
  }
 }
}
