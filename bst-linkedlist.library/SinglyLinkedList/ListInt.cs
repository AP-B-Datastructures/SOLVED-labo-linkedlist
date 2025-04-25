using System;

namespace bst_linkedlist.library.SinglyLinkedList
{
    public class ListInt
    {
        public NodeInt First { get; private set; }
        public NodeInt Last  { get; private set; }
        public bool IsEmpty => this.First == null;
        public int Length { get; private set; }

        public void Add(int value)
        {
            NodeInt newValue = new NodeInt(value);

            if (this.IsEmpty)
                this.First = newValue;
            else
                this.Last.Next = newValue;

            this.Last = newValue;
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

            NodeInt beforeIndex = this.First;

            for (int i = 1; i < index - 1; ++i)
            {
                beforeIndex = beforeIndex.Next;
            }

            NodeInt toRemove = beforeIndex.Next;

            beforeIndex.Next = beforeIndex.Next.Next;

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

            this.First = this.First.Next;

            this.Length--;
            return toRemove;
        }

        public NodeInt RemoveLast()
        {
            return Remove(this.Length - 1);
        }

        public void Clear()
        {
            this.First = null;
            this.Last = null;
            this.Length = 0;
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
