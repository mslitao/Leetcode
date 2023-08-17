from typing import List


class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        items = {}
        for s in strs:
            key = self.genKey(s)
            if key in items:
                items[key].append(s)
            else:
                items[key] = [s]
        return list(items.values())

    def genKey(self, s: str) -> str:
        keyStats = [0] * 26
        for c in s:
            keyStats[ord(c) - ord('a')] +=1
        print(s)
        print(keyStats)
        return ''.join(str(x)+'-' for x in keyStats)

instance = Solution()
# print(instance.groupAnagrams(["eat","tea","tan","ate","nat","bat"]))
print(instance.groupAnagrams(["bdddddddddd","bbbbbbbbbbc"]))