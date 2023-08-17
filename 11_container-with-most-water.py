from typing import List


class Solution:
    def maxArea(self, height: List[int]) -> int:
        result, current = 0
        for i in range(len(height)-1):
            for j in range(i+1, len(height)):
                current = max(result, (j-i)* min(height[i], height[j]))