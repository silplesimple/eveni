#include<iostream>
using namespace std;

int main()
{
	int count = 10;
	int& countRef = count;
	auto myAuto = countRef;
	
	countRef = 11;
	cout << count << " ";

	myAuto = 12;
	cout << count << '\n';
	cout << myAuto << endl;

	//�ڷ���->std::initializer_list<int>
	auto A = { 1,2 };

	//�ڷ���->std::initializer_list<int>
	auto B = { 3 };

	//�ڷ���-> int C 
	auto C{ 4 };

	//�ڷ��� �߷� �Ұ�->{int,float};
	//auto D = { 5,6.7 };

	//error
	//auto E{ 8,9 };
}