/*
 * @lc app=leetcode id=2095 lang=csharp
 *
 * [2095] Delete the Middle Node of a Linked List
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
    public ListNode DeleteMiddle(ListNode head) {
        if(head.next == null){
            return null;
        }
        ListNode slow = head;
        ListNode fast = head;
        while(fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        if(slow.next != null) {
        slow.val=slow.next.val;
        slow.next= slow.next.next;
        }
        else{
            head.next=null;
            
        }
        
        return head;
    }
}
// @lc code=end

