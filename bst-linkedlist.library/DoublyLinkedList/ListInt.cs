using System;

namespace bst_linkedlist.library.DoublyLinkedList
{
    public class ListInt
    {
        public NodeInt First { get; private set; }
        public NodeInt Last { get; private set; }
        public bool IsEmpty => this.First == null;
        public int Length { get; private set; }

        public void Add(int value)
        {
            NodeInt newValue = new NodeInt(value);

            if (this.IsEmpty)
                this.First = newValue;
            else
                this.Last.Next = newValue;

            var oldLast = this.Last;
            this.Last = newValue;
            this.Last.Previous = oldLast;
            this.Length++;
        }

        public NodeInt Find(int value)
        {
            NodeInt currentNode = this.First;

            while (currentNode != null && currentNode.Value != value)
            {
                currentNode = currentNode.Next;
            }

            return currentNode;
        }

        public NodeInt Remove(int index)
        {
            if (index < 0 || index >= this.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (index == 0)
            {
                return RemoveFirst();
            }

            NodeInt toRemove = this.First;
            for (int i = 0; i < index; ++i)
            {
                toRemove = toRemove.Next;
            }

            RemoveNode(toRemove);

            this.Length--;
            return toRemove;
        }

        public NodeInt RemoveFirst()
        {
            if (this.IsEmpty)
            {
                throw new IndexOutOfRangeException("LinkedList is Empty. Cannot remove first element.");
            }

            if (this.Length == 1)
            {
                this.Last = null;
            }

            NodeInt toRemove = this.First;
            this.First = toRemove.Next;
            RemoveNode(toRemove);


            this.Length--;
            return toRemove;
        }

        public NodeInt RemoveLast()
        {
            if (this.IsEmpty)
            {
                throw new IndexOutOfRangeException("LinkedList is Empty. Cannot remove first element.");
            }

            if (this.Length == 1)
            {
                this.First = null;
            }

            NodeInt toRemove = this.Last;
            this.Last = toRemove.Previous;
            RemoveNode(toRemove);

            this.Length--;
            return toRemove;
        }

        private void RemoveNode(NodeInt toRemove)
        {
            if (toRemove.Next != null)
                toRemove.Next.Previous = toRemove.Previous;
            if (toRemove.Previous != null)
                toRemove.Previous.Next = toRemove.Next;
        }

        public void Clear()
        {
            this.First = null;
            this.Last = null;
            this.Length = 0;


            NodeInt node = this.Last;
            while (node != null)
            {
                node.Next = null;
                node = node.Previous;
            }
        }

        public override string ToString()
        {
            NodeInt node = this.First;

            var result = "";
            while (node != null)
            {
                result += node.ToString();
                node = node.Next;
                if (node != null)
                    result += " ";
            }

            return result;
        }
    }
}
