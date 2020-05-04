using System;
using System.Collections.Generic;
using System.Linq;

public class Solution1438
{
    public int LongestSubarray(int[] nums, int limit) {
        int start = 0;
        int end = 0;

        int maxLength = 1;
        LinkedList<int> minDequeue = new LinkedList<int>();
        LinkedList<int> maxDequeue = new LinkedList<int>();
        while(end < nums.Length)
        {
            while(minDequeue.Count > 0 && minDequeue.Last.Value > nums[end])
            {
                minDequeue.RemoveLast();
            }

            while(maxDequeue.Count > 0 && maxDequeue.Last.Value < nums[end])
            {
                maxDequeue.RemoveLast();
            }

            minDequeue.AddLast(nums[end]);
            maxDequeue.AddLast(nums[end]);
            
            while(maxDequeue.Count>0 && minDequeue.Count > 0 && maxDequeue.First.Value - minDequeue.First.Value > limit)
            {
                if(maxDequeue.First.Value == nums[start])
                {
                    maxDequeue.RemoveFirst();
                }
                if(minDequeue.First.Value == nums[start])
                {
                    minDequeue.RemoveFirst();
                }

                start ++;
            }
            
            Console.WriteLine(String.Format("{0}-{1}", maxDequeue.First(),minDequeue.First()));
            Console.WriteLine(String.Format("{0}|{1}", start,end));
            maxLength = Math.Max(maxLength, end - start + 1);

            end ++;
        }

        return maxLength;
    }
}