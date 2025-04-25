using System;

// using bst_linkedlist.library.SinglyLinkedList;
using bst_linkedlist.library.DoublyLinkedList;

namespace bst_linkedlist.library
{
    public class StackInt
    {
        // Gebruik je best de SinglyLinkedList of de DoublyLinkedList? (kies het juiste using statement bovenaan)
        private ListInt data = new ListInt();

        public bool IsEmpty => data.IsEmpty;

        public int Length => data.Length;

        public void Push(int newValue)
        {
            data.Add(newValue);
        }

        public int Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("ERROR: Can't dequeue an empty queue");
            }
            return data.RemoveLast().Value;
        }
    }
}
