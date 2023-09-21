#include <iostream>

int main()
{
 int ano, v1, v2, v3;

 std::cout << "Ano: ";
 std::cin >> ano;

 v1 = ano % 4;
 v2 = ano % 100;
 v3 = ano % 400;

 if ((v1 == 0 && v2 != 0) || (v3 == 0))
 {
  std::cout << "É bissexto";
 }
 else
 {
  std::cout << "Não é bissexto";
 }

 return 0;
}
