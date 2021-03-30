using System;

namespace Algorithms.Application.Services
{
    public class MakingAnagramsService : IMakingAnagramsService
    {
        public int CheckMakingAnagrams(string a, string b)
        {
            int[] charValues = new int[26];
            foreach (char c in a)
            {
                int cVal = (int)c - 97;//97 is lowercase a
                                       //Console.Write(cVal+"    "+c);
                charValues[cVal]++;
            }
            foreach (char c in b)
            {
                int cVal = (int)c - 97;//97 is lowercase a
                charValues[cVal]--;
            }
            int total = 0;
            foreach (int i in charValues)
            {
                total += Math.Abs(i);
            }

            return total;
        }

        //public int CheckMakingAnagrams(string a, string b)
        //{
        //    int numberDeletion = 0;

        //    return numberDeletion;
        //}

        //public int CheckMakingAnagrams(string a, string b)
        //{
        //    int count = 0;
        //    int total = a.Length + b.Length;
        //    int lastIndex = 0;

        //    if (a.Length < b.Length)
        //    {
        //        string[] selected = new string[a.Length];

        //        for (int i = 0; i < b.Length; i++)
        //        {
        //            for (int j = 0; j < a.Length; j++)
        //            {                      
        //                if (b[i] == a[j])
        //                {

        //                    if (selected.Where(x => (x == j.ToString())).Count() == 0)
        //                    {
        //                        selected[lastIndex] = j.ToString();
        //                        count++;
        //                        lastIndex++;
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        string[] selected = new string[b.Length];

        //        for (int i = 0; i < a.Length; i++)
        //        {
        //            for (int j = 0; j < b.Length; j++)
        //            {                    
        //                if (a[i] == b[j])
        //                {

        //                    if (selected.Where(x => (x == j.ToString())).Count() == 0)
        //                    {
        //                        selected[lastIndex] = j.ToString();
        //                        count++;
        //                        lastIndex++;
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    int numberDeletion = (total - (count * 2));

        //    return numberDeletion;
        //}        
    }
}
