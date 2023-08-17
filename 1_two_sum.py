from typing import List


class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        d = {}
        for idx, val in enumerate(nums):
            tmp = target - val
            if tmp in d: return [d[tmp], idx ]
            else: d[val] = idx

instance = Solution()
print(instance.twoSum([2,7,11,15], 9)) 