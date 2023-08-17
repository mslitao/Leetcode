from typing import List


class Solution:
    def fourSum(self, nums: List[int], target: int) -> List[List[int]]:
        if len(nums) < 4: return []
        nums.sort()
        results = []
        resultsDict = {}
        for i in range(len(nums) - 3):
            if i > 0 and nums[i] == nums[i - 1]:
                continue
            for j in range(i+1, len(nums) -2):
                if j > i + 1 and nums[j] == nums[j - 1]:
                    continue
                left = j+1
                right = len(nums) - 1
                while left < right:
                    if nums[i] + nums[j] + nums[left] + nums[right] == target:
                        result = [nums[i], nums[j], nums[left], nums[right]]
                        result.sort()

                        resultKey = ''.join([str(x) for x in result])
                        if resultKey not in resultsDict:
                            results.append(result)
                            resultsDict[resultKey] =1
                    
                    if nums[i] + nums[j] + nums[left] + nums[right] < target:
                        left +=1
                    else:
                        right -=1

        
        return results


instance = Solution()
print(instance.fourSum([0,0,0,0],0))