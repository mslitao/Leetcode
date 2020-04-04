using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



//Definition for a binary tree node.
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class Codec {
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        List<string> values = new List<string>();
        PreOrderTraverse(root, values);
        
        //Console.WriteLine(string.Join("|", values));
        return string.Join("|", values);
        
    }

    public void PreOrderTraverse(TreeNode root, List<string> values)
    {
        if(root == null) 
        {
            values.Add("null");
            return;
        }
        values.Add(root.val.ToString());
        PreOrderTraverse(root.left, values);
        PreOrderTraverse(root.right, values);
    }

    public TreeNode PreOrderTraverse(List<string> values, ref int i)
    {
        if(i >= values.Count)
            return null;
        
        if(values[i] == "null") 
        {
            i++;
            return null;
        }

        TreeNode node = new TreeNode(int.Parse(values[i]));
        i++;
        
        node.left = PreOrderTraverse(values, ref i);
        node.right = PreOrderTraverse(values, ref i);
        
        return node;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if(string.IsNullOrEmpty(data)) return null;
        List<string> values = data.Split('|').ToList();

        int index = 0;
        return PreOrderTraverse(values,ref  index);
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));