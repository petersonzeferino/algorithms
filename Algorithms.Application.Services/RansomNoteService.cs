using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Application.Services
{
    public class RansomNoteService : IRansomNoteService
    {
        public string CheckRansomNote(string s1, string s2)
        {
            int index = 0;

            string[] magazine = s1.Split(' ');
            string[] note = s2.Split(' ');
            string output = "Yes";

            Array.Sort(magazine);
            Array.Sort(note);

            IList<string> magList = magazine.ToList();

            foreach (string n in note)
            {
                if (!magList.Remove(n))
                {
                    return "No";
                }
            }

            //////////////////////////////////////////////////////////////////

            //Dictionary<string, string> magDictionary = new Dictionary<string, string>();
            //foreach (string c in magazine)
            //{
            //    magDictionary.Add(c, c);
            //    index++;
            //}

            //foreach (string n in note)
            //{
            //    if (!magDictionary.Remove(n))
            //    {
            //        output = "No";
            //        return;
            //    }

            //}

            //////////////////////////////////////////////////////////////////

            return output;

            //foreach (string c in s1.Split(" "))
            //    magazine.(c);

            //List<string> s1List = new List<string>();
            //foreach (string c in s1.Split(" "))
            //    s1List.Add(c);

            //Hashtable s1Hashtable = new Hashtable();
            //foreach (string c in magazine)
            //{
            //    s1Hashtable.Add(index, c);
            //    index++;
            //}                

            //Hashtable s2Hashtable = new Hashtable();

            //foreach (string c in s1.Split(" "))
            //    s1Hashtable.Keys(c);

            //HashSet<string> s1Set = new HashSet<string>();
            //HashSet<string> s2Set = new HashSet<string>();
            //HashSet<string> s3Set = new HashSet<string>();

            //foreach (string c in magazine)
            //    s1Set.Add(c);

            //foreach (string c in note)
            //    s2Set.Add(c);

            //index = 0;
            //foreach (string c in note) 
            //{
            //    if (!s1Hashtable.ContainsValue(c))
            //    {
            //        output = "No";
            //    }


            //    s1Hashtable.Remove(index);
            //    index++;
            //}               

            //output = s1Set.Contains(c) ? "Yes" : "No";


            //s1Set.Contains()

            //var teste = s1.Contains(s2);

            //if (teste)
            //    output = "YES";

            //output = "Yes";


            //string[] magazine = s1.Split(' ');
            //string[] note = s2.Split(' ');
            //string output = "Yes";
            //int index = 0;

            //if (note.Length > magazine.Length)
            //    return 'No';

            //const words = { };
            //let

            //Assert.Equal(output, result);

            //IAlgorithmsService _algorithmsService = new AlgorithmsService();

            //Assert.Equal(_algorithmsService.CheckMakingAnagrams(inputStringA, inputStringB), output);
        }
    }
}
