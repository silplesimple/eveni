#include<string>
#include<vector>

using namespace std;

int dp[1000001];

int solution(int x, int y, int n)
{
	int answer = 0;
	fill(dp, dp + 1000001, 10000000);
	dp[x] = 0;

	for (int i = x; i <= y; i++)
	{
		if (i + n <= y)
		{
			dp[i + n] = min(dp[i + n], dp[i] + 1);
		}
		if (i * 2 <= y)
		{
			dp[i * 2] = min(dp[i * 2], dp[i] + 1);
		}
		if (i * 3 <= y)
		{
			dp[i * 3] = min(dp[i * 3], dp[i] + 1);
		}
	}
	answer = dp[y];
	if (answer == 10000000)
	{
		answer = -1;
	}
	return answer;
}