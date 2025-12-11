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
    public ListNode ReverseKGroup(ListNode head, int k) {
        if (head == null || k == 1) {
            return head;
        }

        ListNode cur = head;
        int count = 0;

        while (cur != null && count < k) {
            cur = cur.next;
            count++;
        }

        if (count < k) {
            return head;
        }

        ListNode prev = null;
        ListNode next = null;
        cur = head;
        for (int i = 0; i< k; i++) {
            next = cur.next;
            cur.next = prev;
            prev = cur;
            cur = next;
        }

        head.next = ReverseKGroup(cur, k);

        return prev;
    }
}