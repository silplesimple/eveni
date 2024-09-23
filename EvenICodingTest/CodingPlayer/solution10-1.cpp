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
	cout << "넘버인덱스의 사이즈 : " << vectorIndex << '\n';
	string number(numbers);
	number[0] = numbers[1];
	number[1] = numbers[0];
	answer = stoi(numbers);
	answer = stoi(number);
	
	//문자열로 수를 조합-> 정수로 변환-> 소수인지 체크 
	/*for (int i = 0; i < numbers.size(); i++)
	{		
		numbers
	}*/
	//문자열로 수를 조합해라
	//문자열을 수로 저장하여 보내기 
	// 이방법은 많이 안해봤음
	//조합한 수에서 소수를 걸러내라(소수를 걸러내는 방법)
	//소수는 1과 자신만이 수로 존재하는 수
	// 2o 3o 4x 5o 6x 7 8 9 10 11 12 13 14 15
	// 왠만하면 3이나 2가 아랫수로 지정되있음
	// 3이나 2로 나눠서 소수를 분류하는 방법
	//걸러낸 만큼 답에 플러스해라

	return answer;
}

void PrintResult(string numbers,int answer)
{
	int result = 0;		
	string answerText = "";
	bool answerTest = (result == answer);	
	result = solution(numbers);	
	answerText = answerTest ? "정답입니다" : "오답입니다";
	cout << "결과:" << result << '\n';
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