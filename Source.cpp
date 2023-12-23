
#include <iostream>

using namespace std;

int main()
{
    float a = 12.567;
    int c;

    c = (int)a;
    if ((a - c) >= 0.5) cout << c + 1 << endl; else cout << c << endl;

    return 0;
}