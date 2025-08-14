#include <iostream>
#include <iomanip>

using namespace std;


int main() {

    int nA;
    int nB;
    float conta2;
    float conta;

    cout << "digite um numero inteiro:" << endl;
    cin >> nA;
    cout << "digite outro numero inteiro:" << endl;
    cin >> nB;

    conta2 = nB % nA;
    conta = nA % nB;

    if (conta == 0 || conta2 == 0) {
      cout << "Os numeros fornecidos sao multiplos entre si." << endl;
    }
    else {
        cout << "Os numeros fornecidos NAO sao multiplos entre si." << endl;
    }


    return 0;

}
