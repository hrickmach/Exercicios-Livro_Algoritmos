#include <cmath>
#include <iomanip>
#include <iostream>

int main()
{
 double x1, y1, z1;
 double x2, y2, z2, distancia;

 std::cout << "x1: ";
 std::cin >> x1;
 std::cout << "y1: ";
 std::cin >> y1;
 std::cout << "z1: ";
 std::cin >> z1;
 std::cout << "x2: ";
 std::cin >> x2;
 std::cout << "y2: ";
 std::cin >> y2;
 std::cout << "z2: ";
 std::cin >> z2;

 distancia = sqrt(pow((x2 - x1), 2) + pow((y2 - y1), 2) + pow((z2 - z1), 2));

 std::cout << "Distância entre os pontos: " << distancia;

 return 0;
}
