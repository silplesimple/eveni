#include<string>
#include<vector>
#include<iostream>
#include<map>

using namespace std;

int CarIndex(string records)
{
	string Index="";
	int num;
	if (records.size() > 10)
	{
		for (int i = 6; i < 10; i++)
		{
			Index += records[i];
		}		
		num = stoi(Index);
		return num;
	}
	return 0;
}

int TimeRecords(string records)
{
	string sHour="";
	string sMin = "";
	for (int i = 0; i < 2; i++)
	{
		sHour += records[i];
		sMin += records[i + 3];
	}	
	int hour = stoi(sHour)*60;
	int min = stoi(sMin);
	return hour + min;
}

vector<int> solution(vector<int> fees, vector<string>
records)
{
	vector<int>answer;
	map<int, int> m;
	
	for (int i = 0; i < records.size(); i++)
	{
		int mIndex = CarIndex(records[i]);
		cout <<"차 번호:" << mIndex << '\n';
		int mtime = TimeRecords(records[i]);
		cout << "차 시간: " << mtime << '\n';
		if (records[i][11] == 'I')
		{
			m[mIndex] = mtime;			
			cout << records[i]<<'\n';
		}
		else if (records[i][11] == 'O')
		{
			int outTime=mtime-m[mIndex];
			m[mIndex] = outTime;
			cout << "나간시간:"<<m[mIndex]<<'\n';
			cout << records[i] << '\n';
		}
	}
	return answer;
}



int main()
{
	vector<int> fees;
	vector<string>records;
	vector<int> result;
	fees.push_back(180);
	fees.push_back(5000);
	fees.push_back(10);
	fees.push_back(600);
	records.push_back("05:34 5961 IN");
	records.push_back("06:00 0000 IN");
	records.push_back("06:34 0000 OUT");
	records.push_back("07:59 5961 OUT");
	records.push_back("07:59 0148 IN");
	records.push_back("18:59 0000 IN");
	records.push_back("19:09 0148 OUT");
	records.push_back("22:59 5961 IN");
	records.push_back("23:00 5961 OUT");
	result = solution(fees, records);
	for (int i = 0; i < result.size(); i++)
	{
		cout << "결과:"<<result[i] << '\n';
	}
}