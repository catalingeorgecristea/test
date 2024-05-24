using System.Collections.Generic;
using Xunit;

namespace Test.Extensions
{
    internal static class StringExtensions
    {
        public static bool HasBalancedBrakets(this string input)
        {
            bool balanced = false;
            Stack<char> s = new Stack<char>();
            foreach (var item in input)
            {
                if (item == '(' || item == '[' || item == '{')
                    s.Push(item);
                else if (item == ')' || item == ']' || item == '}')
                {
                    var poped = s.Pop();
                    if (poped == '(' && item == ')')
                        balanced = true;
                    else if (poped == '[' && item == ']')
                        balanced = true;
                    else if (poped == '{' && item == '}')
                        balanced = true;
                    else
                        return balanced = false;
                }
            }
            if (balanced == true)
                return true;
            else
                return false;
        }
    }
}
