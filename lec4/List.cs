using System;
//убрали, чтобы стандартные классы не мешали

namespace lec4
{
    public class List<T>
    {
        private Node<T> _first;
        private Node<T> _last;

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (_first == null)
            {
                _first = node;
            }
            else
            {
                _last.Next = node;
                
            }
            _last = node;
        }

        public void Remove(T data)
        {
            if (_first == null)
                return;

            Node<T> current = _first;
            Node<T> previous = null;

            while (current != null && !current.Data.Equals(data) )
            {
                previous = current;
                current = current.Next;
            }

            if (current != null)
            {
                if (previous == null)
                {
                    if (current.Next == null)
                    {
                        _first = null;
                        _last = null;
                    }
                    else
                    {
                        _first = _first.Next;
                    }
                }
                else
                {
                    previous.Next = current.Next;
                    if (current.Next == null)
                    {
                        _last = previous;
                    }
                }
            }
        }

        public T this[int i]
        {
            get
            {
                Node<T> current = _first;
                int count = 0;
                while (current != null && count < i)
                {
                    count++;
                    current = current.Next;
                }

                return current == null? default(T) : current.Data;
            }
        }




        public int Count
        {
            get
            {
                Node<T> current = _first;
                int count = 0;
                while (current!= null)
                {
                    count++;
                    current = current.Next;
                }

                return count;
            }
        }



        private class Node<TData>
        {
            public Node(TData data)
            {
                Data = data;
            }
            public TData Data { get; set; }
            public Node<TData> Next { get; set; }
        }
    }
}
