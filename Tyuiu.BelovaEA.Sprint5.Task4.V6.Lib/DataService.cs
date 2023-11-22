using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.BelovaEA.Sprint5.Task4.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            string x_str = File.ReadAllText(path);
            double x = Convert.ToDouble(x_str);
            double res = Math.Round((1 / Math.Cos(x) + 2.2 * Math.Pow(x,2)),3);
            return res;
        }
    }
}
