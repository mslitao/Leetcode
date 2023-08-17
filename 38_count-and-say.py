class Solution:
    def countAndSay(self, n: int) -> str:
        word = '1'
        for i in range(n -1):
            newWord = ''
            curChar = ''
            curCount = 0
            for j in range(len(word)):
                if j == 0 or word[j] == word[j-1]:
                    curChar = word[j]
                    curCount +=1
                else:
                    newWord += str(curCount)
                    newWord += curChar
                    curCount = 1
                    curChar = word[j]
            
            newWord += str(curCount)
            newWord += curChar
            word = newWord
        
        return word

instance = Solution()
print(instance.countAndSay(1))
print(instance.countAndSay(2))
print(instance.countAndSay(3))
print(instance.countAndSay(4))
print(instance.countAndSay(5))
print(instance.countAndSay(6))
                    


