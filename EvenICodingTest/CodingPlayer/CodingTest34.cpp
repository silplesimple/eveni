#include<iostream>
#include <vector>
using namespace std;

// �������� answer
int answer = 0;

void get_target_number(vector<int> numbers, int target, int sum, int index)
{
	//���� ����
	if (index == numbers.size())
	{
		if (sum == target)
		{
			answer++;
		}
		// ���� �������� return 
		return;
	}
	//���� ������ �������� ������ ���Ž��
	get_target_number(numbers, target, sum + numbers[index], index + 1);
	get_target_number(numbers, target, sum - numbers[index], index + 1);
}

int solution(vector<int> numbers, int target)
{
	get_target_number(numbers, target, 0, 0);

	return answer;
}
int main()
{
	vector<int> numbers;
	int target;
	int result;
	numbers.push_back(1);
	numbers.push_back(1);
	numbers.push_back(1);
	numbers.push_back(1);
	numbers.push_back(1);
	target = 3;
	result = solution(numbers, target);
	cout << result << '\n';
}