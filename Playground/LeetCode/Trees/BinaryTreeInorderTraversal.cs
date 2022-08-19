using System.Collections.Generic;

namespace Playground.LeetCode.Trees
{
    public static class BinaryTreeInorderTraversal
    {
        public static IList<int> InorderTraversal(BinaryTreeNode root)
        {
            var items = new List<int>();

            if (root == null)
            {
                return items;
            }

            if (root.left != null)
            {
                items.AddRange(InorderTraversal(root.left));
            }

            items.Add(root.val);

            if (root.right != null)
            {
                items.AddRange(InorderTraversal(root.right));
            }

            return items;
        }
    }
}
