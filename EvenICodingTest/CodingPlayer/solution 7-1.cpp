#include <string>
#include <vector>
#include<iostream>
using namespace std;

vector<long long> solution(vector<long long> numbers)
{
	vector<long long> answer;
	for (int i = 0; i < numbers.size(); ++i)
	{
		if (numbers[i] % 2 == 0)
		{
			answer.push_back(numbers[i] + 1);
		}
		else 
		{
			long long bit = 1;
			//가장 오른쪽부터 차례로 n 개의 연속된 1로 이루어진 비트 구하기		
			while (true)
			{
				if ((numbers[i] & bit) == 0)
				{
					break;
				}
				bit *= 2;
			}
			bit = bit / 2;
			answer.push_back(numbers[i] + bit);
		}
	}
	return answer;
}



int main()
{
	vector<long long> numbers(0);
	vector<long long> result;
	numbers.push_back(2);
	numbers.push_back(7);
	result = solution(numbers);
	cout << "결과: ";
	for (int i = 0; i < result.size(); i++)
	{
		cout << result[i] << " ";
	}

	
}