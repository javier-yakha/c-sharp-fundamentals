using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Graphs
{
    /// <summary>
    /// basic Node structure
    /// <see cref="Node{T}"/>
    /// return <see langword="true"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="value">
    /// Generic <see langword="value"/>
    /// </param>
    public class Node<T>(T value)
    {
        public T Value { get; private set; } = value;
        public Node<T>? Next { get; set; } = null;
    }
}
