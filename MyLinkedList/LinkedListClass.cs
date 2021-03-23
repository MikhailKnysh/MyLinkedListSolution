using System;

namespace MyLinkedList
{
    public class LinkedListClass<T> : IList<T> where T : IComparable
    {
        public Node<T> Head { get; set; }
        
        public Node<T> Tail { get; set; }

        public int Count { get; set; }

        public LinkedListClass()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public LinkedListClass(T data)
        {
            if(data!= null)
            {
                Node<T> item = new Node<T>(data);
                Head = item;
                Tail = item;
                ++Count;
            }
            else
            {
                throw new ArgumentNullException("Null data passed");
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public T[] ToArray()
        {
            throw new NotImplementedException();
        }

        public void AddStart(T value)
        {
            throw new NotImplementedException();
        }

        public void Add(T value)
        {
            throw new NotImplementedException();
        }

        public void AddByIndex(int index, T value)
        {
            throw new NotImplementedException();
        }

        public void AddRangeStart(T[] collection)
        {
            throw new NotImplementedException();
        }

        public void AddRange(T[] collection)
        {
            throw new NotImplementedException();
        }

        public void AddRangeByIndex(int index, T[] collection)
        {
            throw new NotImplementedException();
        }

        public T RemoveByIndex(int index)
        {
            throw new NotImplementedException();
        }

        public T RemoveStart()
        {
            throw new NotImplementedException();
        }

        public T Remove()
        {
            throw new NotImplementedException();
        }

        public void RemoveRangeByIndex(int index)
        {
            throw new NotImplementedException();
        }

        public void RemoveRangeStart()
        {
            throw new NotImplementedException();
        }

        public void RemoveRange()
        {
            throw new NotImplementedException();
        }

        public int RemoveByValueFirst(T value)
        {
            throw new NotImplementedException();
        }

        public int RemoveByValueAll(T value)
        {
            throw new NotImplementedException();
        }

        public int FindIndexByValue(T value)
        {
            throw new NotImplementedException();
        }

        public int GetMaxIndex()
        {
            throw new NotImplementedException();
        }

        public T GetMax()
        {
            throw new NotImplementedException();
        }

        public int GetMinIndex()
        {
            throw new NotImplementedException();
        }

        public T GetMin()
        {
            throw new NotImplementedException();
        }

        public void Sort(bool isAscending)
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        public void HalfReverse()
        {
            throw new NotImplementedException();
        }
    }
}
