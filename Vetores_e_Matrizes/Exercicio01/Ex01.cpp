#include <iostream>
using namespace std;

int main() {
    int numeros[10], npares[10], nimpares[10];
    int Par = 0, Impar = 0;

    cout << "digite 10 numeros inteiros: ";
    for (int i = 0; i < 10; i++) {
        cin >> numeros[i];
         if (numeros[i] % 2 == 0) {
          npares[Par] = numeros[i];
          Par++;
         }
         else {
          nimpares[Impar] = numeros[i];
          Impar++;
         }
    }

    cout << " Numeros pares: ";
    for (int i = 0; i < Par; i++) {
        cout << npares[i] << " ";
    }
    cout << "\nNumeros impares: ";
    for (int i = 0; i < Impar; i++) {
        cout << nimpares[i] << " ";
    }

    return 0;
}

