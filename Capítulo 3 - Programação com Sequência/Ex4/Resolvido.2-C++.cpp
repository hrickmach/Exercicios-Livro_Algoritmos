#include <cmath>
#include <iomanip>
#include <iostream>

int main()
{
 double peso, altura, imc;

 std::cout << "Peso: ";
 std::cin >> peso;
 std::cout << "Altura: ";
 std::cin >> altura;

 imc = peso / pow(altura, 2);

 std::cout << "IMC: "
           << std::fixed << std::setprecision(2) << imc;
}
