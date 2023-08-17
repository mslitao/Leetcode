from typing import List


class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        results =[]
        resultsDict ={}
        for i in range(len(nums)):
            target = -nums[i]

            j = i+1
            numDict = {}
            while j < len(nums):
                tmp = target - nums[j]

                if tmp in numDict: 
                    result = [nums[i], nums[numDict[tmp]], nums[j]]
                    result.sort()

                    resultKey = ''.join([str(x) for x in result])
                    if resultKey not in resultsDict:
                        results.append(result)
                        resultsDict[resultKey] =1


                
                numDict[nums[j]] = j
                j+=1
            
        
        return results

instance = Solution()
print(instance.threeSum([-1,0,1,2,-1,-4]))
