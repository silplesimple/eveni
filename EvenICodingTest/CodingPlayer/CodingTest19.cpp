#include<string>
#include<vector>
#include<bits/stdc++.h>
using namespace std;

vector<int> solution(int brown, int yellow)
{
	int x, y;
	x = 0.5 * ((2 + brown / 2) + sqrt((2 + brown / 2) * (2 + brown / 2) - 4 * brown - 4 * yellow));
	y = 0.5 * brown - x + 2;
	return { x,y };
}

int main()
{
	vector<int> answer = solution(10, 2);
	cout << "함수 완료!"<<answer[0]<<answer[1];
}