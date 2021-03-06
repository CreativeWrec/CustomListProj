﻿using System;
using System.Collections;
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
        // { 1, 2, 4, 5, 5 } 
        public bool Remove(T item) // (removing 3)
        {
            bool haveRemovedItem = false;

            for (int i = 0; i < _count; i++)
            {
                if(item.Equals(_items[i]))
                {
                    _items[i] = _items[i + 1];
                    haveRemovedItem = true; // "shift" the item over one spot
                }
                else // item we are on doesn't match the item to remove
                {
                    if (haveRemovedItem) // if we have already removed the item
                    {
                        _items[i] = _items[i + 1];
                        // then we want to do the "shift" again
                    }
                }
            }

            if (haveRemovedItem)
            {
                _count--;
                
            }
            return haveRemovedItem;
            // decrement the count, only if an item was removed
        }
        public override string ToString()
        {
            string toString = "";
            for (int i = 0; i < _count; i++)
            {
                toString += _items[i].ToString();
            }
            return toString;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _items[i];
            }
        }
        public static CustomList<T> operator +(CustomList<T> customList, CustomList<T> customListTwo)
        {
            CustomList<T> results = new CustomList<T>();
            for (int i = 0; i < customList.Count; i++)
            {
                results.Add(customList[i]);
            }
            for (int i = 0; i < customListTwo.Count; i++)
            {
                results.Add(customListTwo[i]);
            }
            return results;
        }

        public static CustomList<T> operator -(CustomList<T> customList, CustomList<T> customListTwo)
        {
            CustomList<T> results = new CustomList<T>();
            results = customList;
            foreach (T item in customListTwo)
            {
                results.Remove(item);
            }
            return results;
        }
        public CustomList<T> Zip(CustomList<T> customList, CustomList<T> customListTwo)
        {
            CustomList<T> zipResults = new CustomList<T>();
            if (Count == customListTwo.Count)
            {
                for (int i = 0; i < Count; i++)
                {
                    zipResults.Add(customList[i]);
                    zipResults.Add(customListTwo[i]);
                }
            }
            return zipResults;
        }
    }
}
