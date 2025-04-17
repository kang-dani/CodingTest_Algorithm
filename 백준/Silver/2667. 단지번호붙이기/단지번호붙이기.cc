#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int n;
vector<vector<int>> map;
vector<vector<bool>> visited;
int dx[4] = { -1, 1, 0, 0 };
int dy[4] = { 0, 0, -1, 1 };
int houseCount = 0;

void dfs(int x, int y) {
    visited[x][y] = true;
    houseCount++;

    for (int i = 0; i < 4; i++) {
        int nx = x + dx[i];
        int ny = y + dy[i];

        if (nx >= 0 && nx < n && ny >= 0 && ny < n) {
            if (map[nx][ny] == 1 && !visited[nx][ny]) {
                dfs(nx, ny);
            }
        }
    }
}

int main() {
    cin >> n;
    map = vector<vector<int>>(n, vector<int>(n));
    visited = vector<vector<bool>>(n, vector<bool>(n, false));

    for (int i = 0; i < n; i++) {
        string line;
        cin >> line;
        for (int j = 0; j < n; j++) {
            map[i][j] = line[j] - '0';
        }
    }

    vector<int> result;

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            if (map[i][j] == 1 && !visited[i][j]) {
                houseCount = 0;
                dfs(i, j);
                result.push_back(houseCount);
            }
        }
    }

    sort(result.begin(), result.end());

    cout << result.size() << '\n';
    for (int cnt : result) {
        cout << cnt << '\n';
    }

    return 0;
}
