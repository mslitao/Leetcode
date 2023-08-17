class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        items = s.split(' ')
        i = len(items) -1
        print(items)
        while i>=0:
            res = len(items[i])
            if res >0: return res
            i-=1
        
        return 0

instance = Solution()
print(instance.lengthOfLastWord('hello world'))