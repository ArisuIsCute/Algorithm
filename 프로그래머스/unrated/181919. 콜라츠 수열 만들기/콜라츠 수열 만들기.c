#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int* solution(int n) {
    // return 값은 malloc 등 동적 할당을 사용해주세요. 할당 길이는 상황에 맞게 변경해주세요.
    int* answer = (int*)malloc(sizeof(int) * 1000);
    int cnt = 0;
    while(n != 1){
        answer[cnt++] = n;
        if(n % 2){
            n = 3 * n + 1;
        }else{
            n /= 2;
        }
    }
    answer[cnt++] = n;
    answer[cnt] = '\0';
    return answer;
}