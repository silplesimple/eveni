#include<bits/stdc++.h>

using namespace std;

const int MX = 100005;
int dat[MX];
int head = 0, tail = 0;

void push(int x)
{
	dat[tail++] = x;	
}

void pop()
{
	head++;
}

int front()
{
	return dat[head];
}

int back()
{
	return dat[tail-1];
}

void test()
{

}
int main()
{
	queue<int> Q;
	Q.push(10);
	Q.push(20);
	Q.push(30);
	cout << Q.size() << '\n';
	if (Q.empty())
	{
		cout << "Q is empty\n";
	}
	else
	{
		cout << "Q is Not empty\n";
	}
	Q.pop();
	cout << Q.front() << '\n';
	cout << Q.back() << '\n';
	Q.push(40);
	Q.pop();
	cout << Q.front() << '\n';
	test();
}