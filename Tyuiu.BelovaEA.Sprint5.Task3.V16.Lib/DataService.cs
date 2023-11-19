using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.BelovaEA.Sprint5.Task3.V16.Lib
{
    public class DataService : ISprint5Task3V16
    {
        public string SaveToFileTextData(int x)
        {
            double rez = Math.Round(((2 * Math.Pow(x, 2) - 1 )/ Math.Sqrt(Math.Pow(x, 2) - 2)),3);

            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

            FileInfo zdec = new FileInfo(path);
            bool tyta = zdec.Exists;

            using (BinaryWriter write = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                write.Write(BitConverter.GetBytes(rez));
            }

            return path;
        }
    }
}
