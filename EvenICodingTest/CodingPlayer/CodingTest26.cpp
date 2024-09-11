#include<string>
#include<vector>
#include<iostream>
#include<algorithm>

using namespace std;

int solution(vector<int> citations)
{	
	vector<int> answer(citations.size());
	for (int i = 0; i < citations.size(); i++)
	{
		for (int j = 0; j < citations.size(); j++)
		{
			int inyoung = citations[i];
			if (citations[j] >= citations[i])
			{
				if (inyoung == answer[i])//인용한 회수와 그걸 뛰어넘은 숫자가 똑같을때
				{
					break;
				}
				answer[i]++;				
			}
		}
		
	}
	sort(answer.rbegin(), answer.rend());
	return answer[0];	
}

int main()
{
	cout << solution({ 3,0,6,1,5,4,4 });
}