using System;
//убрали, чтобы стандартные классы не мешали

namespace lec4
{
    public class List
    {
        private Node _first;
        private Node _last;

        public void Add(Complex data)
        {
            Node node = new Node(data);

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

        public void Remove(Complex data)
        {
            if (_first == null)
                return;

            Node current = _first;
            Node previous = null;

            while (current != null && current.Data != data )
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

        public Complex this[int i]
        {
            get
            {
                Node current = _first;
                int count = 0;
                while (current != null && count < i)
                {
                    count++;
                    current = current.Next;
                }

                return current?.Data;
            }
        }




        public int Count
        {
            get
            {
                Node current = _first;
                int count = 0;
                while (current!= null)
                {
                    count++;
                    current = current.Next;
                }

                return count;
            }
        }







        private class Node
        {
            public Node(Complex data)
            {
                Data = data;
            }
            public Complex Data { get; set; }
            public Node Next { get; set; }
        }
    }
}
