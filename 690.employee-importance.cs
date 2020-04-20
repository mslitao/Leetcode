using System;
using System.Collections.Generic;
using System.Linq;

class Solution690
{
    // Employee info
    public class Employee {
        // It's the unique id of each node;
        // unique id of this employee
        public int id;
        // the importance value of this employee
        public int importance;
        // the id of direct subordinates
        public IList<int> subordinates;
    }

    public int GetImportance(IList<Employee> employees, int id) {
        Dictionary<int, Employee> map = new Dictionary<int, Employee>();
        foreach(var employee in employees)
        {
            map.Add(employee.id, employee);
        }

        Queue<Employee> queue = new Queue<Employee>();
        queue.Enqueue(map[id]);
        int importance = 0;
        while(queue.Any())
        {
            var emp = queue.Dequeue();
            importance +=emp.importance;
            if(emp.subordinates!= null)
            {
                foreach(var sub in emp.subordinates)
                {
                    queue.Enqueue(map[sub]);
                }
            }
        }

        return importance;
    }
}