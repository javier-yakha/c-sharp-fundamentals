using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Graphs
{
    /// <summary>
    /// generic <see cref="SimpleNode{T}"/> structure
    /// usage along <see cref="SimpleLinkedList{T}"/>
    /// </summary>
    /// <typeparam name="T">
    /// Generic value from
    /// <see cref="System.Collections.Generic"/>
    /// </typeparam>
    /// <param name="value">
    /// Generic <see langword="value"/> to be stored in a single
    /// <see cref="SimpleNode{T}"/> or data point
    /// </param>
    public class SimpleNode<T>(T value)
    {
        public T Value { get; private set; } = value;
        public SimpleNode<T>? Next { get; set; } = null;
    }
}
