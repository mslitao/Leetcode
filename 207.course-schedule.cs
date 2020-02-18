using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution207
{
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Dictionary<int, List<int>> courseMap = new Dictionary<int, List<int>>();
        for(int i =0; i< numCourses; ++i)
        {
            courseMap.Add(i, new List<int>());
        }
        for(int i = 0; i< prerequisites.Length; ++i)
        {
            var c1 = prerequisites[i][0];
            var c2 = prerequisites[i][1];
            var depends = courseMap[c1];
            depends.Add(c2);
            courseMap[c1] = depends;
        }
        
        HashSet<int> courseList = new HashSet<int>();
        foreach(var course in courseMap)
        {
            if(!DFSVisitCourses(courseMap, new HashSet<int>(), course.Key, courseList))
            {
                return false;
            }
        }

        return true;
    }

    public bool DFSVisitCourses(Dictionary<int, List<int>> courseMap, HashSet<int> targets, int current, HashSet<int> processed)
    {
        if(targets.Contains(current))
        {
            return false;
        }
        if(processed.Contains(current))
        {
            return true;
        }

        
        var depends = courseMap[current];
        if(depends.Count > 0) 
        {
            targets.Add(current);
            foreach(var d in depends)
            {
                if(!DFSVisitCourses(courseMap, targets, d, processed))
                    return false;
            }
            targets.Remove(current);
        }

        processed.Add(current);
        return true;
    }
}