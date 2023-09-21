#include <iostream>

int main()
{
 double n1, n2, n3, n4, md1;
 int faltas;

 std::cout << "N1: ";
 std::cin >> n1;
 std::cout << "N2: ";
 std::cin >> n2;
 std::cout << "N3: ";
 std::cin >> n3;
 std::cout << "N4: ";
 std::cin >> n4;
 std::cout << "Faltas: ";
 std::cin >> faltas;

 md1 = (n1 + n2 + n3 + n4) / 4;

 if (md1 >= 7 && faltas <= 10)
 {
  std::cout << "Aprovado\n";
 }
 else
 {
  std::cout << "Reprovado\n";
 }

 std::cout << "Média: " << md1;

 return 0;
}
