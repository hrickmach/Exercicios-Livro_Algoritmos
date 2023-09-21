#include <iomanip>
#include <iostream>

int main()
{
 double nota1, nota2, nota3, mp;

 std::cout << "Nota 1: ";
 std::cin >> nota1;
 std::cout << "Nota 2: ";
 std::cin >> nota2;
 std::cout << "Nota 3: ";
 std::cin >> nota3;

 mp = (nota1 + nota2 + nota3) / (2 + 3 + 5);

 if (mp >= 7)
 {
  std::cout << "Aprovado";
 }
 else if (mp >= 5)
 {
  std::cout << "Recuperação";
 }
 else
 {
  std::cout << "Reprovado";
 }
 return 0;
}
