#include <string>
#include<vector>
#include<random>
#include<iostream>
#include<algorithm>
#define MAX 8

using namespace std;

bool compare(vector<int> i, vector<int> j)
{
	return j < i;
}
int solution(int k, vector<vector<int>> dungeons)
{
	int answer = 3;
	cout << "���� ������ ũ��:" << dungeons.size()<<'\n';
	cout << "---------------------" << '\n';	
	//���� ������
	sort(dungeons.begin(), dungeons.end(),compare);
	for (int i = 0; i < dungeons.size(); i++)
	{
		//0�� �ּ� �ʿ䵵 1�� �Ҹ� �Ƿε�
		for (int j = 0; j < dungeons[i].size(); j++)
		{
			cout << dungeons[i][j]<<'\n';
		}
	}
	return answer;
}

int main()
{
	int result;
	int answer=3;
	int k;	
	vector<vector<int>> dungeons;
	vector<int> dungeon;	
	k = 80;	
	dungeons.push_back({80,20});
	dungeons.push_back({ 50,40 });
	dungeons.push_back({ 30,10 });
	result = solution(80, dungeons);

	cout << "�ڵ��׽�Ʈ �� : " << answer << '\n';
	cout << "��� : " << result << '\n';
}