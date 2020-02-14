
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution42 
{
    public int Trap(int[] height) {
        int result = 0;
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i < height.Length; ++i)
        {
            var current = height[i];
            while(stack.Any() && current > height[stack.Peek()])
            {
                int top = stack.Pop();
                if(!stack.Any())
                    break;
                
                int distance = i - stack.Peek() - 1;
                int bound = Math.Min(current, height[stack.Peek()]) - height[top];

                result += distance * bound;
            }
            stack.Push(i);
        }

        return result;
    }
}