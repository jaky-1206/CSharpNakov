using System;
using System.Collections.Generic;

namespace IntroToCSharp
{
    /// <summary>Represents a tree data structure</summary>
    /// <typeparam name="T">the type of the values in the
    /// tree</typeparam>
    public class Tree<T>
    {
        // The root of the tree
        private TreeNode<T> root;

        /// <summary>Constructs the tree</summary>
        /// <param name="value">the value of the node</param>
        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Can not insert null value!");
            }
            this.root = new TreeNode<T>(value);
        }
    }
}
