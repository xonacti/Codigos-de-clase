#include <iostream>
#include <vector>
#include <ctime>

using namespace std;

bool esAnioValido(int anio) {
    
    const int edadMinima = 100;
    time_t t = time(0);
    tm *ltm = localtime(&t);
    int anioActual = ltm->tm_year + 1900;
    return (anio >= anioActual - edadMinima && anio <= anioActual);
}

int main() {
    vector<string> nombres;
    vector<string> vecindades;
    vector<int> diasNacimiento;
    vector<int> mesesNacimiento;
    vector<int> aniosNacimiento;
    vector<bool> esMayorDeEdad;

    int n;

    cout << "Ingrese los Datos " << endl;
    cout << "Ingrese el numero de personas en la fila: ";
    cin >> n;

    for (int i = 0; i < n; i++) {
        string nombre, vecindad;
        int dia, mes, anio;

        cout << "Ingrese el nombre de la persona " << ": ";
        cin.ignore();
        getline(cin, nombre);
        nombres.push_back(nombre);

        cout << "Ingrese la vecindad de la persona " << ": ";
        getline(cin, vecindad);
        vecindades.push_back(vecindad);

    
        do {
            cout << "Ingrese la fecha de nacimiento de la persona (dd mm aaaa): ";
            cin >> dia >> mes >> anio;
            if (!esAnioValido(anio)) {
                cout << "Año no válido. Debe ingresar un año válido." << endl;
            }
        } while (!esAnioValido(anio));

        diasNacimiento.push_back(dia);
        mesesNacimiento.push_back(mes);
        aniosNacimiento.push_back(anio);

        time_t t = time(0);
        tm *ltm = localtime(&t);
        int edadActual = ltm->tm_year + 1900 - anio;
        bool mayorDeEdad = (edadActual > 18 || (edadActual == 18 && ltm->tm_mon > mes - 1) || (edadActual == 18 && ltm->tm_mon == mes - 1 && ltm->tm_mday >= dia));
        esMayorDeEdad.push_back(mayorDeEdad);

        if (mayorDeEdad) {
            cout << "La persona es mayor de edad." << endl;
        } else {
            cout << "La persona no es mayor de edad." << endl;
        }
    }

    string nombreBusqueda;
    cout << "Ingrese el nombre de la persona que desea buscar: ";
    cin.ignore();
    getline(cin, nombreBusqueda);

    bool encontrado = false;
    for (int i = 0; i < n; i++) {
        if (nombres[i] == nombreBusqueda) {
            cout << "Datos de la persona encontrada:" << endl;
            cout << "Nombre: " << nombres[i] << endl;
            cout << "Vecindad: " << vecindades[i] << endl;
            cout << "Fecha de nacimiento: " << diasNacimiento[i] << "/" << mesesNacimiento[i] << "/" << aniosNacimiento[i] << endl;
            if (esMayorDeEdad[i]) {
                cout << "La persona es mayor de edad." << endl;
            } else {
                cout << "La persona no es mayor de edad." << endl;
            }
            encontrado = true;
            break;
        }
    }

    if (!encontrado) {
        cout << "No se encontró ninguna persona con ese nombre." << endl;
    }

    return 0;
}

