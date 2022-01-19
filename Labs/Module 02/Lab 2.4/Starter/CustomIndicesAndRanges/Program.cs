using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomIndicesAndRanges
{
    public class SequencePacker<T> : IEnumerable<T> where T : IEquatable<T>
    {
        private class Node<TElement>
        {
            public Node(TElement t)
            {
                Element = t;
                Count = 1;
            }

            public TElement Element { get; set; }
            public int Count { get; set; }
        }

        private readonly List<Node<T>> _nodes;

        public SequencePacker()
        {
            _nodes = new List<Node<T>>();
        }

        public void Clear()
        {
            _nodes.Clear();
        }

        public void Add(T t)
        {
            bool handled = false;
            if (_nodes.Count > 0)
            {
                Node<T> lastNode = _nodes[^1];
                if (lastNode.Element.Equals(t))
                {
                    lastNode.Count++;
                    handled = true;
                }
            }

            if (handled == false)
            {
                _nodes.Add(new Node<T>(t));
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (Node<T> node in _nodes)
            {
                for (int i = 0; i < node.Count; i++)
                {
                    yield return node.Element;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SequencePacker<int> sp = new SequencePacker<int> { 42, 87, 87, 87, 87, 11, 22, 22, 87, 99 };

            foreach (int i in sp)
            {
                Console.WriteLine(i);
            }
        }
    }
}
