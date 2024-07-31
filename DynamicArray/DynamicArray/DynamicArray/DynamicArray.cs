using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTasks.DynamicArray
{
    public class DynamicArray
    {
        private int[] _array;
        private int _capacity;
        private int _length = 0;
        public DynamicArray(int capacity)
        {
            _array = new int[capacity];
            _capacity = capacity;
        }

        public int Get(int i)
        {
            return _array[i];
        }

        public void Set(int i, int n)
        {
            _array[i] = n;

        }

        public void PushBack(int n)
        {
            if (_length == _capacity)
            {
                _capacity++;
                int[] newArr = new int[_capacity];
                for (int i = 0; i < _length; i++)
                {
                    newArr[i] = _array[i];
                }
                newArr[_length] = n;
                _length++;
                _array = newArr;
                return;
            }
            _array[_length] = n;
            _length++;
        }

        public int PopBack()
        {
            if (_length == 0)
            {
                return -1;
            }
            _length--;
            int popped = _array[_length];
            _array[_length] = 0;
            return popped;
        }

        private void Resize()
        {
            _capacity *= 2;
            int[] newArr = new int[_capacity];
            for (int i = 0; i < _length; i++)
            {
                newArr[i] = _array[i];
            }
            _array = newArr;
        }

        public int GetSize()
        {
            return _length;
        }

        public int GetCapacity()
        {
            return _capacity;
        }
    }

}
