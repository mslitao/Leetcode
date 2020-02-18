using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution202
{
    public bool IsHappy(int n) 
    {
        int slow, fast;
        slow = fast = n;
        do
        {
            slow = digitSquareSum(slow);
            fast = digitSquareSum(fast);
            fast = digitSquareSum(fast);
            if (fast == 1) return true;
        } while (slow != fast);

        if (slow == 1) return true;
        else return false;
    }

    public bool IsHappy2(int n) 
    {
        int num = n;
        HashSet<int> numbers = new HashSet<int>();
        while(true)
        {
            num = digitSquareSum(num);
            if(numbers.Contains(num))
                break;
            numbers.Add(num);
        } 
        
        return num == 1;
    }

    int digitSquareSum(int n)
    {
        int sum = 0, tmp;
        while (n > 0)
        {
            tmp = n % 10;
            sum += tmp * tmp;
            n /= 10;
        }
        return sum;
    }
}