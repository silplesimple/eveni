#include <queue>
#include <vector>

using namespace std;

int solution(int bridge_length, int weight, vector<int> truck_weights) {
    int answer = 0;

    int idx = 0;    //���� ����� idx
    int sum = 0;   //���� �ٸ��� �ö���ִ� ���� ���� ����
    queue<int> q;  //���� �ٸ��� �ǳʴ� Ʈ�� üũ�� ť

    while (1) {

        if (idx == truck_weights.size()) {  //������ Ʈ���� ��
            answer += bridge_length;  //������ Ʈ���� ������ �ð� �߰�
            break;
        }

        answer++; //�ð��� ����
        int tmp = truck_weights[idx];

        //���� �ٸ��� �� �ǳ��� ���
        if (q.size() == bridge_length) {
            sum -= q.front();  //�� �ǳ����� ���� �ٸ��� �ִ� ������ ���Կ��� ����
            q.pop();
        }

        if (sum + tmp <= weight) {  //�ٸ��� ���� ���� ������ �� �ִٸ�
            sum += tmp;  //���� ���� �߰�
            q.push(tmp);
            idx++;  //���� ������ ���ؼ�
        }
        else {
            q.push(0);  //������ �� ���ٸ� 0�� Ǫ���ؼ� �ð��� ���
        }
    }

    return answer;
}