#include <iostream>
#include <unordered_map>
using namespace std;

int main() 
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int N, M;
    cin >> N;

    unordered_map<int, int> cardCount;
    for (int i = 0; i < N; ++i) 
    {
        int num;
        cin >> num;
        cardCount[num]++;
    }

    cin >> M;
    for (int i = 0; i < M; ++i) 
    {
        int query;
        cin >> query;
        cout << cardCount[query] << " ";
    }

    return 0;
}
