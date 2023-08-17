from typing import List


class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        size = len(nums)
        if size == 0: return 0
        if size == 1: return nums[0]
        maxsum = float('-inf')
        sum = 0

        for num in nums:
            sum = max(sum + num, num)
            maxsum = max(sum, maxsum)
        return maxsum