using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Graphs
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BinarySearchTree : IEnumerable<int>
    {
        public int Value { get; private set; }
        public int Size { get; private set; } = 0;
        public BinarySearchTree(int value) { Add(value); }
        public BinarySearchTree(IEnumerable<int> values) { foreach (int value in values) Add(value); }
        public BinarySearchTree? Left { get; private set; } = null;
        public BinarySearchTree? Right { get; private set; } = null;
        public BinarySearchTree Add(int value)
        {
            if (Size == 0) 
            { 
                Value = value;
                Size++;
                return this;
            }
            else if (value > Value)
            {
                Size++;
                if (Right == null) return Right = new BinarySearchTree(value);
                return Right.Add(value);
            }
            else // Accepts duplicates <- -> Exercism requirement
            {
                if (Left == null) return Left = new BinarySearchTree(value);
                return Left.Add(value);
            }
        }
        public IEnumerator<int> GetEnumerator()
        {
            List<int> list = [];
            Traverse(this, list);
            foreach (int i in list) yield return i;
        }
        private void Traverse(BinarySearchTree? node, List<int> data)
        {
            if (node == null) return;
            Traverse(node.Left, data);
            data.Add(node.Value);
            Traverse(node.Right, data);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
