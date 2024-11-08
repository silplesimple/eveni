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
	//문제1
	//N 이하의 자연수 중에서 3의 배수이거나 5의 배수인 수를 모두 합한값을 반환하는 함수 func1(int N)을 작성하라. N은 10만이하의 자연수 이다.

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

	//문제2
	//주어진 길이 N의 int 배열 arr에서 합이 100인 서로 다른 위치의 두 원소가 존재하면 1을, 존재하지 않으면 0을
	//반환하는 함수 func2(int arr[],int N)을 작성하라 arr의 각 수는 0 이상 100 이하이고 N은 1000이하이다.
};


