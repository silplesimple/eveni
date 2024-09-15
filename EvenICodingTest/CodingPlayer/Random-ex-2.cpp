#include<algorithm>
#include<array>
#include<iostream>
#include<random>
#include<string>
#include<vector>
#include<functional> //ref()

using namespace std;
template <typename C>void print(const C& c)
{
	for (const auto& e : c)
	{
		cout <<  e << " ";
	}

	cout << endl;
}

template <class URNG>
void test(URNG& urng)
{
	//Uniform distribution used with a vector
	//Distribution is [-5,5] inclusive
	uniform_int_distribution<int> dist(-5, 5);
	vector<int> v;

	for (int i = 0; i < 20; ++i)
	{
		v.push_back(dist(urng));
	}

	cout << "Randomize vector : ";
	print(v);

	array<string, 26> arr = { {"H","He","Li","Be","B","C","N","O","F",
		"Ne","Na","Mg","Al","Si","P","S","Cl","Ar","K","Ca","Sc",
		"Ti","V","Cr","Mn","Fe"} };

	shuffle(arr.begin(), arr.end(), urng);

	cout << "Randomized array :";
	print(arr);
	cout << "--" << endl;
}

int main()
{
	// First run:non-seedable, non-deterministic URNG random_device
	// Slower but crypto-secure ans non-repeatable.
	random_device rd;
	random_device doume;
	cout << "using random_device URNG:" << endl;
	test(rd);
}