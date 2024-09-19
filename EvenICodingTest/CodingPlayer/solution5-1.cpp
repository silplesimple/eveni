#include<string>
#include<vector>
#include<iostream>
#include<map>

using namespace std;
void printMap(int topingNumber,int topingCount,string broName)
{	
	cout << broName + "이(가) 먹은 토핑의 번호:" << topingNumber
		<< "토핑의 개수: " << topingCount << '\n';
}
int solution(vector<int> topping)
{
	int answer = 0;
	map<int, int> bro1;
	map<int, int> bro2;

	for (int i = 0; i < topping.size(); i++)
	{
		bro2[topping[i]]++;
	}

	for (int i = 0; i < topping.size(); i++)
	{
		bro2[topping[i]]--;
		bro1[topping[i]]++;

		if (bro2[topping[i]] == 0)
		{
			bro2.erase(topping[i]);
		}

		if (bro1.size() == bro2.size())
		{
			++answer;
		}
	}
	return answer;
}

vector<int> InputTopping(vector<int> input)
{
	vector<int> n;
	for (int i = 0; i < input.size(); i++)
	{
		n.push_back(input[i]);
	}

	return n;
}

int main()
{
	int result = 0;
	vector<int> topping;
	topping=InputTopping({ 1,2,1,3,1,4,1,2 });
	result = solution(topping);

	cout << "결과" << result << '\n';
}