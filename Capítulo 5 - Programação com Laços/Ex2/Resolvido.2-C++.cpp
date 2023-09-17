#include <iostream>

int main()
{
 int n = 1;

 while (n > 0)
 {
  std::cout << "Digite um valor inteiro: ";
  std::cin >> n;
 }
 std::cout << "Valor inválido";

 return 0;
}
