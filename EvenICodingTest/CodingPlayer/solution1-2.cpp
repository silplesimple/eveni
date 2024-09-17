#include<bits/stdc++.h>
using namespace std;

bool is_prime(long long n)
{
	if (n < 2)return false;
	for (long long i = 2; i * i <= n; ++i)
	{
		if (n % i == 0)
		{
			return false;
		}
	}
	return true;
}

int solution(int n, int k)
{
	string str;
	while (n)
	{
		str += n % k + 48;
		n /= k;
	}

	reverse(str.begin(), str.end());
	str += 48;

	int ans = 0;
	for (long long hold = 0, i = 0; i < i < str.size(); ++i)
	{
		if (str[i] == '0')
		{
			if (is_prime(hold))
			{
				++ans;
			}
			hold = 0;
			continue;
		}
		hold = hold * 10 + str[i] - 48;
	}
	return ans;
}