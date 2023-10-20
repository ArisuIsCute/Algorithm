#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>

// 파라미터로 주어지는 문자열은 const로 주어집니다. 변경하려면 문자열을 복사해서 사용하세요.
bool solution(const char* s) {
    int open = 0;
    
    for(int i = 0; i < strlen(s); i++){
        open = s[i] == '(' ? open + 1 : open - 1;
        
        if(open < 0) return false;
    }
    
    return !open;
}