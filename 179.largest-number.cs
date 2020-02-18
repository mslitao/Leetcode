using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution179 {
    public string LargestNumber(int[] nums) {
        if(nums == null || nums.Length == 0) return "0";
        var numList = nums.ToList();
        numList.Sort(new CustomDataComparer());

        var result = string.Join("", numList).TrimStart('0');
        return string.IsNullOrEmpty(result)? "0": result;
    }
    
    internal class CustomDataComparer: IComparer<int>
    {
        public int Compare(int x, int y)
                    {
                        var dx = x.ToString()+y.ToString();
                        var dy = y.ToString() + x.ToString();
                        return dy.CompareTo(dx);
                    }
    }
}