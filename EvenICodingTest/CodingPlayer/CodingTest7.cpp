#include <string>
#include <vector>
#include <bits/stdc++.h>
#include <algorithm>
using namespace std;

bool is_skip(char c, string skip)
{
	for (int i = 0; i < skip.size(); i++)
	{
		if (c == skip[i])
		{
			return true;
		}
	}
		return false;
}
string solution(string s, string skip, int index)//
{
	string answer = "";
	for (int i = 0; i < s.size(); i++)
	{
		char c = s[i];
		for (int j = 0; j < index;)
		{
			c += 1;
			if (c == 'z' + 1)
			{
				c = 'a';
			}
			if (!is_skip(c, skip))
			{
				j++;
			}
		}
		answer.push_back(c);
	}
	return answer;
}
int main()
{
	cout << solution("aukks","wbqd",5) << '\n';
}