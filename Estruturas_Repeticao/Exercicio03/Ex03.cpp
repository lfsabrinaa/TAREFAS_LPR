#include <iostream>
using namespace std;

int main() {
    int i;
    int soma = 0;

    for (i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
        soma = soma + i;
        }
    }
    cout << "a soma é: " << soma;

    return 0;
}
