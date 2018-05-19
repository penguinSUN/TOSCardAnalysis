using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Common
{
    public static class StringHelper
    {
        public static List<string> SplitStringToList(string str, char separator)
        {
            return str.Split(separator).ToList();
        }
    }
}