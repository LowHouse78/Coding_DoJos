using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList.Kata
{
    public class LinkedList<T> : IList<T>
    {
        internal class Element<T2>
        {
            internal Element(T2 item)
            {
                Item = item;
            }
            internal T2 Item { get; set; }
            internal Element<T2> Next { get; set; }
        }

        private Element<T> _anchor;


        public int Count
        {
            get
            {
                if (_anchor == null) return 0;
                var current = _anchor;
                var counter = 1;
                while (current.Next != null)
                {
                    counter++;
                    current = current.Next;
                }
                return counter;
            }

        }

        public bool IsReadOnly => throw new NotImplementedException();

        public T this[int index] 
        {
            get
            {
                if (_anchor == null)
                {
                    throw new IndexOutOfRangeException();
                }

                var current = _anchor;
                var count = 0;
                while (current != null && count++ < index )
                {
                    current = current.Next;
                }

                return current.Item;
            }

            set
            {
                if (_anchor == null)
                {
                    throw new IndexOutOfRangeException();
                }

                var current = _anchor;
                var count = 0;
                while (current != null && count++ < index )
                {
                    current = current.Next;
                }
                current.Item = value;

            }
        }

        public void Add(T item)
        {
            var element = new Element<T>(item);

            if (_anchor == null)
            {
                _anchor = element;
                return;
            }

            var current = _anchor;
            while (current.Next != null)
            {
                 current = current.Next;
            }
            current.Next = element;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
