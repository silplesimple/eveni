#include<string>
#include<vector>
#include<iostream>
#include<algorithm>
#include<sstream>

using namespace std;


vector<int> solution(vector<string> maps)
{
	vector<int> answer;
	stringstream ss;
	int vectorIndex;
	
	cout << "테스트 입니당!" << '\n';
	//if(==(숫자가 있으면)
	for (int i = 0; i < maps.size(); i++)
	{
		cout << maps[i] << '\n';
		for (int j = 0; j < maps[i].size(); j++)
		{
			if (maps[i][j] > 48 && maps[i][j] < 58)
			{
				ss maps[i][j];
				ss >> vectorIndex;
				answer.push_back(vectorIndex);				
			}
		}
	}

	return answer;
}

int main()
{
	vector<int> result;
	vector<string> maps;
	
	maps = { "X591X","X1X5X","X231X","1XXX1" };

	result = solution(maps);
	
	cout << "결과: " << '\t';
	for (int i = 0; i < result.size() ; i++)
	{
		cout << result[i] << ' ';
	}
	
}