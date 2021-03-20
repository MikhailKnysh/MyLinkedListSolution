using System;

namespace MyLinkedList
{
    public class LinkedListClass<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        public int Count { get; set; }

        public LinkedListClass()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        public LinkedListClass(T data)
        {
            if(data!= null)
            {
                Node<T> item = new Node<T>(data);
                _head = item;
                _tail = item;
                ++Count;
            }
            else
            {
                throw new ArgumentNullException("Null data passed");
            }
        }
    }
}
