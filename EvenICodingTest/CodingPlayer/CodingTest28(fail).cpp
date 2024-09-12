#include<string>
#include<vector>
#include<iostream>
using namespace std;

vector<vector<int>> solution(vector<vector<int>> arr1,
	vector<vector<int>> arr2)
{
	vector<vector<int>> answer(arr1.size(), vector<int>(arr1[0].size(),0));
	
	
	for (int i = 0; i < answer.size(); i++)
	{
		for (int j = 0; j < answer[i].size(); j++)
		{			
			answer[i][j] = Mulitply(arr1[i][j], arr2[i][j]);
		}
	}

	return answer;
}
int Mulitply(int val1, int val2)
{
	int result = 0;
	result = val1 * val2;
	return result;	
}
int main()
{
	vector<vector<int>> answer;
	vector<vector<int>> arr1;
	vector<vector<int>> arr2;
	arr1.push_back({ 1,4 });
	arr1.push_back({ 3,2 });
	arr1.push_back({ 4,1 });
	arr2.push_back({ 3,3 });
	arr2.push_back({ 3,3 });
	arr2.push_back({ 3,3 });
	answer = solution(arr1, arr2);
	for (int i = 0; i < answer.size(); i++)
	{
		for (int j = 0; j < answer[i].size(); j++)
		{
			cout << answer[i][j] << '\n';
		}		
	}
}