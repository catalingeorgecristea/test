using System;
using System.Collections.Generic;

namespace Test.Extensions
{
    public static class ArrayExtensions
    {
        public static HashSet<int> GetUniqueValues(this int[] source)
        {
            var uniqueValues = new HashSet<int>();
            Array.Sort(source);
            int totalCount = source.Length;
            for (int i = 0; i < source.Length; i++)
            {
                bool isFirst = i == 0;
                bool isLast = i == totalCount - 1;
                bool sameAsPrevious = !isFirst ? source[i] == source[i - 1] : false;
                bool sameAsNext = !isLast ? source[i] == source[i + 1] : false;
                if (!sameAsPrevious && !sameAsNext)
                {
                    uniqueValues.Add(source[i]);
                }
            }   

            return uniqueValues;
        }
    }
}
