using System;
using bst_linkedlist.library.SinglyLinkedList;

namespace bst_linkedlist.library
{
    public class BubbleSort
    {
        public static void Sort(ListInt input)
        {
            for (var i = 0; i < input.Length; ++i)
            {
                for (NodeInt current = input.First; current.Next != null; current = current.Next)
                {
                    if (current.Value > current.Next.Value)
                    {
                        (current.Value, current.Next.Value) = (current.Next.Value, current.Value);
                    }
                }
            }
        }
    }
}
