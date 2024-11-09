#include<vector>

using namespace std;
vector<int> V(100);
class Step2
{
public :
	void func1(vector<int> v)
	{
		v[10] = 7;
	}

	bool cmp1(vector<int> v1, vector<int>v2, int idx)
	{
		return v1[idx] > v2[idx];
	}

};