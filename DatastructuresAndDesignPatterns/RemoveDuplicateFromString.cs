using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndDesignPatterns
{
    #region Problem statement
    /*
     Question: Given a string Str which may contains lowercase and uppercase chracters. The task is to remove all duplicate characters from the string and find the resultant string. The order of remaining characters in the output should be same as in the original string.

        Example 1:

        Input:
        Str = geeksforgeeks
        Output: geksfor
        Explanation: After removing duplicate
        characters such as e, k, g, s, we have
        string as "geksfor".
        Example 2:

        Input:
        Str = HappyNewYear
        Output: HapyNewYr
        Explanation: After removing duplicate
        characters such as p, e, a, we have
        string as "HapyNewYr".
     */
    #endregion

    public class RemoveDuplicateFromString
    {
        public string RemoveDuplicateCharMethod1(string str)
        {
            char[] inputs = str.ToCharArray();

            string output = string.Empty;

            foreach (var c in inputs)
            {
                if(!output.Contains(c))
                {
                    output += c;
                }
            }

            return output;
        }

        public string RemoveDuplicateCharMethod2(string str)
        {
            char[] inputs = str.ToCharArray();

            string output = string.Empty;

            for (int i = 0; i < inputs.Length; i++)
            {
                int j;
                for (j = 0; j < i; j++)
                {
                    if (inputs[i] == inputs[j])
                        break;
                }

                if (i == j)
                {
                    output += inputs[i];
                }
            }

            return output;
        }

        public string RemoveDuplicateCharMethod3(string str)
        {
            char[] inputs = str.ToCharArray();
            char[] output = new char[str.Length];

            HashSet<char> set = new HashSet<char>();

            for (int i = 0; i < inputs.Length; i++)
            {
                set.Add(str[i]);
            }
            set.CopyTo(output);
            return string.Join("", output);
        }
    }
}
