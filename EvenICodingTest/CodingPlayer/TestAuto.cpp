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

	//자료형->std::initializer_list<int>
	auto A = { 1,2 };

	//자료형->std::initializer_list<int>
	auto B = { 3 };

	//자료형-> int C 
	auto C{ 4 };

	//자료형 추론 불과->{int,float};
	//auto D = { 5,6.7 };

	//error
	//auto E{ 8,9 };
}