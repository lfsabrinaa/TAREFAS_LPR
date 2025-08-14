#include <iostream>
using namespace std;

void exercicio01() {
    int quantidade, numero;
    int soma = 0, contador = 0, x = 0;
    
    cout << "Quantos numeros serao digitados? ";
    cin >> quantidade;
    
    while (x < quantidade) {
        cout << "Digite um numero: ";
        cin >> numero;

    if (numero % 2 == 0) {
    soma = soma + numero;
    contador = contador + 1;
    }
        x = x + 1;
    }
    if (contador > 0) {
    cout << "A media dos pares e: " << soma / (float)contador;
    }
    else {
    cout << "Nao ha numeros pares";
    }
}


void exercicio03() {
    int i;
    int soma = 0;

    for (i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
        soma = soma + i;
        }
    }
    cout << "A soma é: " << soma;
}

void exercicio04() {
    int numero;

    cout << "Digite um numero inteiro: ";
    cin >> numero;

    int conta = numero * numero;
    int soma = 0;

    while (conta > 0) {
        soma += conta % 10;
        conta /= 10;
    }
    cout << "A soma dos digitos do quadrado e: " << soma << endl;
}

int main() {
    int opcao;

    do {
        cout << "\nMENU DE EXERCICIOS " << endl;
        cout << "1. Exercicio 01: Media dos Pares" << endl;
        cout << "3. Exercicio 03: Soma de Numeros" << endl;
        cout << "4. Exercicio 04: Soma dos Digitos do Quadrado" << endl;
        cout << "\nDigite a opcao desejada: ";
        cin >> opcao;

        switch (opcao) {
            case 1:
                exercicio01();
                break;
            case 3:
                exercicio03();
                break;
            case 4:
                exercicio04();
                break;
            default:
                cout << "Digite uma opcao valida" << endl;
                break;
        }
    } while (opcao != 0);

    return 0;
}
