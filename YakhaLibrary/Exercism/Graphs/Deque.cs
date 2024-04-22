using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Graphs
{
    public class Deque<T>
    {
        private DoubleNode<T>? head = null;
        private DoubleNode<T>? tail = null;
        public int Count { get; private set; } = 0;
        public void Push(T value)
        {
            DoubleNode<T> node = new(value);
            if (Count == 0 || tail is null)
            {
                head = tail = node;
                //head.Next = tail;
                //tail.Prev = head;
            }
            tail.Next = node;
            node.Prev = tail;
            tail = node;
            Count++;
        }
        public T Pop()
        {
            if (Count == 0 || tail is null) throw new InvalidOperationException("Can't retrieve data from an empty Deque.");
            T value = tail.Value;
            if (tail.Prev is not null)
            {
                tail = tail.Prev;
                tail.Next = null;
            }
            Count--;
            return value;
        }
        public void Unshift(T value)
        {
            DoubleNode<T> node = new(value);
            if (Count == 0 || head is null)
            {
                tail = head = node;
            }
            head.Prev = node;
            node.Next = head;
            head = node;
            Count++;
        }
        public T Shift()
        {
            if (Count == 0 || head is null) throw new InvalidOperationException("Can't retrieve data from an empty Deque");
            T value = head.Value;
            if (head.Next is not null)
            {
                head = head.Next;
                head.Prev = null;
            }
            Count--;
            return value;
        }
    }
}