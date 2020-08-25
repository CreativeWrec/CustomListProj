using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {

        T[] _items;

        int _capacity;
        int _count;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }

        public T this[int index]
        {
            get
            {
                return _items[index];
            }
            set
            {
                _items[index] = value;
            }
        }

        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _items = new T[_capacity];
        }

        public void Add(T item)
        {
            if (_count == _capacity)
            {
                _capacity *= 2;
                T[] size = _items;
                _items = new T[_capacity];

                for (int i = 0; i < _count; i++)
                {
                    _items[i] = size[i];
                }
            }
            _items[_count] = item;
            _count++;
        }

        public void Remove(T item)
        {
            if ()
            {

            }
        }

    }
}
