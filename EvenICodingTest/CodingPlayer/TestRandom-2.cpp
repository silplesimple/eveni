#include<iomanip>
#include<iostream>
#include<map>
#include<random>

using namespace std;

int main()
{
	random_device rd;
	mt19937 gen(rd());
	normal_distribution<double> dist(/* 평균= */0,/* 표준 편차 = */1);

	map<int, int>hist{};
	for (int n = 0; n < 10000; ++n)
	{
		++hist[round(dist(gen))];
	}
	for (auto p : hist)
	{
		cout << setw(2) << p.first << ' '
			<< string(p.second / 100, '*') << " " << p.second << '\n';
	}


}