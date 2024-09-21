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
	//다리의 길이, 다리의 무게 , 차량의 개수	
	for (int i = 0; i < truck_weights.size(); i++)
	{		
		waitTruck.push(truck_weights[i]);			
	}	
	truckLength = truck_weights.size();
	while (passTruck.size()!=truckLength)
	{		
		//턴
		resultTime++;
		//기다리는 트럭의 무계
		
		//건너는 트럭이 있을때
		if (!goTruck.empty())
		{
			//건너는 트럭의 무게가 다리무게보다 조금 적을때?
			if (trucksWeight >= weight - waitFrontTruck)
			{			
				cout << "막혔어용" << '\n';
				passTruck.push(goTruck.front());
				trucksWeight -= goTruck.front();
				goTruck.pop();
				continue;
			}
		}		
		if (!waitTruck.empty())
		{
			//다리길이보다 트럭개수가 작을때만
			if (goTruck.size() < bridge_length)
			{
				//트럭무게가 다리가 견딜수 있는 무게보다 작을때만
				if (trucksWeight < weight)
				{				
					//대기트럭을 건너는 트럭으로 옮기기
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
	cout << "결과: " << result << '\n';
	bridge_length = 100;
	weight = 100;
	truck_weights.clear();
	for (int i = 0; i < 10; i++)
	{
		truck_weights.push_back(10);
	}
	result = solution(bridge_length, weight, truck_weights);
	cout << "결과: " << result << '\n';
}