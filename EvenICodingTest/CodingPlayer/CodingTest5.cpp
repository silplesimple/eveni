#include <string>
#include <vector>
#include<bits/stdc++.h>
using namespace std;
	//1. 첫글자를 읽는다. 이 글자를 x라고 한다. ex)"dwdwd"=>x=d;
	//2.이 문자열을 왼쪽에서 오른쪽으로 읽는다. x와 x가 아닌 다른 글자들이 나온 횟수를 각각 센다. 
	// 처음으로 두 횟수가 같아지는 순간 멈추로 지금까지 읽은 문자여을 분리한다 ex) x=1,y=1if(x==y) d[i]. 문자열 분리
	//s에서 분리한 문자열을 빼고 남은 부분에 대해서 이 과정을 반복한다.-> 
	//만약 두 횟수가 다른 상태에서 더이상 읽은 글자가 없다면 역시 지금까지 읽은 문자열을 분리하고 종료하니다.

int solution(string s)
{
	int answer = 0;		
	int f = 0, d = 0;
	char first = ' ';
	for (int i = 0; i < s.size(); i++)
	{		
		if (first == ' ')
		{
			first = s[i];
		}

		if (first == s[i])
		{
			f++;
		}
		else
		{
			d++;
		}

		if (f == d)
		{
			answer++;
			f = 0; d = 0;
			first = ' ';
		}
	}

	if (f != 0)
	{
		answer += 1;
	}
	
	return answer;
	
}

int main()
{
	cout << solution("abracadabra") << '\n';
}