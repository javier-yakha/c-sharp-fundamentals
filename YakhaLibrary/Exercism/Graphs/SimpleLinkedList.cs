using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Graphs
{
    public class SimpleLinkedList<T> : IEnumerable<T>
    {
        SimpleNode<T>? head;
        public int Count {  get; private set; }
        public SimpleLinkedList() { head = null; }
        public SimpleLinkedList(T value) { Push(value); }
        public SimpleLinkedList(T[] values) { foreach (T value in values) Push(value); }
        public void Push(T value)
        {
            SimpleNode<T> node = new(value) { Next = head };
            head = node;
            Count++;
        }
        public T? Pop()
        {
            if (Count == 0 || head == null) return default;
            Count--;
            T value = head.Value;
            head = head.Next;
            return value;
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        IEnumerator<T> IEnumerable<T>.GetEnumerator() => GetEnumerator();
        public IEnumerator<T> GetEnumerator()
        {
            for (SimpleNode<T>? i = head; i != null; i = i.Next)
            {
                T value = i.Value;
                yield return value;
            }
        }
        public void Reverse()
        {
            SimpleNode<T>? tmp = null;
            SimpleNode<T>? current = head;
            while (current != null)
            {
                if (current.Next == null)
                {
                    current.Next = tmp;
                    head = current;
                    return;
                }
                else
                {
                    head = current.Next;
                    current.Next = tmp;
                    tmp = current;
                }
                current = head;
            }
        }
    }
}
