#include<bits/stdc++.h>
#include<vector>

using namespace std;

int solution(int storey)
{
	int answer1 = 0;
	int answer2 = 0;
	vector<int> storeyNumber;
	while (storey != 0)
	{
		cout << storey %10 << '\n';
		storeyNumber.push_back(storey % 10);
		//answer2 += storeyNumber.back();
		storey /= 10;
	}	

	for (int i = 0; i < storeyNumber.size(); i++)
	{						
		if (i == storeyNumber.size() - 1)
		{
			if (storeyNumber[i] == 10)
			{
				answer1++;
				break;
			}
			if (storeyNumber[i] == 5)
			{
				answer1 += storeyNumber[i];
				break;
			}
			answer1 += storeyNumber[i]<5?storeyNumber[i]:10-storeyNumber[i]+1;
			break;
		}
		if (storeyNumber[i] == 10)
		{
			storeyNumber[i + 1]++;
			continue;
		}
		if (storeyNumber[i] != 0 && storeyNumber[i] < 5)
		{
			answer1 += storeyNumber[i];
			storeyNumber[i] -= storeyNumber[i];
		}
		else if (storeyNumber[i] != 0 && (storeyNumber[i] > 5))
		{						
			storeyNumber[i + 1]++;
			answer1 += 10 - storeyNumber[i];
			
			
		}
		else if (storeyNumber[i] == 5)
		{
			if (storeyNumber[i + 1] > 4)
			{
				storeyNumber[i + 1]++;
				answer1 += storeyNumber[i];
				storeyNumber[i] -= storeyNumber[i];
			}
			else {
				answer1 += storeyNumber[i];
				storeyNumber[i] -= storeyNumber[i];
			}
			
		}		
	}
	//cout << "배열 결과:" << storeyNumber[i] << '\n';
	
	
	return answer1;
}

int main()
{
	int result = 0;
	int storey = 16;
	result = solution(storey);
	cout << "결과 : " << result << '\n';
	storey = 2554;
	result = solution(storey);
	cout << "결과 : " << result << '\n';
	storey = 3445;
	result = solution(storey);
	cout << "결과: " << result << '\n';
	storey = 9999;
	result = solution(storey);
	cout << "결과 : " << result << '\n';
	storey = 8999;
	result = solution(storey);
	cout << "결과 : " << result << '\n';
	storey = 3888888;
	result = solution(storey);
	cout << "결과 : " << result << '\n';
	storey = 646;
	result = solution(storey);
	cout << "결과 : " << result << '\n';
	storey = 545;
	result = solution(storey);
	cout << "결과 : " << result << '\n';
}