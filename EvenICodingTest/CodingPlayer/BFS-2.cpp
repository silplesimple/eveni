#include<bits/stdc++.h>

using namespace std;

int main()
{
	pair<int, int>t1 = make_pair(10, 13);
	pair<int, int>t2 = make_pair(13, 10);
	
	cout << "첫번쨰" << t1.first << '\n';
	cout << "두번째" << t1.second << '\n';

	t1.swap(t2);

	cout << "t1첫번쨰" << t1.first << '\n';
	cout << "t1두번쨰" << t1.second << '\n';
	cout << "t2첫번째" << t2.first << '\n';
	cout << "t2두번쨰" << t2.second << '\n';
}