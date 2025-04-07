/*
 * @lc app=leetcode id=61 lang=csharp
 *
 * [61] Rotate List
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
    public ListNode RotateRight(ListNode head, int k) {
        ListNode start = head;
        int length = 0;
        if(head == null || head.next == null){
            return head;
        }
        while(start != null){
            length++;
            start = start.next;
        }
        if(k==0|| (k % length == 0)){
            return head;
        }
        k = length - k%length;
        start = head;
        
        while(k>1 & start != null) {
            start = start.next;
            k--;
        }
        ListNode newHead = start.next;
        start.next = null;
        ListNode curr = newHead;
        while(curr != null && curr.next != null){
            curr = curr.next;
        }
        curr.next = head;
        return newHead;
    }
}
// @lc code=end

