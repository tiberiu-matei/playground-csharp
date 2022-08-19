using System;

namespace Playground.LeetCode
{
    public class AddTwoNumbers
    {
        public ListNode AddTwoNumbersOne(ListNode l1, ListNode l2)
        {
            ulong sum = 0;
            var level = 0;
            while (l1 != null || l2 != null)
            {
                var currentBase = (ulong)Math.Pow(10, level);
                sum = sum + (ulong)(l1?.val ?? 0) * currentBase + (ulong)(l2?.val ?? 0) * currentBase;

                l1 = l1?.next;
                l2 = l2?.next;
                level++;
            }

            ListNode firstNode = new ListNode((int)(sum % 10));
            sum = sum / 10;
            ListNode previousNode = firstNode;
            while (sum > 0)
            {
                var currentNode = new ListNode((int)(sum % 10));
                previousNode.next = currentNode;
                previousNode = currentNode;

                sum = sum / 10;
            }

            return firstNode;
        }

        public ListNode AddTwoNumbersTwo(ListNode l1, ListNode l2)
        {
            int sum = l1.val + l2.val;
            l1 = l1.next;
            l2 = l2.next;
            ListNode firstNode = new ListNode(sum % 10);
            sum /= 10;
            var previousNode = firstNode;
            while (l1 != null || l2 != null || sum != 0)
            {
                sum = sum + (l1?.val ?? 0) + (l2?.val ?? 0);

                l1 = l1?.next;
                l2 = l2?.next;

                var currentNode = new ListNode(sum % 10);
                previousNode.next = currentNode;
                previousNode = currentNode;

                sum = sum / 10;
            }

            return firstNode;
        }
    }
}
