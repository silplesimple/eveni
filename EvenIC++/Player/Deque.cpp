#include <bits/stdc++.h>
using namespace std;
const int MX = 100005;
int dat[2 * MX + 1];
int head = MX, tail = MX;

void Push_front(int x)
{
	dat[--head] = x;
	
}
void Push_back(int x)
{	
	dat[tail++] = x;
}
void Pop_front()
{
	head++;
}
void Pop_back()
{
	tail--;
}
int front()
{
	return dat[head];
}
int back()
{
	return dat[tail];
}
void test()
{

}
int main()
{

}