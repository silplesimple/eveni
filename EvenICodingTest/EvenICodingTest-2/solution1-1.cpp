#include<string>
#include<vector>
#include<algorithm>
#include<iostream>
#include<cmath>

using namespace std;

bool isPrime(long long num)
{
	if (num < 2)return false;

	for (int i = 2; i <= sqrt(num); ++i)
	{
		if (num % i == 0)
		{
			cout << "여기 출력 " << num % i<<'\n';
			return false;
		}
	}
	return true;
}

int solution(int n, int k)
{
	int answer = 0;
	vector<pair<string, int>> v;
	//진수 변환
	string s = "";
	while (n > 0)
	{
		s += to_string(n % k);
		n /= k;
	}
	reverse(s.begin(), s.end());
	cout << s << '\n';
	string tmp = "";
	for (char c : s)
	{
		if (c == '0')
		{
			if (!tmp.empty() && isPrime(stoll(tmp)))
			{
				answer++;
			}
			tmp = "";
		}
		else tmp += c;
	}

	if (!tmp.empty() && isPrime(stoll(tmp)))
	{
		answer++;
	}

	return answer;
}

int main()
{
	int n = 0;
	int k = 0;
	int answer;
	n = 437674;
	k = 3;
	answer = solution(n,k);
	cout << "첫번째 답" << answer<<'\n';
	n = 110011;
	k = 10;
	answer = solution(n, k);
	cout << "두번째 답" << answer << '\n';
}