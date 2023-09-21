#include <iostream>
#include <cmath>

int main()
{
 double n, raiz;

 std::cout << "N: ";
 std::cin >> n;

 raiz = std::sqrt(n);

 if (raiz * raiz == n)
 {
  std::cout << "É um quadrado perfeito";
 }
 else
 {
  std::cout << "Não é um quadrado perfeito";
 }

 return 0;
}
