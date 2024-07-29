using namespace std;
#include <iostream>
#include <vector>
#pragma warning(disable:4996)
//vector<int> func1(vector<int>v)
//{
//	v[10] = 7;
//	return v;
//}
//
//bool cmp1(vector<int> v1, vector<int> v2, int idx)
//{
//	return v1[idx] > v2[idx];
//}
//
//bool cmp2(vector<int>& v1, vector<int>& v2, int idx)
//{
//	return v1[idx] > v2[idx];
//}
int main(void)
{
	//vector<int> v(100);
	//vector<int> v1(100);
	///*func1(v);
	//cout << v[10];*/
	//v[10] = 5;
	//v1[10] = 4;
	//cout<< cmp2(v, v1, 10);	
	/*string s = "baaaaaarkingdog";
	printf("s is %s\n", s);*/
	/*char a[10];	
	printf("input : ");
	scanf_s("%s", &a,5);
	string s(a);
	printf("a is %s\n", a);
	printf("a is %s\n", s.c_str());*/
	/*cout << "11111\n";
	printf("22222\n");
	cout << "33333\n";*/
	std::ios::sync_with_stdio(false);
	std::cin.tie(nullptr);
	int n, x;
	std::cin >> n >> x;
	int* a = new int[n];
	for (int i = 0; i < n; i++)
	{
		std::cin >> a[i];
	}
	for (int i = 0; i < n; i++)
	{
		if (a[i] < x)std::cout << a[i] << ' ';
	}
	delete[] a;
}