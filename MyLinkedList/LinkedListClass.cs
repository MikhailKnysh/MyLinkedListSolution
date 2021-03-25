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

        public int FindIndexByValue(T data)
        {
            int index = -1;
            Node<T> current = _head;

            for (int i = 0; i < Count; i++)
            {
                if (current.Data.CompareTo(data) == 0)
                {
                    index = i;
                    break;
                }
            }

            return index;
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
    }
}