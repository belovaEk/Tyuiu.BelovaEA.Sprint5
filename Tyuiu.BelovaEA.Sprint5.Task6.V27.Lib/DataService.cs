using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.BelovaEA.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string str = File.ReadAllText(path);
            string[] s = str.Split();
            int n;
            for (int i = 0; i < s.Length; i++)
            {
                if (int.TryParse(s[i], out n) && s[i].Length == 3)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
