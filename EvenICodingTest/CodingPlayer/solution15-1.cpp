#include<string>
#include<vector>
#include<iostream>

using namespace std;

static int result;
static int testNumber=1;

int solution(vector<int> queue1, vector<int> queue2)
{
	int answer = 0;
	int sum = 0;
	int que1Sum = 0;
	int que2Sum = 0;
	int que1Length = queue1.size();
	int que2Length = queue2.size();

	for (int i = 0; i < queue2.size()-1; i++)
	{	//ù���� ���
		queue1.push_back(queue2[i]);
		queue2.erase(queue2.begin());
		/*sum += queue1[i];
		sum += queue2[i];
		for (int j = 0; j < queue2.size(); j++)
		{
			
		}*/
	}
	for (int i = 0; i < queue1.size(); i++)
	{	//�ι��� ���
		cout<<i<<"ù���� ���� �ε���" << queue1[i] << '\n';
	}
	for (int i = 0; i < queue2.size(); i++)
	{
		cout << i << "�ι�° ���� �ε���" << queue2[i] << '\n';
	}
	/*do
	{
		que1 = 0;
		que2 = 0;
		for()


	} while (que1!=que2);*/
	
	//if(ù��° ���<�ι������)
	//ù��° ���
	//else
	//�ι�°���
	return sum;
}

void PrintResult(vector<int> queue1, vector<int>queue2)
{
	result = solution(queue1, queue2);
	cout << testNumber++<< "��° ���� ��� : " << result << '\n';
	result = 0;
}


int main()
{
	vector<int>queue1;
	vector<int>queue2;
	queue1 = { 3,2,7,2 };
	queue2 = { 4,6,5,1 };
	PrintResult(queue1, queue2);
	queue1 = { 1,2,1,2};
	queue2 = { 4,6,5,1 };
	PrintResult(queue1, queue2);
	queue1 = { 1,1 };
	queue2 = { 1,5 };
	PrintResult(queue1, queue2);
	
	
}