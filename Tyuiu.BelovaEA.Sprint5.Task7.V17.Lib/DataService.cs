using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.BelovaEA.Sprint5.Task7.V17.Lib
{
    public class DataService : ISprint5Task7V17
    {
        public string LoadDataAndSave(string path)
        {
            string path_out = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7V17.txt";

            FileInfo imeetca = new FileInfo(path_out);
            bool tyta = imeetca.Exists;

            if (tyta)
            {
                File.Delete(path_out);
            }

            string str = File.ReadAllText(path);

            str = str.Replace("нн", "");

            File.AppendAllText(path_out, str);

            return path_out;
        }

    }
}
