#include <iostream>
#include <string>
#include <vector>
#include<sstream>
using namespace std;

//������ ����, pos�� ���� ��� ��ġ, op_start�� ������ ���� ��ġ,
//op_end�� �������� ����ġ, commands�� ���� ���ϴ� ���
//�ϴ� ������ ��ɰ� �ؽ�Ʈ ����� ���� ������
//�������� ��츦 ����
//������ ��Ʈ�� �����
//���� �ð��� �����ϴ� ������ ���� ��ü �ð��� �����ϴ� ������ ����
string solution(string video_len, string pos, string op_start,
	string op_end, vector<string> commands)
{
	//mm:ss�� ����� ����ȯ�ϴ°� �ϴ� �׷���
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