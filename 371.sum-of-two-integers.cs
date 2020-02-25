using System;
using System.Collections.Generic;

public class Solution371 {
    public int GetSum(int a, int b) 
    {
        if (b == 0) return a;
        if (a == 0) return b;
	    
        var noCarry = a ^ b;
		var carry = a & b; // Positive or negative

		return GetSum(noCarry, carry << 1);
    }
}