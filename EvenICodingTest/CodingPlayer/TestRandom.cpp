#include<iostream>
#include<random>

int main()
{
	// �õ� ���� ��� ���� random_device ����.
	std::random_device rd;

	// random_device �� ���� ���� ���� ������ �ʱ�ȭ �Ѵ�.
	std::mt19937 gen(rd());

	// 0 ���� 99 ���� �յ��ϰ� ��Ÿ���� �������� �����ϱ� ���� �յ� ���� ����;
	std::uniform_int_distribution<int> dis(0, 99);

	for (int i = 0; i < 5; i++)
	{
		std::cout << "����: " << dis(gen) << std::endl;
	}
}