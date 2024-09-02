#include<string>
#include<vector>
#include<queue>

using namespace std;


int solution(int n)
{
	int cnt = 1;
	int tmp = 0;
	queue<int> q;

	q.push(0);
	q.push(1);

	while (cnt < n)
	{
		tmp = q.front() + q.back();
		if (tmp > 1234567)tmp -= 1234567;
		q.push(tmp);
		cnt++;
		q.pop();
	}
	return q.back();
	
	
}