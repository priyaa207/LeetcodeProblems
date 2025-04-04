/*
 * @lc app=leetcode id=142 lang=csharp
 *
 * [142] Linked List Cycle II
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        if (head == null || head.next == null) {
            return null;
        }
        while(fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast) {
                break; 
            }
        }
        if(fast == null || fast.next == null) {
            return null;
        }
        slow = head;
        while( slow != fast) {
            slow= slow.next;
            fast = fast.next;
            
        }
        
        return slow;
    }
}
// @lc code=end

