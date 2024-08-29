#include <string>
#include <vector>
#include<map>
#include<set>
#include<sstream>

using namespace std;

vector<int> solution(vector<string> id_list, vector<string> report, int k)
{
	// 결과 vector를 0으로 초기화
	vector<int> answer(id_list.size(), 0);

	// 각 멤버의 index를 map에 저장
	map<string, int>id_idx_map;

	// [신고된 ID,신고한 ID]를 저장할 map 생성
	map<string, set<string>>report_map;

	// 각 멤버의 index를 Map에 저장
	for (auto i = 0; i < id_list.size(); ++i)
	{
		id_idx_map[id_list[i]] = i;
	}

	for (auto rep : report)
	{
		stringstream ss(rep);
		string from, to;
		ss >> from >> to ;
		report_map[to].insert(from);
	}

	for (auto iter : report_map)
	{
		if (iter.second.size() >= k)
		{
			for (auto in_iter : iter.second)
			{
				answer[id_idx_map[in_iter]]++;
			}
		}
	}
	return answer;
	
}