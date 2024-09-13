#include<string>
#include<vector>
#include<map>
#include<iostream>

using namespace std;

//std::map<std::string,int> wantMap
map<string, int> wantMap;

bool check(map<string, int> m)
{
	for (auto u : wantMap)
	{
		if (m.find(u.first) == m.end())
		{
			return false;
		}
		else if (m[u.first] != u.second)
		{
			return false;
		}
	}
	return true;
}

int solution(vector<string> want, vector<int> number,
	vector<string>discount)
{
	int answer = 0;

	for (int i = 0; i < want.size(); i++)
	{
		wantMap[want[i]] = number[i];
	}
	
	for (int i = 0; i <= discount.size() - 10; i++)
	{
		map<string, int>m;
		for (int j = i; j < i + 10; j++)
		{
			m[discount[j]]++;
		}
		answer += check(m);
		m.clear();
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
	int answer = solution(want,number,discount);
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