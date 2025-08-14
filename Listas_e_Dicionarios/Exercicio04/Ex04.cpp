#include <iostream>
#include <map>
#include <string>
#include <limits>

using namespace std;

int main() {
    map<string, int> cidades;
    int cidade;
    cout << "Quantas cidades quer adicionar? ";
    cin >> cidade;

    for (int i = 0; i < cidade; i++) {
        string nome;
        int populacao;
        cout << "Qual o nome da cidade? ";
        cin >> nome;
        cout << "Qual a população da cidade? ";
        cin >> populacao;

        cidades[nome] = populacao;
    }

    int populacaototal = 0;
    for (auto &par : cidades) {
        populacaototal += par.second;
    }
    double media = populacaototal/cidades.size();
    cout << "\nA populacao media é de: " << media << endl;
    cout << "As cidades com populacao acima da media sao:\n";
    for (auto &par : cidades) {
        if (par.second > media) {
            cout << par.first << " (" << par.second << " habitantes)\n";
        }
    }

    string maispessoas, menospessoas;
    int maiorp = numeric_limits<int>::min();
    int menorp = numeric_limits<int>::max();

    for (auto &par : cidades) {
        if (par.second > maiorp) {
            maiorp = par.second;
            maispessoas = par.first;
        }
        if (par.second < menorp) {
            menorp = par.second;
            menospessoas = par.first;
        }
    }

    cout << "\nA cidade com mais habitantes é: " << maispessoas << " (" << maiorp << " habitantes)\n";
    cout << "A cidade com menos habitantes é: " << menospessoas << " (" << menorp << " habitantes)\n";
    
    int remover;
    cout << "\nQual populacao gostaria de remover? ";
    cin >> remover;

    for (auto it = cidades.begin(); it != cidades.end();) {
        if (it->second == remover) {
            it = cidades.erase(it);
        } else {
            ++it;
        }
    }

    cout << "\nDicionario atualizado:\n";
    for (auto &par : cidades) {
        cout << par.first << " (" << par.second << " habitantes)\n";
    }

    return 0;
}
