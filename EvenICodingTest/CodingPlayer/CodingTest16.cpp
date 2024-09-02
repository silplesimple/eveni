#include<string>
#include<vector>
#include<bits/stdc++.h>
using namespace std;

string solution(string s)
{
	string answer = "";
	bool inside = false;
	for (auto c : s)
	{
		if (c == ' ')
		{
			answer += ' ';
			inside = false;
		}
		else if (!inside)
		{
			answer += toupper(c);
			inside = true;
		}
		else {
			answer += tolower(c);
		}
	}

	return answer;
}

int main()
{
	cout << solution({ "3people unFollowed me" });
}