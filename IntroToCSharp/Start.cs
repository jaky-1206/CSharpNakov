﻿using System;
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
                input = showMenu(String.Join(Environment.NewLine,
                    "(1) List using array",
                    "(2) List using Dynamic Linked List",
                    "(3) Prime Number Generation using Generic List class",
                    "(4) Set operation using Generic List class",
                    "(c) Clear",
                    "(e) Exit"));
                switch (input)
                {
                    case "1":
                        CustomListUsingArray();
                        break;
                    case "2":
                        ListUsingDynamicLinkedList();
                        break;
                    case "3":
                        PrimeNumberusinghList();
                        break;
                    case "4":
                        SetExampleUsingList();
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

        static void printCustomListUsingArray(CustomArrayList<string> customArrayList)
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
            printCustomListUsingArray(custArrayList);
            Console.WriteLine("------------");
            Console.WriteLine("index of c: " + custArrayList.IndexOf("c"));
            custArrayList.Insert(1, "j");
            custArrayList.Insert(2, "k");
            Console.WriteLine("count: " + custArrayList.Count);
            printCustomListUsingArray(custArrayList);
            Console.WriteLine("------------");
            Console.WriteLine("index of c: " + custArrayList.IndexOf("c"));
            Console.WriteLine("Does array contains c? " + custArrayList.Contains("c"));
            Console.WriteLine("6th element :" + custArrayList[5]);
            Console.WriteLine("Replacing 6th element with m");
            custArrayList[5] = "m";
            Console.WriteLine("Replaced 6th element :" + custArrayList[5]);
            Console.WriteLine("count: " + custArrayList.Count);
            printCustomListUsingArray(custArrayList);
            Console.WriteLine("------------");
            custArrayList.Add("y");
            custArrayList.Add("z");
            Console.WriteLine("added y and z");
            printCustomListUsingArray(custArrayList);
            Console.WriteLine("count: " + custArrayList.Count);
            Console.WriteLine("------------");
            Console.WriteLine("Removing at 7th index");
            custArrayList.RemoveAt(7);
            Console.WriteLine("count: " + custArrayList.Count);
            printCustomListUsingArray(custArrayList);
            Console.WriteLine("------------");
            Console.WriteLine("Removing y");
            custArrayList.Remove("y");
            Console.WriteLine("count: " + custArrayList.Count);
            printCustomListUsingArray(custArrayList);
            Console.WriteLine("------------");
        }

        static void PrintListUsingDynamicLinkedList(DynamicList<string> dynamicList)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < dynamicList.Count; i++)
            {
                result.Append(dynamicList[i]);
            }
            Console.WriteLine(result.ToString());

        }
        static void ListUsingDynamicLinkedList()
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
            PrintListUsingDynamicLinkedList(DynamicLinkedList);
            Console.WriteLine("------------");
            Console.WriteLine("index of c: " + DynamicLinkedList.IndexOf("c"));
            DynamicLinkedList.Add("j");
            DynamicLinkedList.Add("k");
            Console.WriteLine("count: " + DynamicLinkedList.Count);
            PrintListUsingDynamicLinkedList(DynamicLinkedList);
            Console.WriteLine("------------");
            Console.WriteLine("index of c: " + DynamicLinkedList.IndexOf("c"));
            Console.WriteLine("Does array contains c? " + DynamicLinkedList.Contains("c"));
            Console.WriteLine("6th element :" + DynamicLinkedList[5]);
            Console.WriteLine("Replacing 6th element with m");
            DynamicLinkedList[5] = "m";
            Console.WriteLine("Replaced 6th element :" + DynamicLinkedList[5]);
            Console.WriteLine("count: " + DynamicLinkedList.Count);
            PrintListUsingDynamicLinkedList(DynamicLinkedList);
            Console.WriteLine("------------");
            DynamicLinkedList.Add("y");
            DynamicLinkedList.Add("z");
            Console.WriteLine("added y and z");
            PrintListUsingDynamicLinkedList(DynamicLinkedList);
            Console.WriteLine("count: " + DynamicLinkedList.Count);
            Console.WriteLine("------------");
            Console.WriteLine("Removing at 7th index");
            DynamicLinkedList.RemoveAt(7);
            Console.WriteLine("count: " + DynamicLinkedList.Count);
            PrintListUsingDynamicLinkedList(DynamicLinkedList);
            Console.WriteLine("------------");
            Console.WriteLine("Removing y");
            DynamicLinkedList.Remove("y");
            Console.WriteLine("count: " + DynamicLinkedList.Count);
            PrintListUsingDynamicLinkedList(DynamicLinkedList);
            Console.WriteLine("------------");
        }
        static void PrimeNumberusinghList()
        {
            List<int> primes = PrimeNumberWithList.GetPrimes(200, 300);
            foreach (var item in primes)
            {
                Console.Write("{0} ", item);
            }
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

        }
    }
}