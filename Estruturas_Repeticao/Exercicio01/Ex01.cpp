#include <iostream>
using namespace std;

int main()
{
    int quantidade, numero;
    int soma = 0, contador = 0, x = 0;
    
    cout << "quantos numeros serao digitados? ";
    cin >> quantidade;
    
    while (x < quantidade) {
        cout << "digite um numero: ";
        cin >> numero;

    if (numero % 2 == 0) {
    soma = soma + numero;
    contador = contador + 1;
    }
        x = x + 1;
    }
    if (contador > 0) {
    cout << "a media dos pares e: " << soma / (float)contador;
    }
    else {
    cout << "nao ha numeros pares";
    }

    return 0;
}
