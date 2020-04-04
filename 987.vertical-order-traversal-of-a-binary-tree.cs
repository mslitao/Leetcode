using System;
using System.Collections.Generic;
using System.Linq;


public class Solution987
{
    
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        Dictionary<int, IList<int>> orderByIndex = new Dictionary<int, IList<int>>();
        if(root == null) return orderByIndex.Values.ToList();

        Queue<TreeNode> queueNode = new Queue<TreeNode>();
        Queue<int> queueIdx = new Queue<int>();
        queueNode.Enqueue(root);
        queueIdx.Enqueue(0);

        while(queueNode.Any())
        {
            Dictionary<int, IList<int>> tmpMap = new Dictionary<int, IList<int>>();
            int cnt = queueNode.Count;
            while(cnt >0)
            {
                var node = queueNode.Dequeue();
                var idx = queueIdx.Dequeue();

                if(!tmpMap.ContainsKey(idx))
                {
                    tmpMap.Add(idx, new List<int>());
                }

                var tmp = tmpMap[idx];
                tmp.Add(node.val);
                tmpMap[idx] = tmp;

                if(node.left != null)
                {
                    queueNode.Enqueue(node.left);
                    queueIdx.Enqueue(idx - 1);
                }

                if(node.right != null)
                {
                    queueNode.Enqueue(node.right);
                    queueIdx.Enqueue(idx + 1);
                }

                cnt --;
            }

            foreach(var item in tmpMap)
            {
                var dataList = item.Value.ToList();
                dataList.Sort();

                if(!orderByIndex.ContainsKey(item.Key))
                {
                    orderByIndex.Add(item.Key, new List<int>());
                }

                var tmp = orderByIndex[item.Key];
                foreach(var data in dataList)
                {
                    tmp.Add(data);
                }
                orderByIndex[item.Key] = tmp;
            }
        }

        return orderByIndex.OrderBy(n=> n.Key).Select(n=>n.Value).ToList();
    }

}