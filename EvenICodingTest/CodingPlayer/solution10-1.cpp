#include<string>
#include<vector>
#include<iostream>

using namespace std;

bool isPrime(int n)
{
	for (int i = 2; i <= sqrt(n); i++)
	{
		if (n % i == 0)
		{
			return false;
		}
	}

	return true;
}
int solution(string numbers)
{
	int answer = 0;
	int vectorIndex = 1;
	vector<int> saveNumber;

	for (int i = 1; i <= numbers.size(); i++)
	{
		vectorIndex *= i;
	}
	vectorIndex += numbers.size();
	cout << "�ѹ��ε����� ������ : " << vectorIndex << '\n';
	string number(numbers);
	number[0] = numbers[1];
	number[1] = numbers[0];
	answer = stoi(numbers);
	answer = stoi(number);
	
	//���ڿ��� ���� ����-> ������ ��ȯ-> �Ҽ����� üũ 
	/*for (int i = 0; i < numbers.size(); i++)
	{		
		numbers
	}*/
	//���ڿ��� ���� �����ض�
	//���ڿ��� ���� �����Ͽ� ������ 
	// �̹���� ���� ���غ���
	//������ ������ �Ҽ��� �ɷ�����(�Ҽ��� �ɷ����� ���)
	//�Ҽ��� 1�� �ڽŸ��� ���� �����ϴ� ��
	// 2o 3o 4x 5o 6x 7 8 9 10 11 12 13 14 15
	// �ظ��ϸ� 3�̳� 2�� �Ʒ����� ����������
	// 3�̳� 2�� ������ �Ҽ��� �з��ϴ� ���
	//�ɷ��� ��ŭ �信 �÷����ض�

	return answer;
}

void PrintResult(string numbers,int answer)
{
	int result = 0;		
	string answerText = "";
	bool answerTest = (result == answer);	
	result = solution(numbers);	
	answerText = answerTest ? "�����Դϴ�" : "�����Դϴ�";
	cout << "���:" << result << '\n';
	cout << answerText << '\n';
}
int main()
{
	int answer = 0;
	string numbers;		
	numbers = "17";
	answer = 3;
	PrintResult(numbers, answer);
	numbers = "011";
	answer = 2;
	PrintResult(numbers, answer);
	
	
}