#include <iostream>
using namespace std;

class Stud {
protected:
    string name;
    int age;
    string group;
public:
    virtual void print() = 0;
};
class OtchStud :public Stud {
protected:
    string date;
public:
    OtchStud() {
        name = "";
        group = "";
        age = 0;
        date = "";
    }
    OtchStud(string name, int age, string group , string date) {
        this->name = name;
        this->group = group;
        this->age = age;
        this->date = date;
    }
    void print() {
        cout << "name:" << name << endl;
        cout << "age:" << age << endl;
        cout << "group:" << group<<endl;
        cout << "date otchislenia" << date << endl;
    }
};
class Alex:public OtchStud {
private:
    string prichina;
public:
    Alex() {
        name = "";
        group = "";
        age = 0;
        date = "";
        prichina = "";
    }
    Alex(string name, int age, string group, string date, string prichina) {
        this->name = name;
        this->group = group;
        this->age = age;
        this->date = date;
        this->prichina = prichina;
    }
    void print() {
        cout << "name:" << name << endl;
        cout << "age:" << age << endl;
        cout << "group:" << group << endl;
        cout << "date otchislenia" << date << endl;
        cout << "prichina otchislenia: " << prichina << endl;
    }
};
class College;
class Audit {
private:
    Stud* aud ;
    int count;
public:
    Audit() {
        aud = nullptr;
        count = 0;
    }
    Audit(Stud* auditoria, int count) {
        this->aud = auditoria;
        this->count = count;
    }
    void print() {
        for (int i = -0; i < count; i++) {
            aud[i].print();
        }
    }
};
class College {
private:
    Audit* coll;
    int count;
public:
    College() {
        coll = nullptr;
        count = 0;
    }
    College(Audit* coll, int count) {
        this-> coll = coll;
        this->count = count;
    }
    void print() {
        for (int i = 0; i < count; i++) {
            coll[i].print();
        }
    }
};

int main()
{
    setlocale(LC_ALL, "RUS");
    Alex kolosov{ "Koshey",18,"RPO","26.03.2025","nezachet" };
    Audit aud106{ &kolosov, 1 };
    College coll{ &aud106,1 };
    coll.print();
}
