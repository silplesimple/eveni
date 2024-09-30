#include <string>
#include <vector>
#include <queue>
#include <algorithm>
using namespace std;

int dx[4]{ -1, 1, 0, 0 };
int dy[4]{ 0, 0, -1, 1 };

vector<int> solution(vector<string> maps) {
    int height = maps.size();
    int width = maps[0].size();

    queue<pair<int, int>> q;
    vector<vector<bool>> v(vector<vector<bool>>(height, vector<bool>(width, false)));
    vector<int> answer;

    for (int i = 0; i < height; ++i)
        for (int j = 0; j < width; ++j)
            if (maps[i][j] != 'X' && !v[i][j])
            {
                int sum = 0;
                q.push({ i, j });
                v[i][j] = true;

                while (!q.empty())
                {
                    int x = q.front().second;
                    int y = q.front().first;
                    q.pop();

                    sum += (maps[y][x] - '0');

                    for (int k = 0; k < 4; ++k)
                    {
                        int xx = x + dx[k];
                        int yy = y + dy[k];

                        if (xx == -1 || yy == -1 || xx == width || yy == height || maps[yy][xx] == 'X' || v[yy][xx])
                            continue;

                        v[yy][xx] = true;

                        q.push({ yy, xx });

                        printf("{%d %d}���� {%d %d}�� �̵�!\n", y, x, yy, xx);
                    }
                }

                answer.push_back(sum);
            }

    sort(answer.begin(), answer.end());

    if (answer.empty())
        answer.push_back(-1);

    return answer;
}
