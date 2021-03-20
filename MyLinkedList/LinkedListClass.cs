using System;

namespace MyLinkedList
{
    public class LinkedListClass<T>
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
    }
}
