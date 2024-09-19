#include <string>
#include<vector>
#include<iostream>

using namespace std;

vector<int> solution(vector<int> numbers)
{
	//자신보다 뒤에있는 원소인데 
	//그거중에 제일 가까이
	//뒷큰수가 없으면 -1
	//제일가까이 까지 탐색 하고 종료
	vector<int> answer(numbers.size());
	int answerIndex = 0;
	int answerIndex2 = 0;
	
	for (int i = 0; i < numbers.size(); i++)
	{
		for (int j = i+1; j <= numbers.size(); j++)
		{		
			answer[answerIndex] = -1;
			if (j == numbers.size())
			{
				answer[answerIndex] = -1;
				answerIndex++;
				break;
			}
			if (numbers[i] < numbers[j])
			{
				//0
				answer[answerIndex] = numbers[j];
				answerIndex++;
				break;
			}
		}		
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
		cout<<result[i]<<'\n';
	}

	numbers = InputNumbers({ 9,1,5,3,6,2 });

	result = solution(numbers);

	for (int i = 0; i < result.size(); i++)
	{
		cout << result[i] << '\n';
	}
}