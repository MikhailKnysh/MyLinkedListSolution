using System;
using System.Collections;
using System.Collections.Generic;

namespace MyLinkedList
{
    public class LinkedListClass<T> : IList<T>, IEnumerable<T> where T : IComparable
    {
        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public int Length { get; set; }

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
            Length = 0;
            Head = null;
            Tail = null;
        }

        public LinkedListClass(T data)
        {
            if (data != null)
            {
                Length = 1;
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
                Length = data.Length;

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
            AddByIndex(index: 0, value);
        }

        public void Add(T value)
        {
            if (value != null)
            {
                if (Head == null)
                {
                    Head = new Node<T>(value);
                    Tail = Head;
                }
                else
                {
                    Tail.Next = new Node<T>(value);
                    Tail = Tail.Next;
                }


                ++Length;
            }
        }

        public void AddByIndex(int index, T value)
        {
            if (value != null)
            {
                Node<T> item = new Node<T>(value);
                if (index == 0)
                {
                    item.Next = Head;
                    Head = item;
                }
                else
                {
                    Tail = Head;

                    for (int i = 1; i < index; i++)
                    {
                        Tail = Tail.Next;
                        if(i == index - 1)
                        {
                            item.Next = Tail.Next;
                            Tail.Next = item;
                        }
                    }
                }

                ++Length;
            }

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

        private bool IsValidIndex(int index)
        {
            return index >= 0 && index < Length;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        //public override bool Equals(object obj)
        //{
        //    LinkedListClass<T> list = (LinkedListClass<T>)obj;

        //    if (this.Length != list.Length)
        //    {
        //        return false;
        //    }

        //    Node<T> currentThis = this.Head;
        //    Node<T> currentList = list.Head;

        //    do
        //    {
        //        if (!currentThis.Data.Equals(currentList.Data))
        //        {
        //            return false;
        //        }
        //        currentList = currentList.Next;
        //        currentThis = currentThis.Next;
        //    }
        //    while (!(currentThis.Next is null));

        //    return true;
        //}
    }
}
