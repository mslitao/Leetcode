from typing import List


class Solution:
    def insert(self, intervals: List[List[int]], newInterval: List[int]) -> List[List[int]]:
        size = len(intervals)
        if size == 0: return [newInterval]

        for i in range(size):
            if intervals[i][0] > newInterval[0]:
                intervals.insert(i, newInterval)
                break
        if len(intervals) == size : 
            intervals.append(newInterval)

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
        
