using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class DoublyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void AddFirst(int number)
        {
            Node newHead = new Node(number);

            if (Head == null)
            {
                Head = newHead;
                Tail = newHead;

                return;
            }

            Head.Previous = newHead;
            newHead.Next = Head;
            Head = newHead;
        }

        public void AddLast(int number)
        {
            Node newTail = new Node(number);

            if (Tail == null)
            {
                Tail = newTail;
                Head = newTail;

                return;
            }

            Tail.Next = newTail;
            newTail.Previous = Tail;
            Tail = newTail;
        }

        public Node RemoveFirst()
        {
            if (Head == null)
            {
                return null;
            }

            Node removedNode = Head;
            if (Head.Previous == null && Head.Next == null)
            {
                Head =  null;
                return removedNode;
            }

            Head = removedNode.Next;
            Head.Previous = null;

            return removedNode;
        }

        public Node RemoveLast()
        {
            if (Tail == null)
            {
                return null;
            }

            Node removedNode = Tail;
            if (Head.Previous == null && Head.Next == null)
            {
                Tail = null;
                return removedNode;
            }

            Tail = removedNode.Previous;
            Tail.Next = null;

            return removedNode;
        }

        public void ForEach(Action<Node> action)
        {
            Node currentNode = Head;

            while (currentNode != null)
            {
                action(currentNode);
                currentNode = currentNode.Next;
            }
        }

        public int Count()
        {
            int count = 0;
            this.ForEach(x => count++);

            return count;
        }

        public int[] ToArray()
        {
            Node currentNode = Head;

            int listCount = Count();

            int[] array = new int[listCount];
            for (int i = 0; i < listCount; i++)
            {
                array[i] = currentNode.Value;
                currentNode = currentNode.Next;
            }

            return array;
        }
    }
}
