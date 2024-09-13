#include<string>
#include<vector>
#include<iostream>
#include<map>

using namespace std;

vector<int> solution(vector<int> progresses, vector<int> speeds)
{
	//���α׷��� �������� �����ų ��
	map<int, int> progressRelease;
	vector<int>answer;
	vector<int> releaseIndex;
	int firstRelease=0;
	//���α׷��� �����ֱ� ����
	for (int i = 0; i < progresses.size(); i++)
	{
		//���߿Ϸ���
		int a = 0;
		//100-30 70
		a=100 - progresses[i];
		//7������ �����ֱ�
		a =(a/ speeds[i])+(a%speeds[i]==0?0:1);
		//���� ��� ���� �𸣴� ���
		//cout << "a�� ��->" << a<<'\n';		
		//ù��° ���� �Ϻ��� ���� �Ϸ� ���� ���ٸ� ù��° �����Ͽ� ++
		if (i == 0)
		{
			firstRelease = a;
			releaseIndex.push_back(a);
		}
		if (a <= firstRelease)
		{
			//���߿Ϸ����� ù��° ��ɿϷ��ϰ� ����
			a = firstRelease;			
		}
		else if(a>firstRelease)
		{
			releaseIndex.push_back(a);
		}
		progressRelease[a]++;
		//cout << progressRelease[a] << '\n';
		//�����ֱ⸦ 	
	
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