using System;

namespace Playground.LeetCode.Trees
{
    public static class BinaryTreeMaxDepth
    {
        public static int MaxDepth(BinaryTreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }
    }
}
