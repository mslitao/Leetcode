using System;
using System.Collections.Generic;
using System.Linq;

public class Solution278
{
    public bool IsBadVersion(int result)
    {
        return false;
    }
    public int FirstBadVersion(int n) {
        return FirstBadVersion(1, n);
    }

    public int FirstBadVersion(int start, int end) {
        if(end - start ==1 )
        {
            if(IsBadVersion(start))
                return start;
            else
                return end;
        }
        
        if(end <= start)
        {
            if(IsBadVersion(end))
                return end;
            else
                return start;
        }
        
        var middle = start+(end-start)/2;
        if(IsBadVersion(middle))
        {
            return FirstBadVersion(start, middle);
        }
        else
        {
            return FirstBadVersion(middle, end);
        }
    }
}