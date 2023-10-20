#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

// numLog_len은 배열 numLog의 길이입니다.
char* solution(int numLog[], size_t numLog_len) {
    // return 값은 malloc 등 동적 할당을 사용해주세요. 할당 길이는 상황에 맞게 변경해주세요.
    char* answer = (char*)malloc(sizeof(char) * numLog_len);
    *answer = 0;
    int cnt = 0;
    
    for(int i = 0; i < numLog_len -1; i++){
        if(numLog[i] + 1 == numLog[i + 1]) answer[cnt++] = 'w';
        if(numLog[i] - 1 == numLog[i + 1]) answer[cnt++] = 's';
        if(numLog[i] + 10 == numLog[i + 1]) answer[cnt++] = 'd';
        if(numLog[i] - 10 == numLog[i + 1]) answer[cnt++] = 'a'; 
    }
    answer[cnt] = '\0';
    return answer;
}