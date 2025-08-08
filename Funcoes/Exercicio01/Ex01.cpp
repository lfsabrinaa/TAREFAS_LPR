#include <iostream>
using namespace std;

int reversonum(int n) {
    int reverso = 0;
    while (n != 0) {
        int digito = n % 10;
        reverso = reverso * 10 + digito;
        n /= 10;
    }
    return reverso;
}

int main() {
    cout << "digite um numero: ";
    int num;
    cin >> num;
    int numreverso = reversonum(num);

    std::cout << "Entrada: " << num << std::endl;
    std::cout << "Saida: " << numreverso << std::endl;

    return 0;
}
