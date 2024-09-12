#include<string>
#include<vector>
#include<iostream>

using namespace std;

vector<int>solution(int n, long long left, long right)
{
	vector<vector<long long>> answer(n,vector<long long>(n,0));
	vector<long long> temp(n * n,0);
	vector<int> result(right-left+1);
	int tempIndex = 0;
	for (long long i = 0; i < n; i++)
	{
		for (long long j = 0; j < n; j++)
		{
			if (i <= j)
			{
				answer[i][j] = j + 1;
				temp[tempIndex] = answer[i][j];
				tempIndex++;
			}
			else if (j <= i)
			{
				answer[i][j]=i + 1;
				temp[tempIndex] = answer[i][j];
				tempIndex++;
			}			
		}		
	}
	for (int i = 0; i < result.size(); i++)
	{
		result[i] = temp[i + left];
	}	
	
	return result;
}

int main()
{
	vector<int> answer;
	answer = solution(3, 2, 5);
	for (int i = 0; i < answer.size(); i++)
	{
		cout << answer[i] << '\n';
	}
}