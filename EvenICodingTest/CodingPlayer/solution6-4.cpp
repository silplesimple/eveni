#include<string>
#include<vector>
#include<queue>

using namespace std;

int bfs(int x, int y, int n)
{
	if (x == y)
	{
		return 0;
	}
	vector<bool>visited(y + 1, false);

	queue<int> q;
	q.push(x);
	int depth = 1;

	while (!q.empty())
	{
		int size = q.size();
		for (int i = 0; i < size; i++)
		{
			int now = q.front();
			q.pop();

			visited[now] = true;

			int plus = now + n;
			int x2 = now * 2;
			int x3 = now * 3;

			if (plus == y || x2 == y || x3 == y)
			{
				return depth;
			}

			if (plus < y && !visited[plus])
			{
				q.push(plus);
			}
			if (x2 < y && !visited[x2])
			{
				q.push(x2);
			}
			if (x3 < y && !visited[x3])
			{
				q.push(x3);
			}
		}
		depth++;
	}

	return -1;
}

int solution(int x, int y, int n)
{
	int answer = 0;
	answer = bfs(x, y, n);

	return answer;
}