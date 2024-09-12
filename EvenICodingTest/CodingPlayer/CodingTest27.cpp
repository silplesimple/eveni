#include<string>
#include<vector>

using namespace std;

vector<int> solution(int n, long long left, long long right)
{
	vector<int> ans;
	long long int x, y;
	for (long long int i = left; i <= right; ++i)
	{
		y = i % n + 1;
		x = i / n + 1;
		long long int value = x > y ? x : y;

		ans.push_back(value);
	}

	return ans;	
}