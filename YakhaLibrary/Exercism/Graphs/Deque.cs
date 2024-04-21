using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Graphs
{
    public class Deque<T>
    {
        DoubleNode<T>? head = null;
        DoubleNode<T>? tail = null;
        public int Count { get; private set; } = 0;
        public void Push(T value)
        {
            DoubleNode<T> node = new(value);
            if (Count == 0 || tail == null)
            {
                head = tail = node;
            }
            Count++;
            tail.Next = node;
            node.Prev = tail;
            tail = node;
        }
        public T Pop()
        {
            throw new NotImplementedException("You need to implement this function.");
        }
        public void Unshift(T value)
        {
            DoubleNode<T> node = new(value);
            if (Count == 0 || head == null)
            {
                tail = head = node;
            }
            Count++;
            head.Prev = node;
            node.Next = head;
            head = node;
        }
        public T Shift()
        {
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}
