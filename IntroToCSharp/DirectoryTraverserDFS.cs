using System;
using System.IO;

namespace IntroToCSharp
{
    /// <summary>
    /// Sample class, which traverses recursively given directory
    /// based on the Depth-First-Search (DFS) algorithm
    /// </summary>
    class DirectoryTraverserDFS
    {
        /// <summary>
        /// Traverses and prints given directory recursively
        /// </summary>
        /// <param name="dir">the directory to be traversed</param>
        /// <param name="spaces">the spaces used for representation
        /// of the parent-child relation</param>
        public static void TraverseDir(DirectoryInfo dir, string spaces)
        {
            // Visit the current directory
            Console.WriteLine(spaces, dir.FullName);
        }
    }
}
