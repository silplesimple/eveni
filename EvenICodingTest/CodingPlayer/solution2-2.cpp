#include <string>
#include <vector>
#include <map>
#include <sstream>
#include <cmath>

using namespace std;

int time_diff(string in, string out) {
    int h1 = stoi(in.substr(0, 2));
    int m1 = stoi(in.substr(3, 2));
    int h2 = stoi(out.substr(0, 2));
    int m2 = stoi(out.substr(3, 2));

    int diff = (h2 - h1) * 60 + (m2 - m1);

    return diff;
}

vector<int> solution(vector<int> fees, vector<string> records) {
    vector<int> answer;
    map<string, vector<string>> m;

    stringstream ss;
    for (auto record : records) {
        ss.str(record);
        string time, number, status; ss >> time >> number >> status;

        m[number].push_back(time);
        ss.clear();
    }

    for (auto it : m) {
        if (it.second.size() & 1) // 주차 내역 홀수면 "23:59" 추가
            it.second.push_back("23:59");

        vector<string> info = it.second;
        int total = 0;
        for (int i = 0; i < info.size() - 1; i += 2) {
            total += time_diff(info[i], info[i + 1]);
        }

        int price = fees[1];
        if (total > fees[0]) {
            price += ceil((total - fees[0]) / (double)fees[2]) * fees[3];
        }

        answer.push_back(price);
    }

    return answer;
}