#include <iomanip>
#include <iostream>

int main()
{
 double const centimetros = 2.54;

 double polegadas, conversao;

 std::cout << "Polegadas: ";
 std::cin >> polegadas;

 conversao = polegadas * centimetros;

 std::cout << "Resultado da conversão: "
           << std::fixed << std::setprecision(2) << conversao;

 return 0;
}
