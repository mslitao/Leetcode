from filecmp import cmp
from typing import List


class Solution:
    def merge(self, intervals: List[List[int]]) -> List[List[int]]:
        if len(intervals) < 2: return intervals
        # sorted(intervals, key =lambda x: x[0])
        intervals.sort()
        print(intervals)

        results = []
        start = intervals[0][0]
        end = intervals[0][1]
        intervals.pop(0)
        for interval in intervals:
            if interval[0] > end:
                results.append([start, end])
                start = interval[0]
                end = interval[1]
            elif interval[1] > end:
                end = interval[1]

        results.append([start, end])
        
        return results


instance = Solution()
print(instance.merge([[1,4],[0,4]]))