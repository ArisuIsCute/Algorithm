#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

// 파라미터로 주어지는 문자열은 const로 주어집니다. 변경하려면 문자열을 복사해서 사용하세요.
char* solution(const char* str1, const char* str2) {
    // return 값은 malloc 등 동적 할당을 사용해주세요. 할당 길이는 상황에 맞게 변경해주세요.
    char* answer = (char*)malloc((strlen(str1) + strlen(str2)) * sizeof(char));
    
    int size = strlen(str1) + strlen(str2) + 1;
    
    int s1 = 0, s2 = 0;
    
    for(int i = 0; i < size; i++){
        
        if(i % 2){
            
            answer[i] = str2[s1++];
            
        }else{
            
            answer[i] = str1[s2++];
            
        }
        
    }
    
    
    return answer;
}