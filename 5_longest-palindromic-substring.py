class Solution:
    def searchPalindrom(self, s:str, left: int, right:int, start: int, max: int) :
        while left>=0 and right<len(s) and s[left]==s[right]:
            left-=1
            right +=1

        if right - left -1 >  max:
            start = left + 1
            max = right - left -1
        
        return start, max
    
    def longestPalindrome(self, s: str) -> str:
        if not s or len(s) < 2:
            return s
        start = 0
        max = 0
        for i in range(len(s)):
            start, max = self.searchPalindrom(s, i, i, start, max)
            start, max = self.searchPalindrom(s, i, i+1, start, max)
        
        #print("# start : %2d, max : %2d" % (start, max))
        return s[start:start+max]

    
instance = Solution()
print(instance.longestPalindrome(''))
print(instance.longestPalindrome('babad'))
print(instance.longestPalindrome('cbbd'))