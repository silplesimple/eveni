#include <vector>
#include<iostream>
using namespace std;

vector<long long> solution(vector<long long> numbers)
{
	vector<long long> answer;
	for (long long number : numbers)
	{
		long long bit = 1;
		while ((number & bit) > 0)
		{
			bit <<= 1;
		}
		answer.push_back(number + bit - (bit >> 1));
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
	cout << "°á°ú: ";
	for (int i = 0; i < result.size(); i++)
	{
		cout << result[i] << " ";
	}

}
