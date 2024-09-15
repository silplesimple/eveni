#include<random>
#include<iostream>

using namespace std;

int main()
{
	random_device rd;	//non-deterministic generator
	mt19937 gen(rd());	//to seed mersenne twister.
						//replace the call to rd() with a
						//constant value to get repeatalbe
						//results.
	for (int i = 0; i < 5; ++i)
	{
		cout << gen() << " ";
	}
	cout << endl;
}