#include <iomanip>
#include <iostream>

int main()
{
 double a, b;
 int opcao;

 std::cout << "Valor de A: ";
 std::cin >> a;
 std::cout << "Valor de B: ";
 std::cin >> b;
 std::cout << "Opção escolhida: ";
 std::cin >> opcao;

 switch (opcao)
 {
 case 1:
  std::cout << a + b;
  break;
 case 2:
  std::cout << a - b;
  break;
 case 3:
  std::cout << a * b;
  break;
 case 4:
  std::cout << a / b;
  break;
 default:
  std::cout << "Opção inválida";
  break;
 }
 return 0;
}
