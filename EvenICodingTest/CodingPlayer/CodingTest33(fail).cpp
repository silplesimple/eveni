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
	cout << "던전 벡터의 크기:" << dungeons.size()<<'\n';
	cout << "---------------------" << '\n';	
	//수를 역정렬
	sort(dungeons.begin(), dungeons.end(),compare);
	for (int i = 0; i < dungeons.size(); i++)
	{
		//0은 최소 필요도 1은 소모 피로도
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

	cout << "코딩테스트 답 : " << answer << '\n';
	cout << "결과 : " << result << '\n';
}