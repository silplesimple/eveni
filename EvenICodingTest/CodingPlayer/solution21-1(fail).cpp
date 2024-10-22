#include<string>
#include<vector>
#include<iostream>
#include<map>

using namespace std;
map<string, int> maps;
vector<int> pick;
int result()
{
	int diaCount=0;
	int ironCount=0;
	int stoneCount = 0;
	const int One = 1;
	const int Five = 5;
	const int Twefive = 25;
	if (maps["diamond"] != NULL)
	{
		diaCount = maps["diamond"];
	}
	if (maps["iron"] != NULL)
	{
		ironCount = maps["iron"];
	}
	if (maps["stone"]!=NULL)
	{
		stoneCount = maps["stone"];
	}
	//���̾��� ������ ö���� ������
	if (diaCount > ironCount)
	{
		//������ ���ٵ� ������
		if (diaCount > stoneCount)
		{
			//���̾� ��̰� ������
			if (pick[0] != 0)
			{
				//��� ���ֱ�
				pick[0]--;
				maps.clear();
				//����ĳ��
				return (maps["diamond"] * One) + (maps["iron"] * One) + (maps["stone"] * One);
			}
			//ö��̰� ������
			else if (pick[1] != 0)
			{
				pick[1]--;
				maps.clear();
				return (maps["diamond"] * Five) + (maps["iron"] * One) + (maps["stone"] * One);
			}
			//�̰͵� ����?
			pick[2]--;
			maps.clear();
			return (maps["diamond"] * Twefive) + (maps["iron"] * Five) + (maps["stone"] * One);
		}
	}	
	

	
	//������ ���⼭ 5���� �� ��̸� ������
	// �� ��̷� 5�� �ν��� ����������
	// �װ� ������ �־�� �ڳ� �׷�
	// picks ����
	// 
	//���Ϳ��� 5���� �������� ���� ��︮�� ��̸� ���� �� �ּҰ��� ������ ����
	//�������� ��ͷ� ���� 5�� ����
	//�������� ��� �ּҰ��� ���ؼ� ���� ������ ��
	return 5;
}

int solution(vector<int> picks, vector<string> minerals)
{
	pick = picks;
	int answer = 0;
	int vectorLength = 0;
	vectorLength = picks.size();
	cout << "�� �ε�����"<<'\n';
	
	
	vectorLength = minerals.size();
	for (int i = 0; i < vectorLength; i++)
	{
		if (minerals[i] == "diamond")
		{
			maps["diamond"]++;
		}
		else if (minerals[i] == "iron")
		{
			maps["iron"]++;
		}
		else if (minerals[i] == "stone")
		{
			maps["stone"]++;
		}
		if (i+1 == vectorLength)
		{

		}
		if ((i+1) % 5 == 0)
		{
			answer+=result();
		}

	}
	
	return answer;
}

int main()
{
	vector<int> picks;
	vector<int> test;
	vector<string> minerals;
	int answer = 0;
	picks = { 1,3,2 };
	picks.clear();
	picks.push_back(1);
	picks.push_back(3);
	picks.push_back(2);
	minerals = { "diamond", "diamond",
		"diamond", "iron", "iron",
		"diamond", "iron", "stone" };
	minerals.clear();
	minerals.push_back("diamond");
	minerals.push_back("diamond");
	minerals.push_back("diamond");
	minerals.push_back("iron");
	minerals.push_back("iron");
	minerals.push_back("diamond");
	minerals.push_back("iron");
	minerals.push_back("stone");
	answer = solution(picks, minerals);
}