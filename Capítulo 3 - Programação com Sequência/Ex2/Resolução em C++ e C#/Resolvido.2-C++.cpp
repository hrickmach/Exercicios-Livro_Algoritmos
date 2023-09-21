#include <iostream>
#include <iomanip>

int main()
{
  double nota1, nota2, peso1, peso2, mp;

  std::cout << "Nota 1: ";
  std::cin >> nota1;
  std::cout << "Nota 2: ";
  std::cin >> nota2;
  std::cout << "Peso 1: ";
  std::cin >> peso1;
  std::cout << "Peso 2: ";
  std::cin >> peso2;

  mp = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

  std::cout << "Média ponderada: "
            << std::fixed << std::setprecision(2) << mp;

  return 0;
}
