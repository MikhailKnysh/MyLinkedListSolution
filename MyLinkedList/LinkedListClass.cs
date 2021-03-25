using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace MyLinkedList
{
    public class LinkedListClass<T> : IList<T>, IEnumerable<T> where T : IComparable
    {
        private Node<T> _head;

        private Node<T> _tail;

        public int Count { get; set; }

        public T this[int index]
        {
            get
            {
                if (IsValidIndex(index))
                {
                    Node<T> current = _head;

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
                    Node<T> current = _head;

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
            _head = null;
            _tail = null;
        }

        public LinkedListClass(T data)
        {
            if (data != null)
            {
                Count = 1;
                _head = new Node<T>(data);
                _tail = _head;
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
                    _head = new Node<T>(data[0]);
                    _tail = _head;

                    for (int i = 1; i < data.Length; i++)
                    {
                        _tail.Next = new Node<T>(data[i]);
                        _tail = _tail.Next;
                    }
                }
                else
                {
                    _head = null;
                    _tail = null;
                }
            }
            else
            {
                throw new NullReferenceException("Null data passed!");
            }
        }

        public void Clear()
        {
             Count = 0;
            _head = null;
            _tail = null;
        }

        public T[] ToArray()
        {
            throw new NotImplementedException();
        }

        public void AddStart(T data)
        {
            AddByIndex(index: 0, data);
        }

        public void Add(T data)
        {
            AddByIndex(index: Count, data);
        }

        public void AddByIndex(int index, T data)
        {
            if (data != null && index >= 0 && index <= Count)
            {
                Node<T> item = new Node<T>(data);
                if (index == 0)
                {
                    item.Next = _head;
                    _head = item;
                }
                else
                {
                    Node<T> current = _head;

                    for (int i = 1; i <= index; i++)
                    {
                        if (i == index)
                        {
                            item.Next = current.Next;
                            current.Next = item;
                            
                            if (current.Next == null)
                            {
                                _tail = current.Next;
                            }
                        }
                        current = current.Next;
                    }
                }

                ++Count;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void AddRangeStart(T[] collection)
        {
            AddRangeByIndex(index: 0, collection);
        }

        public void AddRange(T[] collection)
        {
            AddRangeByIndex(index: Count, collection);
        }

        public void AddRangeByIndex(int index, T[] collection)
        {
            
            if (index>=0 && index<=Count && !(collection is null) )
            {
                var temp = default(Node<T>);
                Node<T> current = _head;

                if (index == 0)
                {
                    temp = _head;
                    _head = new Node<T>(collection[0]);
                    current = _head;

                    for (int i = 1; i < collection.Length; i++)
                    {
                        current.Next = new Node<T>(collection[i]);
                        current = current.Next;
                    }

                    current.Next = temp;

                    if (current.Next == null)
                    {
                        _tail = current;
                    }
                }
                else
                {
                    int j = 0;
                    int lenth = index + collection.Length;

                    for (int i = 1; i < lenth; i++)
                    {
                        if (i >= index)
                        {
                            if (i == index)
                            {
                                 temp = current.Next;
                            }
                            current.Next = current.Next = new Node<T>(collection[j++]);
                        }
                        current = current.Next;
                    }
                    current.Next = temp;
                }
                Count += collection.Length;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public T RemoveByIndex(int index)
        {
            if (IsValidIndex(index) && !(_head is null))
            {
                T data = default;

                if (index == 0)
                {
                   data = RemoveStart();
                }
                else
                {
                    Node<T> current = _head;

                    for (int i = 0; i < index; i++)
                    {
                        if (i == index - 1)
                        {
                            data = current.Next.Data;

                            current.Next = current.Next?.Next;

                            if (index == Count - 1)
                            {
                                _tail = current.Next;
                            }

                            break;
                        }

                        current = current.Next;
                    }

                    --Count;
                }

                return data;
            }
            else if (_head is null)
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
            if (!(_head is null))
            {
                T data = _head.Data;

                if (Count == 1)
                {
                    _head = null;
                    _tail = null;
                }
                else
                {
                    _head = _head.Next;
                }

                --Count;

                return data;
            }

            throw new NullReferenceException("List is empty!");
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
            if (!(_head is null))
            {
                Node<T> current = _head;
                T dataMax = _head.Data;
                int index = 0;

                for (int i = 1; i < Count; i++)
                {
                    if (dataMax.CompareTo(current.Next.Data) == -1)
                    {
                        index = i;
                        dataMax = current.Next.Data;
                    }
                    current = current.Next;
                }
                return index;
            }
            throw new InvalidOperationException();
        }

        public T GetMax()
        {
            if (!(_head is null))
            {
                Node<T> current = _head;
                T dataMax = _head.Data;
                int index = 0;

                for (int i = 1; i < Count; i++)
                {
                    if (dataMax.CompareTo(current.Next.Data) == -1)
                    {
                        dataMax = current.Next.Data;
                    }
                    current = current.Next;
                }
                return dataMax;
            }
            throw new InvalidOperationException();
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

        public override string ToString()
        {
            if (Count != 0)
            {
                Node<T> current = _head;
                StringBuilder stringBuilder = new StringBuilder($"{current.Data} ");

                while (!(current.Next is null))
                {
                    current = current.Next;
                    stringBuilder.Append($"{current.Data} ");
                }

                return stringBuilder.ToString().Trim();
            }
            else
            {
                return string.Empty;
            }
        }

        private bool IsValidIndex(int index)
        {
            return index >= 0 && index < Count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(_head);
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