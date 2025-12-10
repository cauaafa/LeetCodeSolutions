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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode list = new ListNode();
        list.next = new ListNode();
        ListNode last = list;

        while(list1 != null && list2 != null) {
            last = last.next;
            last.next = new ListNode();

            if (list1.val < list2.val) {
                last.val = list1.val;
                list1 = list1.next;
            } else {
                last.val = list2.val;
                list2 = list2.next;
            }

        }

        while(list1 != null) {
            last = last.next;
            last.next = new ListNode();

            last.val = list1.val;
            list1 = list1.next;
        }

        while(list2 != null) {
            last = last.next;
            last.next = new ListNode();

            last.val = list2.val;
            list2 = list2.next;
        }

        last.next = null;

        return list.next;
    }
}