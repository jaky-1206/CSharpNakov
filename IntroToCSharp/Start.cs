using System;
using System.Text;
using System.Collections.Generic;

namespace IntroToCSharp
{
    class Start
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                input = ShowMenu(String.Join(Environment.NewLine,
                    "(1) List using array",
                    "(2) List using Dynamic Linked List",
                    "(3) Prime Number Generation using Generic List class",
                    "(4) Set operation using Generic List class",
                    "(5) Converting List to Array",
                    "(6) Correct Brackets Check Using Generic Stack Class",
                    "(7) sequence of numbers (N, N+1, 2*N) Using Generic Queue Class",
                    "(8) Tree Example",
                    "(9) Directory Traverser DFS",
                    "(10) Directory Traverser BFS",
                    "(11) Binary Tree Example",
                    "(12) Binary Search Tree Example",
                    "(13) Graph Components (Undirected graph Example)",
                    "(e) Exit"));
                Console.Clear();
                switch (input)
                {
                    case "1":
                        CustomListUsingArray();
                        break;
                    case "2":
                        ListUsingCustomSingleLinkedList();
                        break;
                    case "3":
                        PrimeNumberusinghList();
                        break;
                    case "4":
                        SetExampleUsingList();
                        break;
                    case "5":
                        ConvertListToArray();
                        break;
                    case "6":
                        CorrectBracketsCheckUsingGenericStackClass();
                        break;
                    case "7":
                        SequenceOfNumbersUsingGenericQueueClass();
                        break;
                    case "8":
                        TreeExample();
                        break;
                    case "9":
                        DirectoryTraverserDFSExample();
                        break;
                    case "10":
                        DirectoryTraverserBFSExample();
                        break;
                    case "11":
                        BinaryTreeExample();
                        break;
                    case "12":
                        BinarySearchTreeExample();
                        break;
                    case "13":
                        GraphComponentsExample();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
            } while (input.ToLower() != "e");
        }
        static string ShowMenu(string options)
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("****************** SELECT AND OPTION ********************");
            Console.WriteLine("*********************************************************");
            Console.WriteLine(options);
            Console.WriteLine("*********************************************************");
            return Console.ReadLine();
        }
        static void ClearAfterKeyPress()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to go back to main menu ....");
            Console.ReadKey();
            Console.Clear();
        }
        static void PrintCustomListUsingArray(CustomArrayList<string> customArrayList)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < customArrayList.Count; i++)
            {
                result.Append(customArrayList[i].ToString());
            }
            Console.WriteLine(result.ToString());
        }
        static void CustomListUsingArray()
        {
            CustomArrayList<string> custArrayList = new CustomArrayList<string>();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("CustomArrayList");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("count: " + custArrayList.Count);
            Console.WriteLine("Empty Array");
            Console.WriteLine("------------");
            custArrayList.Add("a");
            custArrayList.Add("b");
            custArrayList.Add("c");
            custArrayList.Add("d");
            Console.WriteLine("count: " + custArrayList.Count);
            PrintCustomListUsingArray(custArrayList);
            Console.WriteLine("------------");
            Console.WriteLine("index of c: " + custArrayList.IndexOf("c"));
            custArrayList.Insert(1, "j");
            custArrayList.Insert(2, "k");
            Console.WriteLine("count: " + custArrayList.Count);
            PrintCustomListUsingArray(custArrayList);
            Console.WriteLine("------------");
            Console.WriteLine("index of c: " + custArrayList.IndexOf("c"));
            Console.WriteLine("Does array contains c? " + custArrayList.Contains("c"));
            Console.WriteLine("6th element :" + custArrayList[5]);
            Console.WriteLine("Replacing 6th element with m");
            custArrayList[5] = "m";
            Console.WriteLine("Replaced 6th element :" + custArrayList[5]);
            Console.WriteLine("count: " + custArrayList.Count);
            PrintCustomListUsingArray(custArrayList);
            Console.WriteLine("------------");
            custArrayList.Add("y");
            custArrayList.Add("z");
            Console.WriteLine("added y and z");
            PrintCustomListUsingArray(custArrayList);
            Console.WriteLine("count: " + custArrayList.Count);
            Console.WriteLine("------------");
            Console.WriteLine("Removing at 7th index");
            custArrayList.RemoveAt(7);
            Console.WriteLine("count: " + custArrayList.Count);
            PrintCustomListUsingArray(custArrayList);
            Console.WriteLine("------------");
            Console.WriteLine("Removing y");
            custArrayList.Remove("y");
            Console.WriteLine("count: " + custArrayList.Count);
            PrintCustomListUsingArray(custArrayList);
            Console.WriteLine("------------");
            ClearAfterKeyPress();
        }
        static void PrintListUsingCustomSingleLinkedList(DynamicList<string> dynamicList)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < dynamicList.Count; i++)
            {
                result.Append(dynamicList[i]);
            }
            Console.WriteLine(result.ToString());

        }
        static void ListUsingCustomSingleLinkedList()
        {
            DynamicList<string> DynamicLinkedList = new DynamicList<string>();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("DynamicLinkedList");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("count: " + DynamicLinkedList.Count);
            Console.WriteLine("Empty List");
            Console.WriteLine("------------");
            DynamicLinkedList.Add("a");
            DynamicLinkedList.Add("b");
            DynamicLinkedList.Add("c");
            DynamicLinkedList.Add("d");
            Console.WriteLine("count: " + DynamicLinkedList.Count);
            PrintListUsingCustomSingleLinkedList(DynamicLinkedList);
            Console.WriteLine("------------");
            Console.WriteLine("index of c: " + DynamicLinkedList.IndexOf("c"));
            DynamicLinkedList.Add("j");
            DynamicLinkedList.Add("k");
            Console.WriteLine("count: " + DynamicLinkedList.Count);
            PrintListUsingCustomSingleLinkedList(DynamicLinkedList);
            Console.WriteLine("------------");
            Console.WriteLine("index of c: " + DynamicLinkedList.IndexOf("c"));
            Console.WriteLine("Does array contains c? " + DynamicLinkedList.Contains("c"));
            Console.WriteLine("6th element :" + DynamicLinkedList[5]);
            Console.WriteLine("Replacing 6th element with m");
            DynamicLinkedList[5] = "m";
            Console.WriteLine("Replaced 6th element :" + DynamicLinkedList[5]);
            Console.WriteLine("count: " + DynamicLinkedList.Count);
            PrintListUsingCustomSingleLinkedList(DynamicLinkedList);
            Console.WriteLine("------------");
            DynamicLinkedList.Add("y");
            DynamicLinkedList.Add("z");
            Console.WriteLine("added y and z");
            PrintListUsingCustomSingleLinkedList(DynamicLinkedList);
            Console.WriteLine("count: " + DynamicLinkedList.Count);
            Console.WriteLine("------------");
            Console.WriteLine("Removing at 7th index");
            DynamicLinkedList.RemoveAt(7);
            Console.WriteLine("count: " + DynamicLinkedList.Count);
            PrintListUsingCustomSingleLinkedList(DynamicLinkedList);
            Console.WriteLine("------------");
            Console.WriteLine("Removing y");
            DynamicLinkedList.Remove("y");
            Console.WriteLine("count: " + DynamicLinkedList.Count);
            PrintListUsingCustomSingleLinkedList(DynamicLinkedList);
            Console.WriteLine("------------");
            ClearAfterKeyPress();
        }
        static void PrimeNumberusinghList()
        {
            List<int> primes = PrimeNumberWithList.GetPrimes(200, 300);
            foreach (var item in primes)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            ClearAfterKeyPress();
        }
        static void SetExampleUsingList()
        {
            List<int> firstList = new List<int>();
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);
            firstList.Add(4);
            firstList.Add(5);
            Console.Write("firstList = ");
            SetUsingList.PrintList(firstList);

            List<int> secondList = new List<int>();
            secondList.Add(2);
            secondList.Add(4);
            secondList.Add(6);
            Console.Write("secondList = ");
            SetUsingList.PrintList(secondList);

            List<int> unionList = SetUsingList.Union(firstList, secondList);
            Console.Write("unionList = ");
            SetUsingList.PrintList(unionList);

            List<int> intersectList = SetUsingList.Intersect(firstList, secondList);
            Console.Write("intersectList = ");
            SetUsingList.PrintList(intersectList);
            ClearAfterKeyPress();

        }
        static void ConvertListToArray()
        {
            int[] arr = new int[] { 1, 2, 3 };
            List<int> list = new List<int>(arr);
            int[] convertedArray = list.ToArray();
            foreach (var item in convertedArray)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("");
            ClearAfterKeyPress();
        }
        static void CorrectBracketsCheckUsingGenericStackClass()
        {
            string expression = "1 + (3 + 2 - (2+3)*4 - ((3+1)*(4-2)))";
            Stack<int> stack = new Stack<int>();
            bool correctBrackets = true;
            for (int index = 0; index < expression.Length; index++)
            {
                char ch = expression[index];
                if (ch == '(')
                {
                    stack.Push(index);
                }
                else if (ch == ')')
                {
                    if (stack.Count == 0)
                    {
                        correctBrackets = false;
                        break;
                    }
                    stack.Pop();
                }
            }
            if (stack.Count != 0)
            {
                correctBrackets = false;
            }
            Console.WriteLine("Are the brackets correct? {0}", correctBrackets);
            ClearAfterKeyPress();
        }
        static void SequenceOfNumbersUsingGenericQueueClass()
        {
            int n = 3;
            int p = 16;

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            int index = 0;
            Console.Write("S =");
            while (queue.Count > 0)
            {
                index++;
                int current = queue.Dequeue();
                Console.Write(" " + current);
                if (current == p)
                {
                    Console.WriteLine();
                    Console.WriteLine("index = " + index);
                    return;
                }
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current);
            }

            ClearAfterKeyPress();
        }
        static void TreeExample()
        {
            /// <summary>
            /// Shows a sample usage of the Tree<T> class
            /// </summary>


            // Create the tree from the sample
            Tree<int> tree =
                new Tree<int>(7,
                    new Tree<int>(19,
                        new Tree<int>(1),
                        new Tree<int>(12),
                        new Tree<int>(31)),
                    new Tree<int>(21),
                    new Tree<int>(14,
                        new Tree<int>(23), new Tree<int>(6))
            );

            // Traverse and print the tree using Depth-First-Search
            tree.TraverseDFS();
            // Console output:
            // 7
            //  19
            //      1
            //      12
            //      31
            //  21
            //  14
            //      23
            //      6

            ClearAfterKeyPress();
        }
        static void DirectoryTraverserDFSExample()
        {
            DirectoryTraverserDFS.TraverseDir("F:\\Audio Songs\\English\\");
            ClearAfterKeyPress();
        }
        static void DirectoryTraverserBFSExample()
        {
            DirectoryTraverserBFS.TraverseDir(@"F:\\Audio Songs\\English\\");
            ClearAfterKeyPress();
        }
        static void BinaryTreeExample()
        {
            // Create the binary tree from the sample
            // Create the binary tree from the sample
            BinaryTree<int> binaryTree =
                new BinaryTree<int>(14,
                    new BinaryTree<int>(19,
                        new BinaryTree<int>(23),
                        new BinaryTree<int>(6,
                            new BinaryTree<int>(10),
                            new BinaryTree<int>(21))),
                    new BinaryTree<int>(15,
                        new BinaryTree<int>(3),
                        null));

            // Traverse and print the tree in in-order manner
            binaryTree.PrintInOrder();
            Console.WriteLine();

            ClearAfterKeyPress();
        }
        static void BinarySearchTreeExample()
        {
            BinarySearchTree<string> tree = new BinarySearchTree<string>();
            tree.Insert("Telerik");
            tree.Insert("Google");
            tree.Insert("Microsoft");
            tree.PrintTreeDFS(); // Google Microsoft Telerik
            Console.WriteLine(tree.Contains("Telerik")); // True
            Console.WriteLine(tree.Contains("IBM")); // False
            tree.Remove("Telerik");
            Console.WriteLine(tree.Contains("Telerik")); // False
            tree.PrintTreeDFS(); // Google Microsoft


            ClearAfterKeyPress();
        }
        static void GraphComponentsTraverseDFS(int v,bool[] visited,Graph graph)
        {
            if (!visited[v])
            {
                Console.Write(v + " ");
                visited[v] = true;
                foreach (int child in graph.GetSuccessors(v))
                {
                    GraphComponentsTraverseDFS(child,visited, graph);
                }
            }
        }
        static void GraphComponentsExample()
        {
            Graph graph = new Graph(new List<int>[] {
                new List<int>() {4}, // successors of vertice 0
                new List<int>() {1, 2, 6}, // successors of vertice 1
                new List<int>() {1, 6}, // successors of vertice 2
                new List<int>() {6}, // successors of vertice 3
                new List<int>() {0}, // successors of vertice 4
                new List<int>() {}, // successors of vertice 5
                new List<int>() {1, 2, 3} // successors of vertice 6
            });

            bool[] visited = new bool[graph.Size];

            Console.WriteLine("Connected graph components: ");
            for(int v = 0; v < graph.Size; v++)
            {
                if (!visited[v])
                {
                    GraphComponentsTraverseDFS(v, visited, graph);
                    Console.WriteLine();
                }
            }

            ClearAfterKeyPress();
        }
    }
}
