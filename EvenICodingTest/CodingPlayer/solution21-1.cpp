#include <string>
#include <vector>
#include <map>
#include <algorithm>

using namespace std;
map<string, int> m; // "diamind" = 0, "iron" = 1, "stone" = 2
int fatigue[3][3] = { {1,1,1}, {5,1,1}, {25,5,1} }; // [��̷�][�ش籤��Ķ��] = ��� �Ƿε�


void DFS(vector<int>& picks, vector<string>& minerals, int& answer, int sum, int location) {

    // ������ �� ĺ�ų� ��̵��� �� ������ �Ƿε��� ����������.
    if (location == minerals.size() || (picks[0] == 0 && picks[1] == 0 && picks[2] == 0)) {
        answer = min(answer, sum);
        return;
    }


    // 0~2 ��� �湮
    for (int i = 0; i < 3; i++) {

        // i��̰� �ִٸ�
        if (picks[i] != 0) {
            picks[i]--;

            int tmpIdx = location; // ��̸� ��� 5���� �������� ĳ����. ĳ���� ������ �ӽ� �ε���.
            int tmpSum = sum; // ������ ĳ�� ������ �ӽ� �Ƿε�
            for (; tmpIdx < location + 5 && tmpIdx < minerals.size(); tmpIdx++) { // 5���� ĳ�ų� ������ Ķ������ 
                tmpSum += fatigue[i][m[minerals[tmpIdx]]]; // m[minerals[tmpIdx]] : tmpIdx ������ ��ȣ
            }

            DFS(picks, minerals, answer, tmpSum, tmpIdx);

            picks[i]++;
        }
    }

}

int solution(vector<int> picks, vector<string> minerals) {
    int answer = (25 * 50) + 1; // �ְ� �Ƿε�*�ִ뱤������

    // "diamind" = 0, "iron" = 1, "stone" = 2
    m.insert({ "diamond", 0 });
    m.insert({ "iron", 1 });
    m.insert({ "stone", 2 });

    DFS(picks, minerals, answer, 0, 0);

    return answer;
}