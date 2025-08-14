#include <iostream>
using namespace std;

int main() {
    int DiasSemana = 5;
    float HorasTreinamento;
    double SemanasMes = 4.5;
    double HorasSemana;
    float SemanasNecessarias = 0;
    float AcumuloHoras = 0;
    
    cout << "digite o  numero de horas de treinamento diario: ";
    cin >> HorasTreinamento;
    
    HorasSemana = HorasTreinamento * DiasSemana;
    
    
    while (AcumuloHoras < 1000) {
        AcumuloHoras += HorasTreinamento;
        SemanasNecessarias++;
    }
    
    float DiasNecessarios = SemanasNecessarias * DiasSemana;
    float MesesNecessarios = SemanasNecessarias / SemanasMes;
    
    cout << "Dias necessarios: " << DiasNecessarios << endl;
    cout << "Semanas necessarias: " << SemanasNecessarias << endl;
    cout << "Meses necessarios: " << MesesNecessarios << endl;
        
    return 0;
}
