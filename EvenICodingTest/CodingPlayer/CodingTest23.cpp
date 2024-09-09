#include<string>
#include<vector>
#include<iostream>
#include<algorithm>
using namespace std;

int solution(int k, vector<int> tangerine)
{
	int answer = 0;
	int index = 0;
	int typeCount = 0;
	vector<int> size(tangerine.size());
	sort(tangerine.begin(), tangerine.end());	
	for (int i = 0; i < tangerine.size(); i++)
	{
		if (tangerine[i] != tangerine[index])
		{
			index=i;
		}
		size[index]++;		
		if (size[index] > k)
		{
			size[index] = k;
		}
	}
	sort(size.rbegin(), size.rend());
	for (int i = 0; i < size.size(); i++)
	{
		cout << size[i] << '\n';				
		
		if (typeCount < k)
		{
			typeCount += size[i];
			answer++;
		}		
	}
	return answer;
}

int main()
{
	cout << solution(6,{1,6,3,5,4,5,2,3});	

	
}