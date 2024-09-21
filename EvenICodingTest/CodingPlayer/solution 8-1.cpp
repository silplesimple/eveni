#include<string>
#include<vector>
#include<iostream>
#include<queue>
using namespace std;

int solution(int bridge_length, 
	int weight, vector<int> truck_weights)
{
	queue<int> waitTruck;
	queue<int> goTruck;
	queue<int> passTruck;
	int answer = 0;
	int truckLength=0;
	int resultTime = 0;
	int trucksWeight = 0;
	int waitFrontTruck = 0;
	//�ٸ��� ����, �ٸ��� ���� , ������ ����	
	for (int i = 0; i < truck_weights.size(); i++)
	{		
		waitTruck.push(truck_weights[i]);			
	}	
	truckLength = truck_weights.size();
	while (passTruck.size()!=truckLength)
	{		
		//��
		resultTime++;
		//��ٸ��� Ʈ���� ����
		
		//�ǳʴ� Ʈ���� ������
		if (!goTruck.empty())
		{
			//�ǳʴ� Ʈ���� ���԰� �ٸ����Ժ��� ���� ������?
			if (trucksWeight >= weight - waitFrontTruck)
			{			
				cout << "�������" << '\n';
				passTruck.push(goTruck.front());
				trucksWeight -= goTruck.front();
				goTruck.pop();
				continue;
			}
		}		
		if (!waitTruck.empty())
		{
			//�ٸ����̺��� Ʈ�������� ��������
			if (goTruck.size() < bridge_length)
			{
				//Ʈ�����԰� �ٸ��� �ߵ��� �ִ� ���Ժ��� ��������
				if (trucksWeight < weight)
				{				
					//���Ʈ���� �ǳʴ� Ʈ������ �ű��
					goTruck.push(waitTruck.front());
					trucksWeight += waitTruck.front(); 
					waitTruck.pop();
					if (!waitTruck.empty())
					{
						waitFrontTruck = waitTruck.front();
					}
				}
			}		
		}
	}	
	answer = resultTime;
	//for(int )
	return answer;
}

int main()
{
	int result;
	int bridge_length;
	int weight;
	vector<int> truck_weights;
	bridge_length = 2;
	weight = 10;
	truck_weights.push_back(7);
	truck_weights.push_back(4);
	truck_weights.push_back(5);
	truck_weights.push_back(6);
	result = solution(bridge_length,weight,truck_weights);
	cout << "���: " << result << '\n';
	bridge_length = 100;
	weight = 100;
	truck_weights.clear();
	for (int i = 0; i < 10; i++)
	{
		truck_weights.push_back(10);
	}
	result = solution(bridge_length, weight, truck_weights);
	cout << "���: " << result << '\n';
}