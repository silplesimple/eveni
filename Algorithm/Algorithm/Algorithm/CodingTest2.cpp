#include <iostream>
#include <string>
#include <vector>
#include<sstream>
using namespace std;

//비디오의 길이, pos는 현재 재생 위치, op_start는 오프닝 시작 위치,
//op_end는 오프닝의 끝위치, commands는 지금 행하는 명령
//일단 프리브 기능과 넥스트 기능을 만든 다음에
//오프닝인 경우를 만듬
//그전에 스트링 기능점
//현재 시간을 저장하는 변수와 영상 전체 시간을 저장하는 변수를 저장
string solution(string video_len, string pos, string op_start,
	string op_end, vector<string> commands)
{
	//mm:ss로 나뉘어서 형변환하는게 일단 그려짐
	string answer = "";
	int temp = stoi(pos.substr(0, 2)) * 60 + stoi(pos.substr(3, 2));
	int totalLen = stoi(video_len.substr(0, 2)) * 60 + stoi(video_len.substr(3, 2));
	int opStart = stoi(op_start.substr(0, 2)) * 60 + stoi(op_start.substr(3, 2));
	int opEnd = stoi(op_end.substr(0, 2)) * 60 + stoi(op_end.substr(3, 2));
	
	if (opStart <= temp && opEnd >= temp)
	{
		temp = opEnd;
	}
	
	for (string com : commands)
	{
		if (com.compare("prev") == 0)
		{
			if (temp - 10 > 0)
			{
				temp -= 10;
			}
			else
			{
				temp = 0;
			}
		}
		else if (com.compare("next") == 0)
		{
			if (temp + 10 < totalLen)
			{
				temp += 10;
			}
			else
			{
				temp = totalLen;
			}
		}

		if (opStart <= temp && opEnd >= temp)
		{
			temp = opEnd;
		}
	}
	// 1.string - > int
	//cout << stoi(video_len);
	
	//cout << videoLength << '\n';
	answer = (temp / 60 < 10 ? "0" + to_string(temp / 60) : to_string(temp / 60)) + ":" + (temp % 60 < 10 ? "0" + to_string(temp % 60) : to_string(temp % 60));

	return answer;	
}
int main()
{
	string video_len;
	string pos;
	string op_start;
	string op_end;
	string answer;
	vector<string> commands;
	video_len = "34:33";
	pos = "13:00";
	op_start = "00:55";
	op_end = "02:55";
	commands.push_back("next");
	commands.push_back("prev");
	answer = solution(video_len, pos, op_start, op_end,commands);

}

//https://school.programmers.co.kr/learn/courses/30/lessons/340213