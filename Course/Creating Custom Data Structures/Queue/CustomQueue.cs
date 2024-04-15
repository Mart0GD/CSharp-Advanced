using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class CustomQueue
    {
        const int FirstItem = 0;
        const int InitialCapacity = 4;

        public CustomQueue()
        {
            Items = new int[InitialCapacity];
        }

        public int[] Items { get; private set; }
        public int Count { get; private set; }

        public void Enqueue(int item)
        {
            if (Items.Length == Count)
            {
                Resize();
            }

            Items[Count] = item;
            Count++;
        }

        public int Dequeue()
        {
            ThrowException();

            int dequeued = Items[FirstItem];
            ShiftLeft();

            Count--;
            return dequeued;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            Tuple<int,int> items = new(Items[firstIndex], Items[secondIndex]);

            Items[firstIndex] = items.Item2;
            Items[secondIndex] = items.Item1;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Items[i] == item)
                {
                    return true;
                }
            }

            return false;
        }

        private void ShiftLeft()
        {
            for (int i = FirstItem; i < Count - 1; i++)
            {
                Items[i] = Items[i + 1];
            }
        }

        public int Peek()
        {
            ThrowException();

            return Items[FirstItem];
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
                int currentItem = Items[i];

                action(currentItem);
            }
        }

      

        private void Resize()
        {
            int[] array = new int[Items.Length * 2];

            for (int i = 0; i < Count; i++)
            {
                array[i] = Items[i];
            }

            Items = array;
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
