#include<string>
#include<vector>
#include<iostream>
using namespace std;

vector<int> solution(int n, long long left, long long right)
{
	vector<int> answer(n,n);
	int m, u;
	cin >> m >> u;
	int TestIndex = 1;
	//m*n�� 2���� ���͸� 0���� �ʱ�ȭ �Ͽ� ����
	vector<vector<int>> v(m, vector<int>(u, 0));

	//�޸� �Ҵ� ����
	
	if (TestIndex == 0)
	{
		for (int i = 0; i < m; i++)
		{
			for (int j = 0; j < u; j++)
			{
				//�Ҵ��� ��ŭ ���������� ������
				cout << v[i][j] << " ";
			}
			cout << "\n";
		}
		return v[0];
	}
	vector<vector<int>> v1(m);
	if (TestIndex == 1)
	{
		v1[0].push_back(1);
		v1[0].push_back(2);
		v1[0].push_back(3);

		v1[1].push_back(10);

		v1[2].push_back(100);
		v1[2].push_back(200);

		v1[3].push_back(0);

		return v1[2];
	}
	vector<int> answer1;
	for (int i = 0; i < answer1.size(); i++)
	{
		cout << answer1[i] << '\n';
	}
	cout << answer1.size()<< "<-������" << '\n';
	
	return answer;
}

int main()
{
	vector<int> answer;
	answer = solution(3, 2, 5);
	for (int i = 0; i < answer.size(); i++)
	{
		cout << answer[i] << '\n';
	}
}