#include<string>
#include<vector>
#include<iostream>
#include<algorithm>
#include<stack>

using namespace std;

int solution(vector<int> order)
{
	stack<int> subCont;
	int answer = 1;
	int subContIndex;
	int nextContIndex;
	//���� 1���� �����ؼ� ������ ù��° ������ �����Ҹ�ŭ
	//���ÿ� �ֱ�\
	//���ÿ��� �������� ���� ���� ���� ���ϰ� �´���
	for (int i = 1; i < order[0]; i++)
	{
		subCont.push(i);
	}		

	nextContIndex = order[0] + 1;
	for (int i = 0; i < order.size(); i++)
	{
		if (i == 0)
		{
			continue;
		}
		if (subCont.top()==order[i])
		{
			answer++;
			subCont.pop();
		}
		else if (nextContIndex == order[i])
		{
			answer++;
			nextContIndex++;
		}
		else
		{
			break;
		}
	}


	return answer;
}

int main()
{
	int result;
	vector<int> order;
	order = { 4,3,1,2,5 };
	result = solution(order);
	cout << "��� :" << result << '\n';
	order = { 5,4,3,2,1 };
	result = solution(order);
	cout << "��� :" << result << '\n';


}