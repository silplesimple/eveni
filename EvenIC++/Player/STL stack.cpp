#include <bits/stdc++.h>
using namespace std;

int main()
{
	stack<int> s;
	s.push(10);
	s.push(20);
	s.push(30);
	cout << s.size() << '\n';
	if (s.empty()) cout << "S is enpty\n";
	else cout << "S is Not empty\n";
	s.pop();
	cout << s.top() << '\n';
	s.pop();
	cout << s.top() << '\n';
	s.pop();
	if (s.empty())cout << "s is empty\n";//s is empty
	cout << s.top() << '\n';//
}