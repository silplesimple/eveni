#include<string>
#include<vector>
#include<map>
#include<iostream>

using namespace std;

int solution(vector<string> want, vector<int> number, vector<string> discount)
{
	int answer = 0;
	map<string, int> m;
	for (int i = 0; i < 9; i++)m[discount[i]]++;
	for (int i = 9; i < discount.size(); i++)
	{
		m[discount[i]]++;
		bool flag = true;
		for (int j = 0; j < want.size(); j++)
		{
			if (m[want[j]] != number[j])
			{
				flag = false;
				break;
			}
		}
		if (flag == true)
		{
			answer++;
		}
		m[discount[i - 9]]--;
	}
	return answer;

}

int main()
{
	vector<string> want;
	want.push_back("banana");
	want.push_back("apple");
	want.push_back("rice");
	want.push_back("pork");
	want.push_back("pot");
	vector<int> number;
	number.push_back(3);
	number.push_back(2);
	number.push_back(2);
	number.push_back(2);
	number.push_back(1);
	vector<string> discount;
	discount.push_back("chicken");
	discount.push_back("apple");
	discount.push_back("apple");
	discount.push_back("banana");
	discount.push_back("rice");
	discount.push_back("apple");
	discount.push_back("pork");
	discount.push_back("banana");
	discount.push_back("pork");
	discount.push_back("rice");
	discount.push_back("pot");
	discount.push_back("banana");
	discount.push_back("apple");
	discount.push_back("banana");
	int answer = solution(want, number, discount);
	cout << answer;
	/*for (int i = 0; i < number.size(); i++)
	{
		cout<<number[i]<<'\n';
	}*/
	/*for (int i = 0; i < want.size(); i++)
	{
		cout << want[i] << '\n';
	}*/
}