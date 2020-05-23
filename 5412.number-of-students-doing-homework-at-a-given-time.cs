using System;
using System.Collections.Generic;
using System.Linq;

public class Solution5412
{
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime) {
        int len = startTime.Length;
        int cnt = 0;
        for(int i =0; i< len; ++i)
        {
            if(startTime[i]<= queryTime && endTime[i]>= queryTime) cnt ++;
        }

        return cnt;
    }
}