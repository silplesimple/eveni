#include<string>
#include<vector>
#include<iostream>
#include<map>
using namespace std;

int solution(vector<vector<string>> clothes)
{
	int answer = 1;
	map<string, int> clothesCount;
	int a = 1;
	
	for (int i = 0; i<clothes.size(); i++)
	{
		string clothesCountIndex;
		clothesCountIndex= clothes[i][1];
		clothesCount[clothesCountIndex]++;
		//���� ���� �־��ٸ�?
		cout << clothesCount[clothes[i][1]] << '\n';
	}
	cout << "�ʿ� ī��Ʈ:" << clothesCount.size()<<'\n';
	for (int i = 0; i < clothesCount.size(); i++)
	{
		cout << clothesCount[clothes[i][1]] << '\n';
	}

	for (int i = 0; i < clothesCount.size(); i++)
	{
		string clothesCountIndex;
		
		clothesCountIndex = clothes[i][1];
		a *= i + 1;
		answer += clothesCount[clothesCountIndex];
	}
	//cout<<clothesCount.size();	
	if (clothesCount.size() == 1)
	{
		return answer - 1;
	}
	return answer+a-1;
}

int main()
{
	vector<vector<string>> clothes;
	clothes.push_back({ "yellow_hat","headgear" });
	clothes.push_back({ "blue_sunglasses","eyewear" });
	clothes.push_back({ "green_turban","headgear" });
	int a = solution(clothes);
	cout << "����� ��:" << a;
}
