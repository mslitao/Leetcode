from typing import List


class Solution:
    def subsets(self, nums: List[int]) -> List[List[int]]:
        results = []
        results.append([])
        size = len(nums)
        for i in range(size):
            tmpCnt = len(results)
            for j in range(tmpCnt):
                tmp = results[j][:]
                tmp.append(nums[i])
                results.append(tmp)
        
        return results
    
    def subsets2(self, nums: List[int]) -> List[List[int]]:
        res = []
        self.btSubsets(sorted(nums), 0, [], res)
        return res

    def btSubsets(self, nums, index, path, res):
        res.append(path)

        for i in range(index, len(nums)):
            self.btSubsets(nums, i+1, path + [nums[i]], res)

instance = Solution()
#print(instance.subsets([1,2,3]))
print(instance.subsets2([1,2,3]))
print(instance.subsets1([1,2,3]))