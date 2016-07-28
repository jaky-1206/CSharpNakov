using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    public class WordCountingWithSortedDictionary
    {
        public static IDictionary<string,int> GetWordOccurrenceMap(string text)
        {
            string[] tokens=text.Split(' ', '.', ',', '-', '?', '!');
            IDictionary<string, int> words = new SortedDictionary<string, int>();
            foreach(string word in tokens)
            {
                if (!string.IsNullOrEmpty(word.Trim()))
                {
                    int count;
                    if(!words.TryGetValue(word, out count))
                    {
                        count = 0;
                    }
                    words[word] = count + 1;
                }
            }
            return words;
        }
    }
}
