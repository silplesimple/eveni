#include <string>
#include <vector>
#include<bits/stdc++.h>
using namespace std;

map<int, int>attackTime;

int solution(vector<int>banage, int health, vector<vector<int>>attacks)
{
	int answer = 0;
	int lastTime = 0;
	int count = 0;

	for (int i = 0; i < attacks.size(); i++)
	{
		attackTime[attacks[i][0]] = attacks[i][1];

		if (i == (attacks.size() - 1))
		{
			lastTime = attacks[i][0];
		}
	}

	answer = health;

	for (int i = 0; i <= lastTime; i++)
	{
		if (attackTime[i] != 0)
		{
			answer -= attackTime[i];
			count = 0;
			if (answer <= 0)
			{
				answer = -1;
				break;
			}
		}
		else
		{

		}

	}

	return answer;
}

