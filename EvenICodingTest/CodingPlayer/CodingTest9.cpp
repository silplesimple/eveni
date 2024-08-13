#include <string>
#include <vector>
#include <map>
#include <bits/stdc++.h>
using namespace std;

string Solution(vector<string> survey, vector<int> choices)
{
	string answer = "";
	
	map<char, int> m;
	for (int i = 0; i < choices.size(); i++)
	{
		int choice = choices[i];

		if (choice < 4)
		{
			m[survey[i][0]] += 4 - choice;
		}
		else
		{
			m[survey[i][1]] += choice - 4;
		}
	}

	answer += (m['R'] >= m['T'] ? "R" : "T");
	answer += (m['C'] >= m['F'] ? "C" : "F");
	answer += (m['J'] >= m['M'] ? "J" : "M");
	answer += (m['A'] >= m['N'] ? "A" : "N");
	return answer;
}

int main()
{
	string coutString = Solution({ "AN","CF","MJ","RT","NA" }, { 5,3,2,7,5 });
	cout << coutString << '\n';
}