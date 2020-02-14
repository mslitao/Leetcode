using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution41
{
    public int FirstMissingPositive(int[] nums) {
        int minVal = int.MaxValue;
        int length =0;
        foreach(int num in nums)
        {
            if(num > 0 && num < minVal)
            {
                minVal = num;
            }
            if(num > 0)
            {
                length ++;
            }
        }

        if(minVal != 1)
        {
            return 1;
        }

        int[] numMap = new int[length];
        foreach(int num in nums)
        {
            // if the num is outsize the range of minVal_length, no need to process this value.
            if(num > 0 && num - minVal <= length -1)
            {
                numMap[num-minVal] = 1;
            }
        }
        
        for(int i =0; i< length; i++)
        {
            if(numMap[i] != 1)
                return i+1;
        }
        
        return length+1;
    }
}