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
