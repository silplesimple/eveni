class step1
{
public:
	int func1(int N)
	{
		int answer = 0;
		for (int i = 0; i < N; i++)
		{		
			if (i % 3 == 0 || i % 5 == 0)
			{
				answer += i;
			}
		}
		return answer;
	}
	//����1
	//N ������ �ڿ��� �߿��� 3�� ����̰ų� 5�� ����� ���� ��� ���Ѱ��� ��ȯ�ϴ� �Լ� func1(int N)�� �ۼ��϶�. N�� 10�������� �ڿ��� �̴�.

	int func2(int arr[], int N)
	{
		for (int i = 0; i < N; i++)
		{
			for (int j = 1; j < N; j++)
			{

			}
		}
		return 0;
	}

	//����2
	//�־��� ���� N�� int �迭 arr���� ���� 100�� ���� �ٸ� ��ġ�� �� ���Ұ� �����ϸ� 1��, �������� ������ 0��
	//��ȯ�ϴ� �Լ� func2(int arr[],int N)�� �ۼ��϶� arr�� �� ���� 0 �̻� 100 �����̰� N�� 1000�����̴�.
};


