using System;

namespace bst_linkedlist.library.DoublyLinkedList
{
    public class NodeInt
    {
        public int Value { get; set; }
        public NodeInt Next { get; set; }
        public NodeInt Previous { get; set; }

        public NodeInt(int value = 0)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
