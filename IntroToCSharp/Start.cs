using System;
using System.Text;

namespace IntroToCSharp
{
    class Start
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                input = showMenu(String.Join(Environment.NewLine,
                    "(1) CustomArrayList [List using array]",
                    "(2) DynamicList [List using Dynamic Linked List]",
                    "(c) Clear",
                    "(e) Exit"));
                switch (input)
                {
                    case "1":
                        CustomArrayList();
                        break;
                    case "2":
                        DynamicLinkedList();
                        break;
                    case "c":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
            } while (input.ToLower() != "e");
        }
        static string showMenu(string options)
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("****************** SELECT AND OPTION ********************");
            Console.WriteLine("*********************************************************");
            Console.WriteLine(options);
            Console.WriteLine("*********************************************************");
            return Console.ReadLine();
        }

        static void printCustomArrayListOfStrings(CustomArrayList<string> customArrayList)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < customArrayList.Count; i++)
            {
                result.Append(customArrayList[i].ToString());
            }
            Console.WriteLine(result.ToString());
        }

        static void CustomArrayList()
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
            printCustomArrayListOfStrings(custArrayList);
            Console.WriteLine("------------");
            Console.WriteLine("index of c: " + custArrayList.IndexOf("c"));
            custArrayList.Insert(1, "j");
            custArrayList.Insert(2, "k");
            Console.WriteLine("count: " + custArrayList.Count);
            printCustomArrayListOfStrings(custArrayList);
            Console.WriteLine("------------");
            Console.WriteLine("index of c: " + custArrayList.IndexOf("c"));
            Console.WriteLine("Does array contains c? " + custArrayList.Contains("c"));
            Console.WriteLine("6th element :" + custArrayList[5]);
            Console.WriteLine("Replacing 6th element with m");
            custArrayList[5] = "m";
            Console.WriteLine("Replaced 6th element :" + custArrayList[5]);
            Console.WriteLine("count: " + custArrayList.Count);
            printCustomArrayListOfStrings(custArrayList);
            Console.WriteLine("------------");
            custArrayList.Add("y");
            custArrayList.Add("z");
            Console.WriteLine("added y and z");
            printCustomArrayListOfStrings(custArrayList);
            Console.WriteLine("count: " + custArrayList.Count);
            Console.WriteLine("------------");
            Console.WriteLine("Removing at 7th index");
            custArrayList.RemoveAt(7);
            Console.WriteLine("count: " + custArrayList.Count);
            printCustomArrayListOfStrings(custArrayList);
            Console.WriteLine("------------");
            Console.WriteLine("Removing y");
            custArrayList.Remove("y");
            Console.WriteLine("count: " + custArrayList.Count);
            printCustomArrayListOfStrings(custArrayList);
            Console.WriteLine("------------");
        }

        static void PrintDynamicLinkedListOfStrings(DynamicList<string> dynamicList)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < dynamicList.Count; i++)
            {
                result.Append(dynamicList[i]);
            }
            Console.WriteLine(result.ToString());

        }
        static void DynamicLinkedList()
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
            PrintDynamicLinkedListOfStrings(DynamicLinkedList);
            Console.WriteLine("------------");
            Console.WriteLine("index of c: " + DynamicLinkedList.IndexOf("c"));
            DynamicLinkedList.Add("j");
            DynamicLinkedList.Add("k");
            Console.WriteLine("count: " + DynamicLinkedList.Count);
            PrintDynamicLinkedListOfStrings(DynamicLinkedList);
            Console.WriteLine("------------");
            Console.WriteLine("index of c: " + DynamicLinkedList.IndexOf("c"));
            Console.WriteLine("Does array contains c? " + DynamicLinkedList.Contains("c"));
            Console.WriteLine("6th element :" + DynamicLinkedList[5]);
            Console.WriteLine("Replacing 6th element with m");
            DynamicLinkedList[5] = "m";
            Console.WriteLine("Replaced 6th element :" + DynamicLinkedList[5]);
            Console.WriteLine("count: " + DynamicLinkedList.Count);
            PrintDynamicLinkedListOfStrings(DynamicLinkedList);
            Console.WriteLine("------------");
            DynamicLinkedList.Add("y");
            DynamicLinkedList.Add("z");
            Console.WriteLine("added y and z");
            PrintDynamicLinkedListOfStrings(DynamicLinkedList);
            Console.WriteLine("count: " + DynamicLinkedList.Count);
            Console.WriteLine("------------");
            Console.WriteLine("Removing at 7th index");
            DynamicLinkedList.RemoveAt(7);
            Console.WriteLine("count: " + DynamicLinkedList.Count);
            PrintDynamicLinkedListOfStrings(DynamicLinkedList);
            Console.WriteLine("------------");
            Console.WriteLine("Removing y");
            DynamicLinkedList.Remove("y");
            Console.WriteLine("count: " + DynamicLinkedList.Count);
            PrintDynamicLinkedListOfStrings(DynamicLinkedList);
            Console.WriteLine("------------");
        }
    }
}
