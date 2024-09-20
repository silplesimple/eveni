#include<string>
#include<vector>
#include<queue>

using namespace std;

int solution(int x, int y, int n)
{
	queue<pair<int, int>> q;
	q.push(make_pair(y, 0));

	while (!q.empty())
	{
		int val = q.front().first;
		int count = q.front().second;
		q.pop();

		if (val == x)
		{
			return count;
		}

		if (val % 2 == 0)
		{
			q.push(make_pair(val / 2, count + 1));
		}

		if (val % 3 == 0)
		{
			q.push(make_pair(val / 3, count + 1));
		}

		if (val - n > 0)
		{
			q.push(make_pair(val - n, count + 1));
		}
	}	

	return -1;
}