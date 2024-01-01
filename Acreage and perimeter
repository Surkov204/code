#include <iostream>
#include <windows.h>      
#include <math.h>
using namespace std;
void Cacloaitamgiacthuong()
{
    int n;
    int i = 1;
    while (i > 0)
    {
        cout << "0.Tam giac co du do dai 3 canh" << endl;
        cout << "1.Tam giac co do dai hai canh cung goc xen giua" << endl;
        cout << "2.Tam giac co do dai canh day va duong cao" << endl;
        cout << "3.Tam giac ngoai tiep duong trong" << endl;
        cout << "4.Tam giac noi tiep duong tron" << endl;
        cin >> n;
        system("cls");
        if (n == 0)
        {
            int a, b, c;
            float p;
            cout << "Hay nhap chieu dai ba canh " << endl;
            cin >> a;
            cin >> b;
            cin >> c;
            p = (a + b + c) / 2;
            cout << "Dien tich hinh tam giac la" << " " << sqrt(p * (p - a) * (p - b) * (p - c)) << endl;

        }
        else 
            if (n == 1)
             {
                int a,b;
                float c,S;

                cout << "Hay nhap chieu dai cua hai canh a va b" << endl;
                cin >> a;
                cin >> b;
                cout << "Hay nhap so do goc xen giua hai canh a va b" << endl;
                cin >> c;
                S = (1 / 2) * a * b * sin(c);
                cout << "Dien tich tam giac la :" << " " << S << endl;
             }
            else if (n==2)
            {
                int a;
                int h;
                cout << "Hay nhap chieu dai cua chieu cao h "; cin >> h;
                cout << endl;
                cout << "Hay nhap chieu dai cua canh a "; cin >> a;
                cout << "Dien tich la :" << " " << (a * h) * (1 / 2) << endl;

            }
            else if (n == 3)
            {
                int a, b, c,r;
                float p;
                cout << "Hay nhap chieu dai ba canh " << endl;
                cin >> a;
                cin >> b;
                cin >> c;
                cout << "Hay nhap chieu dai cua ban kinh" << endl;
                cin >> r;
                int s = (a + b + c);
                p = s/2;
                cout << "Dien tich tam giac la: " << " " << p * r << endl;
            }
            else if (n == 4)
            {
                int a, b, c, R;
                cout << "Hay nhap chieu dai ba canh " << endl;
                cin >> a;
                cin >> b;
                cin >> c;
                cout << "Hay nhap chieu dai cua ban kinh" << endl;
                cin >> R;
                cout << "Dien tich tam giac la: " << " " << (a*b*c)/4*R << endl;
            }
            else 
            {
                cout << "nhap lai ho cai" << endl;
                Sleep(1000);
                system("cls");
            }
        break;
    }
    
}
void CacLoaitamgiac()
{
    int n;
    int i = 1;
    while (i > 0)
    {
        cout << "0.Tam giac vuong" << endl;
        cout << "1.Tam giac can" << endl;
        cout << "2.tam giac deu" << endl;
        cout << "3.Tam giac thuong" << endl;
        cin >> n;
        system("cls");
        if (n == 0)
        {
            int a;
            int b;
            float c;
            cout << "Hay nhap chieu dai cua canh goc vuong a" << endl; cin >> a;
            cout << endl;
            cout << "Hay nhap chieu dai cua canh goc vuong b" << endl; cin >> b;
            c = (a * b) / 2;
               
            cout << "Dien tich la tam giac vuong :" << " " << c << endl;
        }
        else

          if (n == 1)
          {
            int a;
            int h;
            cout << "Hay nhap chieu dai cua chieu cao h "; cin >> h;
            cout << endl;
            cout << "Hay nhap chieu dai cua canh a "; cin >> a;
            cout << "Dien tich la :" << " " << (a * h) * 2 << endl;
          }
        else

          if (n==2)
          {
              int a;
              cout << "Hay nhap chieu dai canh a" << endl;
              cin >> a;
              cout << "Dien tich tam giac deu la :" << " " << ((a * a) * sqrt(3)) / 4 << endl;

          }
          else 
              if (n == 3)
              {
                  Cacloaitamgiacthuong();
              }
              else {
                  cout << "nhap lai ho cai" << endl;
                  Sleep(1000);
                  system("cls");
              }
        break;
         
    }

}

void ChuViCacHinh()
{
    int n;
    int i = 1;
    while (i > 0)
    {
   
        cout << "0.Chu vi hinh tam giac" << endl;
        cout << "1.Chu vi hinh chu nhat" << endl;
        cout << "2.Chu vi hinh vuong" << endl;
        cout << "3.Chu vi hinh tron" << endl;
        cin >> n;
        system("cls");
        if (n == 0)
        {
            int a, b, c;
            cout << " nhap chieu dai ba canh" << endl;
            cin >> a;
            cin >> b;
            cin >> c;
            cout << " Chu vi tam giac cua ban la: " << a + b + c << endl;
            break;
        } else
        if (n == 1)
        {
            int a, b;
            cout << "nhap chieu dai: ";  cin >> a;
            cout<<endl;
            cout << "nhap chieu rong: ";  cin >> b;
            cout << "Chu vi hinh chu nhat la :" << (a + b) * 2 << endl;
            break;
        } else
        if (n == 2)
        {
            cout << "Hay Nhap de tinh chu vinh" << endl;
            int a;
            cout << "nhap do dai canh: ";  cin >> a;
            cout << "Chu vi hinh chu nhat la :" << a*4 << endl;
            break;
        } else
        if (n == 3)
        {
            cout << "Hay Nhap de tinh chu vinh" << endl;
            float R;
            float C;
            cout << "Nhap do dai cua ban kinh: "; cin >> R;
            C = (R * 2) * 3.14;
            cout << "Chu vi hinh tron la: " << C << endl;
            break;
        }
        else {
            cout << "nhap lai ho cai" << endl;
            Sleep(1000);
            system("cls");
        }
        break;
    }
    
}
void DienTichCacHinh()
{
    int n;
    int i = 1;
    while (i > 0)
    {

        cout << "0.Dien tich hinh tam giac" << endl;
        cout << "1.Dien tich hinh chu nhat" << endl;
        cout << "2.Dien tich hinh vuong" << endl;
        cout << "3.Dien tich hinh tron" << endl;
        cin >> n;
        system("cls");
        if (n == 0)
        {
            CacLoaitamgiac();
            break;
        }
        else
            if (n == 1)
            {
                int a, b;
                cout << "Hay Nhap de tinh dien tich" << endl;
                cout << "Nhap chieu dai canh a" << endl;
                cin >> a;
                cout << " Nhap chieu dai canh b" << endl;
                cin >> b;
                cout << "dien tich hinh chu nhat la" << " " << a*b << endl;


                break;
            }
            else
                if (n == 2)
                {
                    int a;
                    cout << "Hay Nhap de tinh dien tich" << endl;
                    cout << "Nhap chieu dai canh hinh vuong" << endl;
                    cin >> a;
                    cout << "dien tich hinh vuong nhat la" << " " << a * a << endl;
                    break;
                }
                else
                    if (n == 3)
                    {
                        float c;
                        int r;
                        cout << "Hay Nhap de tinh dien tich" << endl;
                        cout << " Nhap chieu dai cua ban kinh " << endl;
                        cin >> r;
                        cout << "dien tich tron la " << " " << r * r * 3.14 << endl;
                        break;
                    }
                    else
                    {
                        cout << "Nhap lai" << endl;
                        system("cls");
                    }
    }

}


int main()
{
    int n;
    int i = 1;
    while (i > 0) {
        cout << "0.Chu Vi Cac hinh" << endl;
        cout << "1.Dien tich cac hinh" << endl;
        cin >>n;
        if (n == 0) {

            system("cls");
            ChuViCacHinh();
            break;
        }
        else
        if (n == 1)
                  {
            system("cls");
            DienTichCacHinh();
            break;
        }
        else      {
            cout << "nhap lai ho cai" << endl;
            Sleep(1000);
            system("cls");
        }
  }
   
    return 0;
}
