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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        return JoinNumbers(l1, l2);
    }

    public ListNode JoinNumbers(ListNode l1, ListNode l2) {
        ListNode newList = new ListNode();
        ListNode list = newList;

        bool isAdd = false;

        while (l1 != null && l2 != null){
            int x = l1.val + l2.val + ( isAdd ? 1 : 0);
            if (x >= 10) {
                isAdd = true;
                x -= 10;
            } else {isAdd = false;};
            list.val = x;

            l1 = l1.next;
            l2 = l2.next;
            if (l1 != null || l2 != null) {
                list.next = new ListNode();
                list = list.next;
            } else { break;}
        }

        while(l1 != null) {
            int x = l1.val + (isAdd ? 1 : 0);
            if (x >= 10) {
                isAdd = true;
                x -= 10;
            } else {isAdd = false;};

            list.val = x;


            if (l1.next != null) {
                Console.WriteLine(l1.val);
                list.next = new ListNode();
                list = list.next;
                l1 = l1.next;
            } else { break; }
        }

        while(l2 != null) {
            int x = l2.val + (isAdd ? 1 : 0);
            if (x >= 10) {
                isAdd = true;
                x -= 10;
            } else {isAdd = false;};

            list.val = x;

            if (l2.next != null) {
                Console.WriteLine(l2.val);
                list.next = new ListNode();
                list = list.next;
                list.val = x;
                l2 = l2.next;
            } else { break; }
        }

        if (isAdd == true) {
            list.next = new ListNode();
            list.next.val = 1;
        }

        return newList;
    }
}