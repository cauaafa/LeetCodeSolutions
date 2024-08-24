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
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode cur = head;
        ListNode last = null;
        ListNode post = null;
        while (cur != null)
        {
            post = cur.next;
            cur.next = last;
            last = cur;
            cur = post;
        }
        return last;
    }
}