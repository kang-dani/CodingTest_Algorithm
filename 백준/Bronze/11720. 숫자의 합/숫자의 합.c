#include <stdio.h>

int main(void) {
	int numberCount, answer = 0;
	char inputNumber[101];
	scanf("%d", &numberCount);
	scanf("%s", inputNumber, sizeof(inputNumber));
	for (int i = 0; i < numberCount; i++) {
		answer += inputNumber[i] - '0';
	}
	printf("%d", answer);
	return 0;
}