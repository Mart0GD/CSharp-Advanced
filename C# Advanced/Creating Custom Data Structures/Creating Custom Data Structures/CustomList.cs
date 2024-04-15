using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Custom_Data_Structures
{
    public class CustomList
    {
        private const int StartCapacity = 2;

        public CustomList()
        {
            Items = new int[StartCapacity];
        }

        public int[] Items { get; set; }
        public int Count { get; private set; }
        public int this[int index]
        {
            get
            {
                ValidateIndex(index);
                return Items[index];
            }
            set
            {
                ValidateIndex(index);
                Items[index] = value;
            }
        }

        public void Add(int number)
        {
            if (Items.Length == Count)
            {
                Resize();
            }

            Items[Count] = number;

            Count++;
        }

        public int RemoveAt(int index)
        {
            ValidateIndex(index);

            int removedNum = Items[index];
            ShiftLeft(index);

            Count--;
            if (Items.Length / 4 >= Count)
            {
                Shrink();
            }

            return removedNum;
        }

        public void InsertAt(int index, int number)
        {
            ValidateIndex(index);

            if (Items.Length == Count + 1)
            {
                Resize();
            }

            ShiftRigth(index);

            Items[index] = number;

            Count++;
        }

        public void Swap(int firstIndex, int SecondIndex)
        {
            Tuple<int,int> indexes = new Tuple<int, int>(Items[firstIndex], Items[SecondIndex]);

            Items[firstIndex] = indexes.Item2;
            Items[SecondIndex] = indexes.Item1;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i] == item)
                {
                    return true;
                }
            }

            return false;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                int currentNumber = Items[i];

                action(currentNumber);
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];

            int index = 0;
            ForEach(x =>
            {   
                array[index] = Items[index];
                index++;
            });

            return array;
        }

        private void ShiftLeft(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                Items[i] = Items[i + 1];
            }
            
        }

        private void ShiftRigth(int index)
        {
            for (int i = Count; i > index; i--)
            {
                Items[i] = Items[i - 1];
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
    }
}
