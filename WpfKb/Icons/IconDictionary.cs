using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfKb
{
    static class IconDictionary
    {
        public static readonly Dictionary<string, string> Icons = new Dictionary<string, string>
        {
            { "arrow-right-circle", "m 8,12 h 8 m -4,4 4,-4 -4,-4 m 10,4 A 10,10 0 0 1 12,22 10,10 0 0 1 2,12 10,10 0 0 1 12,2 10,10 0 0 1 22,12 Z" },
            { "minus-circle", "m 8,12 h 8 m 6,0 A 10,10 0 0 1 12,22 10,10 0 0 1 2,12 10,10 0 0 1 12,2 10,10 0 0 1 22,12 Z" },
            { "plus-circle", "m 8,12 h 8 M 12,8 v 8 M 22,12 A 10,10 0 0 1 12,22 10,10 0 0 1 2,12 10,10 0 0 1 12,2 10,10 0 0 1 22,12 Z" },
            { "delete", "m 12,9 6,6 m 0,-6 -6,6 M 21,4 H 8 l -7,8 7,8 h 13 a 2,2 0 0 0 2,-2 V 6 A 2,2 0 0 0 21,4 Z" },
            { "trash-2", "m 14,11 v 6 m -4,-6 v 6 M 19,6 v 14 a 2,2 0 0 1 -2,2 H 7 A 2,2 0 0 1 5,20 V 6 M 8,6 V 4 a 2,2 0 0 1 2,-2 h 4 a 2,2 0 0 1 2,2 V 6 M 3,6 h 2 16" },
            { "arrow-down-circle", "m 12,8 v 8 m -4,-4 4,4 4,-4 m 6,0 A 10,10 0 0 1 12,22 10,10 0 0 1 2,12 10,10 0 0 1 12,2 10,10 0 0 1 22,12 Z" },
            { "arrow-up-circle", "M 12,16 V 8 m 4,4 -4,-4 -4,4 m 14,0 A 10,10 0 0 1 12,22 10,10 0 0 1 2,12 10,10 0 0 1 12,2 10,10 0 0 1 22,12 Z" }
        };
    }
}
