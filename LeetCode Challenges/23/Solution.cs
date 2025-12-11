/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0) return null;

        PriorityQueue<ListNode, int> q = new PriorityQueue<ListNode, int>();

        foreach (var node in lists) {
            if (node != null) {
                q.Enqueue(node, node.val);
            }
        }

        ListNode dummy = new ListNode();
        ListNode cur = dummy;

        while(q.Count > 0) {
            ListNode node = q.Dequeue();
            cur.next = node;
            cur = cur.next;

            if (node.next != null) {
                q.Enqueue(node.next, node.next.val);
            }
        }

        return dummy.next;
    }
}