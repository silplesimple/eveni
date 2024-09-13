#include<string>
#include<vector>
#include<iostream>
#include<map>

using namespace std;

vector<int> solution(vector<int> progresses, vector<int> speeds)
{
	//프로그램에 배포일을 저장시킬 맵
	map<int, int> progressRelease;
	vector<int>answer;
	vector<int> releaseIndex;
	int firstRelease=0;
	//프로그램에 개발주기 계산식
	for (int i = 0; i < progresses.size(); i++)
	{
		//개발완료일
		int a = 0;
		//100-30 70
		a=100 - progresses[i];
		//7나누기 개발주기
		a =(a/ speeds[i])+(a%speeds[i]==0?0:1);
		//값이 어떻게 될지 모르니 출력
		//cout << "a의 값->" << a<<'\n';		
		//첫번째 개발 일보다 개발 완료 일이 낮다면 첫번째 개발일에 ++
		if (i == 0)
		{
			firstRelease = a;
			releaseIndex.push_back(a);
		}
		if (a <= firstRelease)
		{
			//개발완료일을 첫번째 기능완료일과 같이
			a = firstRelease;			
		}
		else if(a>firstRelease)
		{
			releaseIndex.push_back(a);
		}
		progressRelease[a]++;
		//cout << progressRelease[a] << '\n';
		//개발주기를 	
	
	}

	for (int i = 0; i < progressRelease.size(); i++)
	{
		answer.push_back(progressRelease[releaseIndex[i]]);
	}
	
	return answer;
}

int main()
{
	vector<int> progresses;
	vector<int> speeds;
	vector<int> answer;
	progresses.push_back(93);
	progresses.push_back(30);
	progresses.push_back(55);
	speeds.push_back(1);
	speeds.push_back(30);
	speeds.push_back(5);
	answer = solution(progresses, speeds);
	for (int i = 0; i < answer.size(); i++)
	{
		cout << answer[i] << '\n';
	}
}