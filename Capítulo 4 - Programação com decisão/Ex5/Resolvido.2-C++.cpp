#include <iostream>
#include <cmath>
#include <iomanip>

int main()
{
 double peso, altura, imc;

 std::cout << "Peso: ";
 std::cin >> peso;
 std::cout << "Altura: ";
 std::cin >> altura;

 imc = peso / std::pow(altura, 2);

 if (imc < 18.5)
 {
  std::cout << "Abaixo do peso\n";
  std::cout << "IMC: " << std::fixed << std::setprecision(2) << imc;
 }
 else if (imc >= 25 && imc < 30)
 {
  std::cout << "Peso normal\n";
  std::cout << "IMC: " << std::fixed << std::setprecision(2) << imc;
 }
 else if (imc >= 30 && imc < 35)
 {
  std::cout << "Sobrepeso\n";
  std::cout << "IMC: " << std::fixed << std::setprecision(2) << imc;
 }
 else if (imc >= 35 && imc < 40)
 {
  std::cout << "Obesidade grau 2\n";
  std::cout << "IMC: " << std::fixed << std::setprecision(2) << imc;
 }
 else
 {
  std::cout << "Obesidade grau 3\n";
  std::cout << "IMC: " << std::fixed << std::setprecision(2) << imc;
 }

 return 0;
}
