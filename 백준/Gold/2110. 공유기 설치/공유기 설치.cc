#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

bool Binary(const vector<int>& houses, int dist, int c) {
    int count = 1;
    int lastPos = houses[0];

    for (int i = 1; i < houses.size(); ++i) {
        if (houses[i] - lastPos >= dist) {
            count++;
            lastPos = houses[i];
        }
    }

    return count >= c;
}

int main() {
    int n, c;
    cin >> n >> c;

    vector<int> houses(n);
    for (int i = 0; i < n; ++i) {
        cin >> houses[i];
    }

    sort(houses.begin(), houses.end());

    int left = 1;
    int right = houses[n - 1] - houses[0];
    int answer = 0;

    while (left <= right) {
        int mid = (left + right) / 2;

        if (Binary(houses, mid, c)) {
            answer = mid;   
            left = mid + 1;
        }
        else {
            right = mid - 1; 
        }
    }

    cout << answer << endl;
    return 0;
}

