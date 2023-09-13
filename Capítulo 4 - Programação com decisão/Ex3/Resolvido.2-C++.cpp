#include <iostream>

int main()
{
 double a, b, c, d;

 std::cout << "A: ";
 std::cin >> a;
 std::cout << "B: ";
 std::cin >> b;
 std::cout << "C: ";
 std::cin >> c;
 std::cout << "D: ";
 std::cin >> d;

 if ((a == b && c == d) || (a == c && b == d) || (a == d && b == c))
 {
  std::cout << "É um quadrado";
 }
 else
 {
  std::cout << "Não é um quadrado";
 }

 return 0;
}
