using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamErrorHandlingGenerics
{
    internal class DynamicArray<T>
    {
        private int size;
        private T[] array;

        public DynamicArray()
        {
            size = 0;
            array = new T[0];
        }

        public DynamicArray(int size)
        {
            this.size = size;
            array = new T[size];
        }

        public DynamicArray(List<T> list)
        {
            size = list.Count;
            array = new T[size];
            for (int i = 0; i < size; i++)
                array[i] = list[i];
        }

        public void Push(T value)
        {
            array[size] = value;
            size++;
        }

        public T Pop()
        {
            if (size == 0)
                throw new ApplicationException("Cannot pop from empty array");
            size--;
            return array[size];
        }

        public int getSize() { return size; }

        public T getElement(int position)
        {
            if (position < 0)
                throw new ApplicationException("Array index cannot be negative");
            if (position >= size)
                throw new ApplicationException("Can't fetch element at position greater than size");
            return array[position];
        }
    }
}
