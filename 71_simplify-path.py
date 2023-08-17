class Solution:
    def simplifyPath(self, path: str) -> str:
        if not path or len(path) == 0 : return path

        items = [val for val in path.split('/') if(val and val != '.')]
        # print(items)
        
        routes = []
        for item in items:
            if item == '..':
                if len(routes) > 0:
                    routes.pop()
            else:
                routes.append(item)
        
        return '/'+'/'.join(routes)
    
instance = Solution()
print(instance.simplifyPath('/home/'))
print(instance.simplifyPath('/../'))
print(instance.simplifyPath('/home//foo/'))
