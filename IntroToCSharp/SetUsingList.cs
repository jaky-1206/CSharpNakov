using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace IntroToCSharp
{
    class SetUsingList
    {
        public static List<int> Union(List<int> firstList, List<int> secondList)
        {
            List<int> union = new List<int>();
            union.AddRange(firstList);
            foreach (var item in secondList)
            {
                if (!union.Contains(item))
                {
                    union.Add(item);
                }
            }
            return union;
        }
        public static List<int> Intersect(List<int> firstList, List<int> secondList)
        {
            List<int> intersect = new List<int>();
            foreach(var item in firstList)
            {
                if(secondList.Contains(item))
                {
                    intersect.Add(item);
                }
            }
            return intersect;
        }
        public static void PrintList(List<int> list)
        {
            Console.Write("{");
            foreach (var item in list)
            {
                Console.Write(item);
                Console.Write("");
            }
            Console.WriteLine("}");
        }

    }
}
