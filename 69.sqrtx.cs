
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution69 {
    public int MySqrt(int x) {
        int i = 1, j = x;
        while(i < j){
            int mid = i + (j - i)/2;
            if(x / mid < mid)
                j = mid;
            else
                i = mid + 1;
        }
            
        return x / i < i ? i - 1 : i;
    }
}