#include <iostream>
#include <vector>
#include <algorithm>
#include <cstdlib>
#include <ctime>
using namespace std;

int main() {
    srand(time(0));

    vector<int> numeros;

    for (int i = 0; i < 100; i++) {
      numeros.push_back(rand() % 100);
    }

    sort(numeros.begin(), numeros.end());

    cout << "os números são: " << endl;
    for (int n : numeros) {
        cout << n << " ";
    }
    cout << "\n" << endl;

    numeros.erase(remove_if(numeros.begin(), numeros.end(),
                            [](int n) { return n % 2 == 0; }),
                  numeros.end());

    cout << "\nos números sem pares são:" << endl;
    for (int n : numeros) {
        cout << n << " ";
    }
    cout << "\n" << endl;

    cout << "os números repetidos são:" << endl;
    bool repetiu = false;
    for (size_t i = 1; i < numeros.size(); i++) {
        if (numeros[i] == numeros[i - 1]) {
            cout << numeros[i] << " ";
            repetiu = true;
        }
    }
    if (!repetiu) {
        cout << "não há números repetidos";
    }
    cout << endl;

    return 0;
}
