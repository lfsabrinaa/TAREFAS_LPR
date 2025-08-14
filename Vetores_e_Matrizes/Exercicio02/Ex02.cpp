#include <iostream>
using namespace std;

int main() {
    int numeros[10], npares[10], nimpares[10];
    int pesquisar;
    int nanterior = 0;
    int ocorrencias = 0;

    cout << "digite 10 numeros inteiros: ";
    for (int i = 0; i < 10; i++) {
        cin >> numeros[i];
    }
    
    while(true){
    cout << "\nqual numero voce gostaria de pesquisar? ";
    cin >> pesquisar;
    
    int ocorrenciass = 0;

    cout << "o numero " << pesquisar << " foi encontrado na posicao ";
    for (int i = 0; i < 10; i++) {
        if (numeros[i] == pesquisar) {
         cout << i << " ";
         ocorrenciass++;
        }
    }
    
    if (ocorrenciass > 0){
        if (pesquisar == nanterior) {
         ocorrencias += ocorrenciass;
        }
        else {
        ocorrencias = ocorrenciass;
         nanterior = pesquisar;
        }
        
        cout << "\nja houveram " << ocorrencias << " ocorrencias de pesquisa";
        
    }
    else {
        cout << "\nainda nao houveram ocorrencias de pesquisa";
    }
    }

    return 0;
}
