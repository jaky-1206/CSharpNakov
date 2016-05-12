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
            Console.WriteLine("Press any key to continue....");
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
            Console.WriteLine("Sequence N, N+1, 2*N – Example");
            ClearAfterKeyPress();
        }
    }
}
