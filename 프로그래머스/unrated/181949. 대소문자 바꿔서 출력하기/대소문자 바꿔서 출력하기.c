#include <stdio.h>
#define LEN_INPUT 20

int main(void) {
    char s1[LEN_INPUT];
    scanf("%s", s1);
    
    for(int i = 0; i < LEN_INPUT; i++){
        
        if(s1[i] <= 90){
            s1[i] += 32;
        }else{
            s1[i] -= 32;
        }
        
        if(s1[i + 1] == "\0") break;
        
    }
    
    printf("%s", s1);

    return 0;
}
