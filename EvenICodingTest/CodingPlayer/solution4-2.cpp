#include<string>
#include<vector>
#include<stack>
#include<iostream>

using namespace std;

vector<int> solution(vector<int> numbers)
{
	vector<int> answer(numbers.size());
	stack<int> stk;

	for (int i = numbers.size() - 1; i >= 0; i--)
	{
		while (1)
		{
			if (stk.empty())
			{
				answer[i] = -1;
				break;
			}
			if (stk.top() > numbers[i])
			{
				answer[i] = stk.top();
				break;
			}
			stk.pop();
		}
		stk.push(numbers[i]);
	}
	return answer;
}

vector<int> InputNumbers(vector<int> input)
{
	vector<int> a;
	for (int i = 0; i < input.size(); i++)
	{
		a.push_back(input[i]);
	}
	return a;
}

int main()
{
	vector<int> numbers;
	vector<int> result;

	numbers = InputNumbers({ 2,3,3,5 });

	result = solution(numbers);

	for (int i = 0; i < result.size(); i++)
	{
		cout << result[i] << '\n';
	}

	numbers = InputNumbers({ 9,1,5,3,6,2 });

	result = solution(numbers);

	for (int i = 0; i < result.size(); i++)
	{
		cout << result[i] << '\n';
	}
}