#include <iomanip>
#include <iostream>

int main() 
{
  double preco_produto, desconto_produto, cupom, desconto_total, preco_final;

  std:: cout << "Preço do produto: ";
  std:: cin >> preco_produto;
  std:: cout << "Desconto do produto: ";
  std:: cin >> desconto_produto;
  std:: cout << "Cupom: ";
  std:: cin >> cupom;

  desconto_total = (preco_produto * desconto_produto / 100) + cupom;
  preco_final = preco_produto - desconto_total;

  std:: cout << "Desconto total: "
  << std:: fixed << std:: setprecision(2) << desconto_total;
  std:: cout << "\nPreço final: "
  << std:: fixed << std:: setprecision(2) << preco_final;
}
