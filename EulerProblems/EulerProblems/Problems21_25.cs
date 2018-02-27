using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Problems21_25
    {
        public long Euler22()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Files\\Names.txt";
            StreamReader r = new StreamReader(path);
            string namesAll;
            string[] names;
            List<string> sortedNames = new List<string>();
            long sum=0;
            long total=0;

            namesAll = r.ReadLine();
            names = namesAll.Split(',');
            Array.Sort(names);
            foreach(string n in names)
            {
                string clean = Regex.Replace(n, "[^A-Za-z0-9 ]", "");
                sortedNames.Add(clean);
            }

            foreach(var n in sortedNames)
            {
                sum = 0;
                foreach (char c in n)
                {
                    int val = Convert.ToInt32(c)-64;
                    sum += val;
                }
                total += (sum * (sortedNames.IndexOf(n) + 1));
            }

            return total;
        }
    }
}
