#include<iostream>

using namespace std;

int solution(int n, int a, int b)
{
	int answer = 0;
	
	if (a > b)
	{
		int temp = 0;
		temp = b;
		b = a;
		a = temp;
	}
	//n��° ���� �ǽ�
	//a�� b�� �����ߵ�
	for (int i = 0; i < n; i++)
	{		
		answer++;
		if (a % 2 == 1)
		{
			a++;
		}
		if (b % 2 == 1)
		{
			b++;
		}
		a /= 2;
		b /= 2;
		if (a == b)
		{
			break;
		}			
	}


	return answer;
}

int main()
{
	cout << solution(8, 4, 7);
}