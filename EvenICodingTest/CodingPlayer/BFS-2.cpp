#include<bits/stdc++.h>

using namespace std;

int main()
{
	pair<int, int>t1 = make_pair(10, 13);
	pair<int, int>t2 = make_pair(13, 10);
	
	cout << "ù����" << t1.first << '\n';
	cout << "�ι�°" << t1.second << '\n';

	t1.swap(t2);

	cout << "t1ù����" << t1.first << '\n';
	cout << "t1�ι���" << t1.second << '\n';
	cout << "t2ù��°" << t2.first << '\n';
	cout << "t2�ι���" << t2.second << '\n';
}