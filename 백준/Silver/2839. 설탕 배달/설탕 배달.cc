#include <iostream>
using namespace std;

int main() {
    int N;
    cin >> N;
    
    int count = 0;
    
    while (true) {
        if (N % 5 == 0) { // 5로 나누어떨어지면
            count += N / 5;
            cout << count << endl;
            break;
        }
        N -= 3; // 5로 안나눠지면 3을 빼고 봉지 하나 추가
        count++;
        if (N < 0) { // N이 음수가 되면 정확히 맞출 수 없음
            cout << -1 << endl;
            break;
        }
    }
    
    return 0;
}
