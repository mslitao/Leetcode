using System;
using System.Collections.Generic;
using System.Linq;

/*

*/
class SolutionTemplate
{
    //
    public int Add(int a, int b)
    {
        return a+b;
    }
    
    //
    public bool TestAdd(int a, int b, int expected)
    {
        Console.WriteLine(string.Format("{0} + {1} =", a, b));
        
        int result = Add(a, b);
        Console.WriteLine(string.Format("Result:{0} vs Expected: {1}", result, expected));
        
        return result == expected;
    }
}