#include <iomanip>
#include <iostream>

int main()
{
 double preco_compra, preco_venda, lucro;

 std::cout << "Preço de compra: ";
 std::cin >> preco_compra;
 std::cout << "Preço de venda: ";
 std::cin >> preco_venda;

 lucro = preco_venda - preco_compra;

 std::cout << "Lucro: " << lucro;
}
