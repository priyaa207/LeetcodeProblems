/*
 * @lc app=leetcode id=2181 lang=csharp
 *
 * [2181] Merge Nodes in Between Zeros
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
    public ListNode MergeNodes(ListNode head) {
         ListNode curr=head;
        while (curr != null && curr.next != null) {
            if (curr.next.val != 0) {
                curr.val += curr.next.val;
                curr.next = curr.next.next; 
            }
            else { 
               curr = curr.next;
            }
            
            if(curr.next != null && curr.next.val == 0 && curr.next.next == null){
                curr.next =null;
            }

        }
        return head;
    }
}
// @lc code=end

