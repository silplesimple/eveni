#include<string>
#include<vector>
#include<iostream>
#include<queue>

using namespace std;
priority_queue<int> pq;
queue<pair<int, int>> q;
int solution(vector<int> priorities, int location)
{
	int answer = 0;
	for (int i = 0; i < priorities.size(); i++)
	{
		q.push({ i,priorities[i] });
		pq.push(priorities[i]);
	}
	
	int cnt = 1;
	while (1)
	{
		pair<int, int> qfront = q.front();
		q.pop();

		if (qfront.second == pq.top())
		{
			if (qfront.first == location)
			{
				answer = cnt;
				break;
			}
			else
			{
				pq.pop();
				cnt++;
			}
		}
		else if (qfront.second != pq.top())
		{
			q.push({ qfront.first,qfront.second });
		}
	}
	return answer;
}

int main()
{
	//타협ㄴㄴ
	vector<int> priorities;
	int location;
	int answer;
	priorities.push_back(2);
	priorities.push_back(1); 
	priorities.push_back(3);
	priorities.push_back(2);
	location = 2;
	answer = solution(priorities, location);
	cout << answer << '\n';
	
	
	//모르는거 출력
	//숫자 출력 //값입력//기능 구현// 기능 출력
}