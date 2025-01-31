#include <iostream>

int sum(int** arr, int sizex, int sizey) {
    int res = 0;
    for (int i = 0; i < sizex; i++) {
        for (int j = 0; j < sizey; j++) {
            res += arr[i][j];
        }
    }
    return res;
}

int main()
{
    setlocale(LC_ALL, "rus");
    int sizex = 10;
    int sizey = 10;
    int n = 0;
    int**arr = new int*[sizex];
    for (int i = 0; i < sizey; i++)
        arr[i] = new int[sizey];
    for (int i = 0; i < sizex; i++) {
        for (int j = 0; j < sizey; j++)
            arr[i][j] = n;
        n++;
    }
    std::cout << sum(arr, sizex, sizey);
}
