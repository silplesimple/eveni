#include <string>
#include<vector>
#include<bits/stdc++.h>

using namespace std;


vector<int> solution(string s)
{
	vector<int> answer(2, 0);
	int zero = 0, round = 0;

	while (s != "1")
	{
		string tmp = "";
		int num;
		round++;

		for (int i = 0; i < s.size(); i++)
		{
			if (s[i] == '0')
			{
				zero++;
			}
			else {
				tmp += "1";
			}
		}

		num = tmp.size();
		s = "";
		while (num > 0)
		{
			s += to_string(num % 2);
			num /= 2;
		}
	}

	answer[0] = round;
	answer[1] = zero;
	return answer;
}

int main()
{
	/*vector<int> result = solution("110010101001");
	for (int i = 0; i < result.size(); i++)
	{
		cout << result[i];
	}*/
	int izin = 7 >> 2;
	int x;
	cout << "Enter Number(Decimal) : ";
	cin >> x;

	cout << "to Binary : ";
	for (int i = 7; i >= 0; i--)
	{
		int temp = (x >> i) & 1;
		cout << temp;
	}
	
}