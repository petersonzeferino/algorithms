using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Application.Services
{
    public class TwoStringsService : ITwoStringsService
    {
        public string CheckTwoStrings(string s1, string s2)
        {
            //byte[] asciiBytes1 = Encoding.ASCII.GetBytes(s1);
            //byte[] asciiBytes2 = Encoding.ASCII.GetBytes(s2);
            ////int total = asciiBytes1.Length + asciiBytes2.Length;
            //int count = 0;

            HashSet<char> s1Set = new HashSet<char>();
            HashSet<char> s2Set = new HashSet<char>();
            string output = "NO";

            foreach (char c in s1.ToCharArray())
                s1Set.Add(c);

            foreach (char c in s2.ToCharArray())
                s2Set.Add(c);

            s1Set.IntersectWith(s2Set);

            if (s1Set.Count > 0)
                output = "YES";

            return output;


            /////////////////////////////////////

            //char[] charS1 = s1.ToCharArray();
            //char[] charS2 = s2.ToCharArray();
            //int total = s1.Length + s2.Length;
            //int count = 0;
            //string output;

            //IEnumerable<char> union = charS1.Union(charS2);
            //count = total - union.Count();

            /////////////////////////////////////


            /////////////////////////////////////

            //count = (union.Where(x => (x == union[i])).Count() == a.Where(x => (x == a[j])).Count())

            //select

            //Array.Sort(asciiBytes1);
            //Array.Sort(asciiBytes2);

            //for (int i = 0; i < Math.Max(asciiBytes1.Length, asciiBytes2.Length); i++)
            //{
            //    if (gest_1[i] == gest_2[i])
            //        count
            //}

            //if (asciiBytes1.Length > asciiBytes2.Length)
            //{
            //    for (int p = 0; p < asciiBytes1.Length; p++)
            //    {
            //        for (int j = 0; j < asciiBytes2.Length; j++)
            //        {
            //            if (asciiBytes1[p] == asciiBytes2[j])
            //                count++;
            //        }
            //    }
            //}
            //else
            //{
            //    for (int p = 0; p < asciiBytes2.Length; p++)
            //    {
            //        for (int j = 0; j < asciiBytes1.Length; j++)
            //        {
            //            if (asciiBytes1[j] == asciiBytes2[p])
            //                count++;
            //        }
            //    }
            //}

            /////////////////////////////////////


            //if (count > 0)
            //    output = "YES";
            //else
            //    output = "NO";
        }
    }
}
