using System;
using System.Collections.Generic;
using System.Linq;

public class Solution263 
{
    public bool IsUgly(int num) {
        if(num==0) return false;
        
        while(num % 5 == 0){
            num = num / 5;
        }
        while(num % 3 == 0){
            num = num / 3;
        }
        while(num % 2 == 0){
            num = num / 2;
        }
        return num==1;
    }
}