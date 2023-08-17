from typing import List


class Solution:
    def jump(self, nums: List[int]) -> int:
        size = len(nums)
        reach = []
        steps = [size + 1] * size
        steps[0] = 0

        for i in range(size):
            for j in range(1, nums[i] + 1):
                if i+j < size:
                    steps[i + j]= min(steps[i + j], steps[i] + 1)
        
        return steps[size -1]

instance = Solution()
print(instance.jump([2,3,1,1,4]))

