using System.Threading.Channels;

var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
var result = AddTwoNumbers(l1, l2);
while (result != null)
{
    Console.Write(result.val);
    result = result.next;
}



//2. AddTwoNumbers
//Difficulty : Medium
//Link : https://leetcode.com/problems/add-two-numbers/
ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    var result = new ListNode();
    //定义一个变量用来存储当前节点
    var current = result;
    //定义一个变量用来存储进位
    var carry = 0;
    while (l1 != null || l2 != null)
    {
        var sum = carry;
        if (l1 != null)
        {
            sum += l1.val;
            l1 = l1.next;
        }

        if (l2 != null)
        {
            sum += l2.val;
            l2 = l2.next;
        }

        current.next = new ListNode(sum % 10);
        current = current.next;
        carry = sum / 10;
    }

    if (carry > 0)
    {
        current.next = new ListNode(carry);
    }

    return result.next;
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}