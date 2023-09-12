#include <iostream>
#include <iomanip>

int main()
{
 double hora, segundos;
 std::cout << "Hora: ";
 std::cin >> hora;

 segundos = hora * 3600;

 std::cout << "Conversão da hora informada para segundos: "
           << std::fixed << std::setprecision(1) << segundos;

 return 0;
}
