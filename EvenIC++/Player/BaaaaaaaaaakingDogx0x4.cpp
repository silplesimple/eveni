#include<iostream>
#include<bits/stdc++.h>
using namespace std;
const int MX = 1000005;
int dat[MX], pre[MX], nxt[MX];
int unused = 1;

void insert(int addr, int num)
{	
	dat[unused] = num;//10
	pre[unused] = addr;
	nxt[unused] = nxt[addr];
	if (nxt[addr] != -1)
	{
		pre[nxt[addr]] = unused;
	}
	nxt[addr] = unused;
	unused++;
}

void erase(int addr)
{
	nxt[pre[addr]] = nxt[addr];
	if (nxt[addr] != -1)
	{
		pre[nxt[addr]] = pre[addr];
	}
}

void traverse()
{
	int cur = nxt[0];
	while (cur != -1)
	{
		cout << dat[cur] << ' ';
		cur = nxt[cur];
	}
	cout << "\n\n";
}

void insert_test()
{
	cout << "***** insert_test *****\n";
	insert(0, 10);// 10(address=1)
	traverse(); 
}
void erase_test()
{
	cout << "***** erase_test*****\n";
	erase(1);
	traverse();
}
int main(void)
{
	fill(pre, pre + MX, -1);
	fill(nxt, nxt + MX, -1);
	insert_test();
	erase_test();
}