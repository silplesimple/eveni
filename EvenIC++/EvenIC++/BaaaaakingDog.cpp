//#include <iostream>
//using namespace std;
//
//void func1()//char가 최대수인 127를 넘어서 127에서 128를 더할때 -128이 되서 Integer Overflow가 일어남
//{
//	for (char s = 0; s < 128; s++)
//	{
//		cout << "hi";
//	}
//}
//
//int func2()
//{
//	int r = 1;
//	int a = 0;
//	for (int i = 1; i <= 50; i++)
//	{
//		a = r * i;
//		r = a % 61;
//	}
//	return r;
//}
//int func3()
//{
//	int a = 1;
//	int mod = 1000000007;
//	for (int i = 0; i <= 10; i++)
//		a = (long long)10*a% mod;
//	return a;
//}
//int main()
//{
//	//func1();
//	/*cout << func2();*/
//	//cout << func3();
//	/*if (0.1 + 0.1 + 0.1 == 0.3)cout << true;
//	else cout << "no no....";*/
//	/*double a = 10000000000000000001;
//	double b = 10000000000000000000;
//	if (a == b)cout << "wow..";
//	else cout << "a != b";*/
//	double a = 0.1 + 0.1 + 0.1;
//	double b = 0.3;
//	if (a == b) cout << "same 1\n";
//	if (abs(a - b) < 1e9)cout << "same 2\n";
//}