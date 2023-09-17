#include <iostream>

int main() {
  int i = 1;
  int r = 1;
  int n;

  std::cout << "Insira o valor do número natural entre 1 a 15: ";
  std::cin >> n;

  while (i <= n) {
    if (n > 0) {
      r = r * i;
    } else {
      std::cout << "Número não-natural";
    }
    i++;
  }
  std::cout << r;

  return 0;
}
