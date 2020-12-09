using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZBenjaminUtilities
{
    public static class MultiSeparatorJoin
    {
/*        public static string MultiSepJoin(Dictionary<int, string> separators, params string[] pvalues)
        {
            return MultiSepJoin(separators, values: pvalues);
        }*/

        public static string MultiSepJoin(Dictionary<int, string> separators, IEnumerable<string> values)
        {
            var sortedSep = separators.OrderBy(sep => sep.Key).ToDictionary(sep => sep.Key, sep => sep.Value);
            var valuesList = values.ToList();
            
            var sb = new StringBuilder();
            sb.Append(valuesList[0]);

            for (var i = 1; i < valuesList.Count; i++)
            {
                sb.Append(GetSeparatorFromIter(i, sortedSep) + valuesList[i]);
            }

            return sb.ToString();
        }

        private static string GetSeparatorFromIter(int c, Dictionary<int, string> separators)
        {
            for (var i = separators.Count - 1; i >= 0; i--)
            {
                if (c % separators.ElementAt(i).Key == 0) return separators.ElementAt(i).Value;
            }

            return separators.ElementAt(0).Value;
        }
    }
}