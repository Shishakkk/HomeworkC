#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");
	cout << "Выберите о чем вы хотите получить информацию" << endl << "1.Видеокарта" << endl << "2.Материнская плата" << endl << "3.Процессор" << endl << "4.Блок Питания" << endl;
	int a = 1;
	int b = 2;
	int c = 3;
	int d = 4;
	int f = 0;
	while (true) {


		cin >> f;
		if (f == 1) {
			cout << "Видеокарта — это устройство, отвечающее за обработку и вывод графики на экран компьютера"<<endl;
		}
		if (f == 2) {
			cout << "Материнская плата — это основная плата компьютера, на которой размещаются процессор, оперативная память, видеокарта и другие компоненты, обеспечивая их взаимодействие между собой."<<endl;
		}
		if (f == 3) {
			cout << "Процессор — это центральный компонент компьютера, который выполняет арифметические и логические операции, управляя работой всех остальных устройств системы."<<endl;
		}
		if (f == 4) {
			cout << "Блок питания — это устройство, преобразующее электрическое напряжение из сети в несколько меньших напряжений, необходимых для работы компонентов компьютера."<<endl;
		}
	}
}
