#include <iostream>
#include <string>
using namespace std;

struct livro {
    string titulo;
    string autor;
    int anopublicacao;
    int numeropaginas;
    float preco;
};

int main() {
    livro livros[3];
    float precototal = 0;
    int paginas = 0;

    for (int i = 0; i < 3; i++) {

        cout << "titulo do livro: ";
        getline(cin, livros[i].titulo);
        cout << "autor: ";
        getline(cin, livros[i].autor);
        cout << "ano de publicacao: ";
        cin >> livros[i].anopublicacao;
        cout << "numero de paginas: ";
        cin >> livros[i].numeropaginas;
        cout << "preco: ";
        cin >> livros[i].preco;

        precototal += livros[i].preco;
        paginas += livros[i].numeropaginas;
    }

    cout << "\nO valor total dos livros e de R$ " << precototal << endl;
    cout << "A quantidade media de paginas e de " << (paginas / 3.0) << endl;

    return 0;
}
