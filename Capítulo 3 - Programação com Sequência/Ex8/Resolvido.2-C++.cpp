#include <cmath>
#include <iomanip>
#include <iostream>

int main()
{
 double n1, n2, media_geometrica;

 std::cout << "N1: ";
 std::cin >> n1;
 std::cout << "N2: ";
 std::cin >> n2;

 media_geometrica = sqrt((n1 * n2));

 std::cout << "Média geométrica: " << media_geometrica;
}
