using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    internal class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>> where T : IComparable<T>
    {
        // Contains the value of the node
        internal T value;
        // Contains the parent of the node
        internal BinaryTreeNode<T> parent;
        // Contains the left child of the node
        internal BinaryTreeNode<T> leftChild;
        // Contains the right child of the node
        internal BinaryTreeNode<T> rightChild;

        /// <summary>Constructs the tree node</summary>
        /// <param name="value">The value of the tree node</param>
        public BinaryTreeNode(T value)
        {
            if (value == null)
            {
                // Null values cannot be compared -> do not allow them
                throw new ArgumentNullException("Cannot insert null value!");
            }
            this.value = value;
            this.leftChild = null;
            this.rightChild = null;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            BinaryTreeNode<T> other = (BinaryTreeNode<T>)obj;
            return this.CompareTo(other) == 0;
        }

        public int CompareTo(BinaryTreeNode<T> other)
        {
            return this.value.CompareTo(other.value);
        }
    }
}
