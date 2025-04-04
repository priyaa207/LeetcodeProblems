/*
 * @lc app=leetcode id=234 lang=csharp
 *
 * [234] Palindrome Linked List
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
    public bool IsPalindrome(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        while(fast != null && fast.next !=null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        ListNode prev = null;
        ListNode curr = slow;
        while(curr != null) {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        ListNode first = head;
        ListNode second = prev;
        while (second != null) {
            if(first.val != second.val){
                return false;
            }
            first = first.next;
            second = second.next;
        }

        return true;
    }
}
// @lc code=end

