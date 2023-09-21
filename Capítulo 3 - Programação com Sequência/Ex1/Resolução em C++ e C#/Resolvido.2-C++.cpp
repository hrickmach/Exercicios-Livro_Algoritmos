#include <iostream>
#include <iomanip>

int main()
{
 double preco, desconto, valor_desconto, preco_final;

 std::cout << "Preço: ";
 std::cin >> preco;
 std::cout << "Desconto: ";
 std::cin >> desconto;

 valor_desconto = preco * (desconto / 100);
 preco_final = preco - valor_desconto;

 std::cout << "Preço final: "
           << std::fixed << std::setprecision(2) << preco_final
           << std::endl;
 std::cout << "Valor do desconto: "
           << std::fixed << std::setprecision(2) << valor_desconto;
 return 0;
}
