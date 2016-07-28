using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string s1,string s2)
        {
            return string.Compare(s1, s2, true);
        }
    }
}
