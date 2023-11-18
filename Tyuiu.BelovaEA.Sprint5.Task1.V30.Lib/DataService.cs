using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.BelovaEA.Sprint5.Task1.V30.Lib
{
    public class DataService : ISprint5Task1V30
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo imeetca = new FileInfo(path);
            bool tyta = imeetca.Exists;

            if (tyta)
            {
                File.Delete(path);
            }

            double rez;
            string str_res;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x==1)
                {
                    rez = 0;
                }
                else
                {
                    rez = Math.Round((Math.Cos(x) + Math.Sin(x) / (2 - 2 * x) - 4 * x),2);
                }

                str_res = Convert.ToString(rez);

                if (x != stopValue)
                {
                    File.AppendAllText(path, str_res + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str_res);
                } 
            }

            return path;
        }
    }
}
