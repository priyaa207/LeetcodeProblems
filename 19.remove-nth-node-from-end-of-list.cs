/*
 * @lc app=leetcode id=19 lang=csharp
 *
 * [19] Remove Nth Node From End of List
 */

// @lc code=start
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode curr = head;
        int count = 0;
        while(curr != null) {
            count++;
            curr = curr.next;
        }
        
        int i = count-n-1;
        curr = head;
        while(i>0){
            curr = curr.next;
            i--;
        }
        if(curr.next == null){
            return null;
        }
        if(count == n){
            return head.next;
        }
        curr.next=curr.next.next;
        

        return head;
        
    }
}
// @lc code=end

