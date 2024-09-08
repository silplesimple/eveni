#include<string>
#include<vector>
#include<bits/stdc++.h>
using namespace std;

long long solution(int n)
{
	long long answer = 0;//[4]
	int n2 = 2, n3 = 3;

	if (n <= 3)return n;
	for (int i = 4; i <= n; ++i)
	{
		answer = (n2 + n3) % 1234567;
		n2 = n3;
		n3 = answer;
	}	
	return answer;
}

int main()
{
	cout << solution(4)<<'\n';
	cout << solution(5);
}