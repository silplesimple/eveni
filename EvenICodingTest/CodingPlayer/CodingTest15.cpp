#include<string>
#include<vector>
#include<algorithm>
#include<bits/stdc++.h>
using namespace std;

string solution(string s)
{
	string answer = "";
	string sTemp = "";
	vector<int>vecInteger;

	for (int i = 0; i < s.size(); i++)
	{
		if (s[i] == ' ')
		{
			vecInteger.push_back(stoi(sTemp));
			sTemp.clear();
			continue;
		}

		sTemp += s[i];
	}

	vecInteger.push_back(stoi(sTemp));

	sort(vecInteger.begin(), vecInteger.end());

	answer += to_string(vecInteger.front());
	answer += ' ';
	answer += to_string(vecInteger.back());

	return answer;
}

int main()
{
	cout << solution("1 2 3 4");
}