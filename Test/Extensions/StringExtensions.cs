using System.Collections.Generic;

namespace Test.Extensions
{
    public static class StringExtensions
    {
        public static bool HasBalancedBrakets(this string source)
        {
            bool balanced = false;
            Stack<char> s = new Stack<char>();
            foreach (var item in source)
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
