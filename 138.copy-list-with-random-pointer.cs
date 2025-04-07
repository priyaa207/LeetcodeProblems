/*
 * @lc app=leetcode id=138 lang=csharp
 *
 * [138] Copy List with Random Pointer
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        
        Node temp = head;
        if(head == null) {
            return null;
        }
        while(temp != null) {
            Node copy = new Node(temp.val);
            copy.next = temp.next ;
            temp.next = copy;
            temp = copy.next ;
        }
        temp = head;
        while (temp != null) {
            if( temp.random != null) {
                temp.next.random = temp.random.next;
            }
            temp = temp.next.next;
        }
        Node dummy = new Node (-1);
        Node newcopy = dummy;

        temp = head;

        while (temp != null) {
            newcopy.next = temp.next;
            newcopy = newcopy.next;
            temp.next = temp.next.next;
            temp = temp.next;

        }
        return dummy.next;
    }
    
}
// @lc code=end

