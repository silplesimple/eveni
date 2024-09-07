#include<string>
#include<vector>
#include<iostream>
using namespace std;

int solution(vector<int> arr)
{
	int answer = 0;
	int first = 0;
	int second = 0;
	int i = 0;
	first = arr[i];
	second = arr[i + 1];
	while (first!=second)
	{
		
		if (first<second)
		{
			first += arr[i];
		}
		else if (first>second)
		{
			second += arr[i + 1];
		}
		
		if (first == second )
		{
			arr[i] = first;
			arr[i + 1] = second;
			i++;			
			first = arr[i];
			if (i < arr.size()-1)
			{
				second = arr[i + 1];
			}
		}
	}
	answer = second;
	return answer;
}

int main()
{	
	cout << solution({ 2,6,8,14 })<<'\n';

	cout << solution({ 1,2,3 });
	
}