from typing import List


class Solution:
    def threeSumClosest(self, nums: List[int], target: int) -> int:
        nums.sort()
        size = len(nums)
        result = float('inf')
        if size < 3: return 0

        i = 0
        while i < size -2:
            j = i + 1
            k = size -1
            while j<k:
                tmp = nums[i] + nums[j] + nums[k]
                if  tmp == target:
                    return target
                elif tmp >target:
                    k-=1
                else:
                    j+=1
                
                if abs(tmp - target) < abs(result - target):
                    result = tmp
            i+=1
        return result