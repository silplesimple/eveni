#include<string>
#include<vector>
#include<iostream>


using namespace std;

vector<int> result;

vector<int> solution(vector<int> sequence, int k)
{
	vector<int> answer(sequence.size());
	int a;
	for (int i = 0; i < sequence.size(); i++)
	{
		a = sequence[i];
		for (int j = 1; j < sequence.size(); j++)
		{
			a += sequence[j];
		}

		answer[0] += sequence[i];
		if (answer[0] == k)
		{

		}		
	}

	return answer;
}

void PrintResult(vector<int> sequence,int k)
{
	result = solution(sequence, k);
	cout << "°á°ú : ";
	for (int i = 0; i < result.size(); i++)
	{
		cout << result[i] << ' ';
	}
	cout << '\n';
	result.clear();
}

int main()
{
	vector<int> sequence;
	int k;
	sequence = { 1,2,3,4,5 };	
	k = 7;
	PrintResult(sequence, k);
}