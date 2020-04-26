using System;
using System.Collections.Generic;
using System.Linq;

public class Solution135
{
    public int Candy(int[] ratings) {
        Stack<int> stack = new Stack<int>();
        int[] candies = new int[ratings.Length];
        int candy = 1;
        for(int i = 0; i < ratings.Length; ++ i)
        {
            if(i == 0 )
            {
                stack.Push(i);
            }
            else if (ratings[i] < ratings[i - 1])
            {
                stack.Push(i);
            }
            else
            {
                candy = 1;
                while(stack.Any())
                {
                    candies[stack.Pop()] =candy ++;
                }
                
                if(ratings[i] == ratings[i - 1])
                    candies[i] = 1;
                else
                    candies[i] = candies[i -1 ] + 1;
            }
        }

        candy =1;
        while(stack.Any())
        {
            candies[stack.Pop()] =candy ++;
        }

        Console.WriteLine(string.Join("-", candies));
        for(int i = ratings.Length -2; i >=0; i --)
        {
            if(ratings[i] > ratings[i + 1] && candies[i] < candies[i + 1])
            {
                candies[i] = candies[i + 1] + 1;
            }
        }

        return candies.Sum();
    }
}