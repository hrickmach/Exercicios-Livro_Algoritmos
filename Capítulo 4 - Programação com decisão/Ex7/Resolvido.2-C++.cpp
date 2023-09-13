#include <iostream>

int main()
{
 char letra;

 std::cout << "Letra: ";
 std::cin >> letra;

 if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
 {
  std::cout << "É uma vogal";
 }
 else
 {
  std::cout << "É uma consoante";
 }

 return 0;
}
