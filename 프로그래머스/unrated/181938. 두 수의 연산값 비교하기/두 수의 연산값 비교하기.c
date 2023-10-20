#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int a, int b) {
    int answer = 0;
    
    int firstAnswer, secondAnswer;
    int i, j;
    
    for(i = 1; i <= b;){
        i *= 10;
    }
    
    firstAnswer = a * i + b;
    
    secondAnswer = (2 * a) * b;
    
    if(firstAnswer == secondAnswer){
        return firstAnswer;
    }
    
    return firstAnswer > secondAnswer ? firstAnswer : secondAnswer;
}