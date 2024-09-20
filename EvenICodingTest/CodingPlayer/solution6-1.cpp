#include<string>
#include<vector>
#include<algorithm>
#include<iostream>

using namespace std;

int DP[1000001] = { 0 };
int solution(int x, int y, int n)
{
	int answer = 0;
	
	for (int i = 1; i < 1000001; i++)
	{
		DP[i] = 1000001;
	}
	DP[y] = 0;
	for (int i = y; i > x; i--)
	{
		if (DP[i] != 1000001)
		{
			if (i % 3 == 0)
			{
				DP[i / 3] = min(DP[i / 3], DP[i] + 1);
			}
			if (i % 2 == 0)
			{
				DP[i / 2] = min(DP[i / 2], DP[i] + 1);
			}
			if (i - n > 0)
			{
				DP[i - n] = min(DP[i - n], DP[i] + 1);
			}
		}
	}
	if (DP[x] == 1000001)
	{
		DP[x] = -1;
	}
	answer = DP[x];
	return answer;
}

int main()
{
	int result;	
	result = solution(10, 40, 5);
	cout << "결과" << result << '\n';

	result = solution(10, 40, 30);
	cout << "결과" << result << '\n';
	
}