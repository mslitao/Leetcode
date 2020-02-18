using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution229
{
    public IList<int> MajorityElement(int[] nums) {
        int a = 0;
        int b = 0;
        int cntA = 0;
        int cntB = 0;
        foreach(var num in nums)
        {
            if(cntA > 0 && num == a)
            {
                cntA++;
            }
            else if(cntB > 0 && num == b)
            {
                cntB++;
            }
            else if(cntA ==0) 
            {
                a = num;
                cntA ++;
            }
            else if(cntB ==0)
            {
                b = num;
                cntB++;
            }
            else
            {
                cntA--;
                cntB--;
            }
        }

        cntA =0;
        cntB =0;
        foreach(var num in nums)
        {
            if(num == a)
            {
                cntA ++;
            }
            else if(num == b)
            {
                cntB ++;
            }
        }

        IList<int> results = new List<int>();
        if(cntA>nums.Length/3) results.Add(a);
        if(cntB>nums.Length/3) results.Add(b);

        return results;
    }
}