using System;
using System.Collections;
using System.Collections.Generic;

namespace MyLinkedList
{
    public class LinkedListClass<T> : IList<T>, IEnumerable<T> where T : IComparable
    {
        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public int Count { get; set; }

        public T this[int index]
        {
            get
            {
                if (IsValidIndex(index))
                {
                    Node<T> current = Head;

                    for (int i = 1; i <= index; i++)
                    {
                        current = current.Next;
                    }

                    return current.Data;
                }

                throw new IndexOutOfRangeException("Invalid index!");
            }
            set
            {
                if (IsValidIndex(index) && !(value is null))
                {
                    Node<T> current = Head;

                    for (int i = 1; i <= index; i++)
                    {
                        current = current.Next;
                    }

                    current.Data = value;
                }
                else if (!(IsValidIndex(index)))
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
                else
                {
                    throw new NullReferenceException("Data cannot be null");
                }
            }
        }

        public LinkedListClass()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }

        public LinkedListClass(T data)
        {
            if (data != null)
            {
                Count = 1;
                Head = new Node<T>(data);
                Tail = Head;
            }
            else
            {
                throw new ArgumentNullException("Null data passed");
            }
        }

        public LinkedListClass(T[] data)
        {
            if (!(data is null))
            {
                Count = data.Length;

                if (data.Length != 0)
                {
                    Head = new Node<T>(data[0]);
                    Tail = Head;

                    for (int i = 1; i < data.Length; i++)
                    {
                        Tail.Next = new Node<T>(data[i]);
                        Tail = Tail.Next;
                    }
                }
                else
                {
                    Head = null;
                    Tail = null;
                }
            }
            else
            {
                throw new NullReferenceException("Null data passed!");
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
            if (IsValidIndex(index) && !(Head is null))
            {
                T data = default;

                if (index == 0)
                {
                    data = Head.Data;
                    Head = Head.Next;
                }
                else
                {
                    Tail = Head;

                    for (int i = 0; i < index; i++)
                    {
                        if (i == index - 1)
                        {
                            data = Tail.Next.Data;

                            Tail.Next = Tail.Next?.Next;
                            break;
                        }

                        Tail = Tail.Next;
                    }
                }

                --Count;

                return data;
            }
            else if (Head is null)
            {
                throw new NullReferenceException("List is empty!");
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
        }

        public T RemoveStart()
        {
            return RemoveByIndex(0);
        }

        public T Remove()
        {
            return RemoveByIndex(Count - 1);
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

        private bool IsValidIndex(int index)
        {
            return index >= 0 && index < Count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
