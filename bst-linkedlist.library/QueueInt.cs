using System;

using bst_linkedlist.library.SinglyLinkedList;
// using bst_linkedlist.library.DoublyLinkedList;

namespace bst_linkedlist.library
{
    public class QueueInt
    {
        // Gebruik je best de SinglyLinkedList of de DoublyLinkedList? (kies het juiste using statement bovenaan)
        private ListInt _data = new ListInt();
        public bool IsEmpty => this._data.IsEmpty;

        public int Length => this._data.Length;

        public QueueInt()
        {
        }

        public void Enqueue(int newValue)
        {
            this._data.Add(newValue);
        }

        public int Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("ERROR: Can't dequeue an empty queue");
            }
            return this._data.RemoveFirst().Value;
        }
    }
}
