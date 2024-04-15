using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        const int InitialCapacity = 4;

        public Stack()
        {
            Items = new int[InitialCapacity];
        }

        public int[] Items { get; private set; }
        public int Count { get; private set; }
        public bool IsEmpty 
        { 
            get
                { 
                    return Count == 0 ? true : false;
                }
            }
       

        public void Push(int item)
        {
            if (Items.Length == Count)
            {
                Resize();
            }

            Items[Count] = item;

            Count++;
        }

        public int Pop()
        {
            ThrowException();

            if (Items.Length / 4 >= Count)
            {
                Shrink();
            }
           

            int lastItem = Items[Count - 1];

            Count--;
            return lastItem;
        }

        public int Peek()
        {
            ThrowException();

            return Items[Count - 1];
        }

        public void Clear()
        {
            Items = new int[InitialCapacity];
            Count = 0;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                int currentNumber = Items[i];

                action(currentNumber);
            }
        }





        private void Resize()
        {
            int[] copyArray = new int[Items.Length * 2];

            for (int i = 0; i < Items.Length; i++)
            {
                copyArray[i] = Items[i];
            }

            Items = copyArray;
        }

        private void Shrink()
        {
            int[] copyArray = new int[Items.Length / 2];

            for (int i = 0; i < Count; i++)
            {
                copyArray[i] = Items[i];
            }

            Items = copyArray;
        }

        private void ValidateIndex(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private void ThrowException()
        {
            if (Count == 0)
            {
                throw new ArgumentException("Queue is Empty");
            }
        }

    }
}
