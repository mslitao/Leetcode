using System;
using System.Collections.Generic;
using System.Linq;

public class Solution134
{
    public int CanCompleteCircuit(int[] gas, int[] cost) 
    {
        int total = 0;
        int start = 0;
        int tank = 0;
        for(int i = 0; i < gas.Length; ++i)
        {
            tank = tank + gas[i] - cost[i];
            // if the tank is less then 0, try to start with the next station as the begining
            // remember to cache the current total
            if(tank < 0)
            {
                start = i + 1;
                total = total + tank;
                tank = 0;
            }
        }

        if(total + tank < 0) return -1;
        else return start;
    }
}