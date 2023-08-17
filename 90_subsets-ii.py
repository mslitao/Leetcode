from typing import List


class Solution:
    def subsetsWithDup(self, nums: List[int]) -> List[List[int]]:
        nums = sorted(nums)
        print(nums)
        results = []
        current = []
        self.btSubsets(nums,0, len(nums), current, results)
        return results

    def btSubsets(self, nums, idx, n, current, results) :
        results.append(current[:])
        i = idx
        while i < n:
            current.append(nums[i])
            self.btSubsets(nums, i + 1, n, current, results)
            current.pop()
            while i + 1 < n and nums[i + 1] == nums[i]:
                i +=1
            i +=1

instance = Solution()
print(instance.subsetsWithDup([4,4,4,1,4]))