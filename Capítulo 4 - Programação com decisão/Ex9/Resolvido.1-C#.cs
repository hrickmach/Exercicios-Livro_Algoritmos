using System;

class Program
{
 public static void Main(string[] args)
 {
  string usuario, senha;

  Console.Write("Usuário: ");
  usuario = Console.ReadLine();
  Console.Write("Senha: ");
  senha = Console.ReadLine();

  if (usuario == "admin" && senha == "senha123")
  {
   Console.WriteLine("Acesso concedido");
  }
  else
  {
   Console.WriteLine("Acesso negado");
  }
 }
}
