#include <iostream>
using namespace std;

class date {
private:
    int y;
    int m;
    int d;
    void Rav() {
        if (y % 4 != 0) {
            if (m == 2) {
                if (d > 28) {
                    m++;
                    d = d % 28;
                }
            }
        }
        if (y % 4 == 0) {
            if (m == 2) {
                if (d > 29) {
                    m++;
                    d = d % 29;
                }
            }
        }

        if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12) {
            if (d > 31) {
                m++;
                d = d % 31;
            }
        }
        if (m == 4 || m == 6 || m == 9 || m == 11) {
            if (d > 30) {
                m++;
                d = d % 30;
            }
        }

    }
public:
    int Gety() {
        return y;
    }
    int Getm() {
        return m;
    }
    int Getd() {
        return d;
    }
    void GetAll() {
        cout << "year: " << y << endl;
        cout << "month: " << m << endl;
        cout << "day: " << d << endl;
    }
    void Sety(int y) {
        this->y = y;
        Rav();
    }
    void Setm(int m) {
        this->m = m;
        Rav();
    }
    void Setd(int d) {
        this->d = d;
        Rav();
    }
    void Summ(date num) {
        this->d += num.d;
        this->m += num.m;
        this->y += num.y;
        Rav();
    }
    void Razn(date num) {
        this->d -= num.d;
        this->m -= num.m;
        this->y -= num.y;
        Rav();
    }
    date operator+(const date& sec) {
        d += sec.d;
        m += sec.m;
        y += sec.y;
        Rav();
        return date(*this);
    }
    date operator+(const int& num) {
        d += num;
        Rav();
        return date(*this);
    }
    date operator-(const date& sec) {
        d -= sec.d;
        m -= sec.m;
        y -= sec.y;
        Rav();
        return date(*this);
    }
    date operator-(const int& num) {
        d -= num;
        Rav();
        return date(*this);
    }
    int operator++ () {
        d++;
        Rav();
        return d;
    }
    int operator++ ()
    {
        int copy = d;
        d++;
        return copy;
        Rav();
    }
    int operator-- () {
        d--;
        return d;
        Rav();
    }
    int operator-- ()
    {
        int copy = d;
        d--;
        return copy;
        Rav();
    }
    date operator*(int n) {
        d* n;
        y* n;
        m* n;
        Rav();
        return date(*this);
    }
    date operator/(int n) {
        d/ n;
        y/ n;
        m/ n;
        Rav();
        return date(*this);
    }
    friend ostream& operator<<(ostream& stream, date& curr)
    {
        stream << "years: " << curr.y << endl << " months : " << curr.m << endl <<"days: " << curr.d << endl;
        return stream;
    }
    friend istream& operator>>(istream& stream, date& curr)
    {
        cin >> curr.y >> curr.m >> curr.d ;
        return stream;
    }
    bool operator<(date n) {
        if (y < n.y) {
            if (m < n.m) {
                if (d < n.d)
                    return true;
            }
        }
        return false;
    }
    bool operator>(date n) {
        if (y > n.y) {
            if (m > n.m) {
                if (d > n.d)
                    return true;
            }
        }
        return false;
    }
    bool operator==(date n) {
        if (y == n.y) {
            if (m == n.m) {
                if (d == n.d)
                    return true;
            }
        }
        return false;
    }
    bool operator!=(date n) {
        if (y != n.y) {
            if (m != n.m) {
                if (d != n.d)
                    return true;
            }
        }
        return false;
    }
};

int main()
{
    setlocale(LC_ALL, "rus");
    date tod;
    tod.Sety(2024);
    tod.Setm(3);
    tod.Setd(31);
    tod.GetAll();
    cout << tod;
}
