namespace Playground.HackerRank
{
    public static class ArrayLeftRotation
    {
        public static int[] Rotate(int[] a, int d)
        {
            ListNode head = new ListNode { Value = a[0] };
            var previous = head;

            for (var i = 1; i < a.Length; i++)
            {
                var node = new ListNode { Value = a[i] };
                previous.Next = node;
                previous = node;
            }

            previous.Next = head;

            for (var i = 0; i < d; i++)
            {
                head = head.Next;
            }

            var rotatedArray = new int[a.Length];

            var current = head;
            for (var i = 0; i < a.Length; i++)
            {
                rotatedArray[i] = current.Value;
                current = current.Next;
            }

            return rotatedArray;
        }

        public class ListNode
        {
            public int Value { get; set; }

            public ListNode Next { get; set; }
        }
    }
}
