using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint5.Task7.V17.Lib;
using System.IO;

namespace Tyuiu.BelovaEA.Sprint5.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V17.txt";

            FileInfo info = new FileInfo(path);
            bool tyta = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, tyta);
        }

        [TestMethod]

        public void CheckLoadFromDataFile()
        {
            string path = @"C:\Users\belov\source\repos\Tyuiu.BelovaEA.Sprint5\Tyuiu.BelovaEA.Sprint5.Task7.V17\bin\Debug\OutPutFileTask7V17.txt";

            DataService ds = new DataService();
            FileInfo fileInfo = new FileInfo(path);
            bool tyta = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, tyta);
        }
             
    }
}
