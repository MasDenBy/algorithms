using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class BynaryLinkedList
	{
        public int GetDecimalValue(LinkedListNode<byte> head)
        {
            var sb = new StringBuilder();

            var node = head;
            while (node != null)
            {
                sb.Append(node.Value);
                node = node.Next;
            }

            return Convert.ToInt32(sb.ToString(), 2);
        }
    }
}