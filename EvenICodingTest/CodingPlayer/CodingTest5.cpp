#include <string>
#include <vector>
#include<bits/stdc++.h>
using namespace std;
	//1. ù���ڸ� �д´�. �� ���ڸ� x��� �Ѵ�. ex)"dwdwd"=>x=d;
	//2.�� ���ڿ��� ���ʿ��� ���������� �д´�. x�� x�� �ƴ� �ٸ� ���ڵ��� ���� Ƚ���� ���� ����. 
	// ó������ �� Ƚ���� �������� ���� ���߷� ���ݱ��� ���� ���ڿ��� �и��Ѵ� ex) x=1,y=1if(x==y) d[i]. ���ڿ� �и�
	//s���� �и��� ���ڿ��� ���� ���� �κп� ���ؼ� �� ������ �ݺ��Ѵ�.-> 
	//���� �� Ƚ���� �ٸ� ���¿��� ���̻� ���� ���ڰ� ���ٸ� ���� ���ݱ��� ���� ���ڿ��� �и��ϰ� �����ϴϴ�.

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