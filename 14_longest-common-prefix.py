from typing import List


class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        longestPrefix = ''
        if not strs or len(strs) ==0: return longestPrefix
        pos = 0

        while True:
            i = 0
            while i < len(strs):
                current = strs[i]
                if not current or pos >= len(current) or current[pos] != strs[0][pos]:
                    break

                i +=1

            if i == len(strs):
                longestPrefix+=strs[0][pos]
                pos+=1
            else:
                break
        
        return longestPrefix

            
instance = Solution()
print(instance.longestCommonPrefix(["flower","flow","flight"]))