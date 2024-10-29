#include <iostream>
using namespace std;

/*int main()
{
	setlocale(LC_ALL, "Russian");
	int x, y;
	cin >> x >> y;
	if ((y >= 2 * x - 1) && (y <= -2 * x + 1) && (y >= -2 * x - 1)) {
		cout << "Лежит";

	}
	else {
		cout << "Не лежит";
	}

}*/
#include <iostream>;
#include "math.h"
using namespace std;
/*int main()
{
	setlocale(LC_ALL, "RUS");

	double x, y;
	cout << "введите х: ";
	cin >> x;
	cout << "введите y: ";
	cin >> y;

	if ((y <= 0, 5 * x + 1) && (y >= -0, 5 * x - 1) or ((1 >= pow(y, 2) + pow(x, 2)) and x >= 0)) 
	{
		cout << "входит ";
	}
	else { cout << "не входит "; }
    */
}int main()
{
    float y;
    float x;
    for (int i = 0; i < 5; i++) {
        switch (i)
        {
        case(0):
            y = -0.1;
            x = -2.5;
            break;
        case(1):
            y = 0.1;
            x = 1.5;
            break;
        case(2):
            y = 0.5;
            x = -0.5;
            break;
        case(3):
            y = 0.5;
            x = 1.5;
            break;
        case(4):
            y = 1.1;
            x = 0.5;
            break;
        }
    }
}
