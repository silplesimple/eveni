#include<string>
#include<vector>
#include<iostream>
#include<map>

using namespace std;
map<string, int> maps;
vector<int> pick;
int result()
{
	int diaCount=0;
	int ironCount=0;
	int stoneCount = 0;
	const int One = 1;
	const int Five = 5;
	const int Twefive = 25;
	if (maps["diamond"] != NULL)
	{
		diaCount = maps["diamond"];
	}
	if (maps["iron"] != NULL)
	{
		ironCount = maps["iron"];
	}
	if (maps["stone"]!=NULL)
	{
		stoneCount = maps["stone"];
	}
	//다이아의 개수가 철보다 많을때
	if (diaCount > ironCount)
	{
		//돌개수 보다도 많을떄
		if (diaCount > stoneCount)
		{
			//다이아 곡괭이가 있을때
			if (pick[0] != 0)
			{
				//곡괭이 없애기
				pick[0]--;
				maps.clear();
				//광석캐기
				return (maps["diamond"] * One) + (maps["iron"] * One) + (maps["stone"] * One);
			}
			//철곡괭이가 있을때
			else if (pick[1] != 0)
			{
				pick[1]--;
				maps.clear();
				return (maps["diamond"] * Five) + (maps["iron"] * One) + (maps["stone"] * One);
			}
			//이것도 없어?
			pick[2]--;
			maps.clear();
			return (maps["diamond"] * Twefive) + (maps["iron"] * Five) + (maps["stone"] * One);
		}
	}	
	

	
	//어차피 여기서 5개를 쓸 곡괭이를 가지고
	// 그 곡괭이로 5개 부숴서 돌려보낼거
	// 그거 정보는 있어야 겠네 그럼
	// picks 정보
	// 
	//벡터에서 5개씩 빼가지고 가장 어울리는 곡괭이를 깨서 그 최소값을 가지고 간다
	//다했으면 재귀로 다음 5개 진행
	//다했으면 모든 최소값을 더해서 값을 가지고 옴
	return 5;
}

int solution(vector<int> picks, vector<string> minerals)
{
	pick = picks;
	int answer = 0;
	int vectorLength = 0;
	vectorLength = picks.size();
	cout << "픽 인덱스들"<<'\n';
	
	
	vectorLength = minerals.size();
	for (int i = 0; i < vectorLength; i++)
	{
		if (minerals[i] == "diamond")
		{
			maps["diamond"]++;
		}
		else if (minerals[i] == "iron")
		{
			maps["iron"]++;
		}
		else if (minerals[i] == "stone")
		{
			maps["stone"]++;
		}
		if (i+1 == vectorLength)
		{

		}
		if ((i+1) % 5 == 0)
		{
			answer+=result();
		}

	}
	
	return answer;
}

int main()
{
	vector<int> picks;
	vector<int> test;
	vector<string> minerals;
	int answer = 0;
	picks = { 1,3,2 };
	picks.clear();
	picks.push_back(1);
	picks.push_back(3);
	picks.push_back(2);
	minerals = { "diamond", "diamond",
		"diamond", "iron", "iron",
		"diamond", "iron", "stone" };
	minerals.clear();
	minerals.push_back("diamond");
	minerals.push_back("diamond");
	minerals.push_back("diamond");
	minerals.push_back("iron");
	minerals.push_back("iron");
	minerals.push_back("diamond");
	minerals.push_back("iron");
	minerals.push_back("stone");
	answer = solution(picks, minerals);
}