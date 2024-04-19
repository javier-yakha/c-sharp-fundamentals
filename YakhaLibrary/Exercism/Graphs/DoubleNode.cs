using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Graphs
{
    /// <summary>
    /// Generic <see cref="DoubleNode{T}"/> structure
    /// usage along <see cref="Deque{T}"/>
    /// </summary>
    /// <typeparam name="T">
    /// Generic value from <see cref="System.Collections.Generic"/>
    /// </typeparam>
    /// <param name="value">
    /// Generic <see langword="value"/>
    /// to be stored in a single <see cref="DoubleNode{T}"/>
    /// or data point
    /// </param>
    public class DoubleNode<T>(T value)
    {
        public T Value { get; set; } = value;
        public DoubleNode<T>? Next { get; set; } = null;
        public DoubleNode<T>? Prev { get; set; } = null;
    }
}
