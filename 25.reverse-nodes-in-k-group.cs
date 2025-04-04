/*
 * @lc app=leetcode id=25 lang=csharp
 *
 * [25] Reverse Nodes in k-Group
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
    public ListNode ReverseKGroup(ListNode head, int k) {
        ListNode prevLast = null;
        ListNode newHead = head;
        ListNode curr = head;
        while (curr != null) {
            ListNode start = curr;
            ListNode end = getKthNode(start,k);
            if( start != end) {
                ListNode temp = end.next;
                end.next = null ;
                ListNode reverseStart = ReverseList(start);
                if(prevLast != null){
                    prevLast.next = reverseStart;
                }
                else {
                    newHead=reverseStart;
                }
                ListNode reverseEnd = getKthNode(reverseStart,k);
                prevLast=reverseEnd;
                reverseEnd.next=temp;
                curr = temp;
            }
            else{
                break;
            }

        }
        return newHead;

    }

    public ListNode ReverseList (ListNode start) {
        ListNode curr = start;
        ListNode prev = null;
        while(curr != null) {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        return prev;
    }

    public ListNode getKthNode(ListNode start, int k) {
        ListNode end = start;
        k=k-1;
        while (k>0 && end.next != null) {
            end = end.next;
            k--;
        }
        if(k==0) {
            return end; 
        }
        else {
            return start;
        }
    }
}
// @lc code=end

